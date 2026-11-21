using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
	// Token: 0x020003D7 RID: 983
	[NullableContext(1)]
	[Nullable(0)]
	public class CancellationTokenSource : IDisposable
	{
		// Token: 0x06003FB7 RID: 16311 RVA: 0x000D4E9F File Offset: 0x000D309F
		private static void TimerCallback(object state)
		{
			((CancellationTokenSource)state).NotifyCancellation(false);
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003FB8 RID: 16312 RVA: 0x000D4EAD File Offset: 0x000D30AD
		public bool IsCancellationRequested
		{
			get
			{
				return this._state > CancellationTokenSource.States.NotCanceledState;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x000D4EBA File Offset: 0x000D30BA
		internal bool IsCancellationCompleted
		{
			get
			{
				return this._state == CancellationTokenSource.States.NotifyingCompleteState;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003FBA RID: 16314 RVA: 0x000D4EC7 File Offset: 0x000D30C7
		public CancellationToken Token
		{
			get
			{
				this.ThrowIfDisposed();
				return new CancellationToken(this);
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x000D4ED8 File Offset: 0x000D30D8
		internal WaitHandle WaitHandle
		{
			get
			{
				this.ThrowIfDisposed();
				if (this._kernelEvent != null)
				{
					return this._kernelEvent;
				}
				ManualResetEvent manualResetEvent = new ManualResetEvent(false);
				if (Interlocked.CompareExchange<ManualResetEvent>(ref this._kernelEvent, manualResetEvent, null) != null)
				{
					manualResetEvent.Dispose();
				}
				if (this.IsCancellationRequested)
				{
					this._kernelEvent.Set();
				}
				return this._kernelEvent;
			}
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00005ACC File Offset: 0x00003CCC
		public CancellationTokenSource()
		{
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x000D4F38 File Offset: 0x000D3138
		public CancellationTokenSource(TimeSpan delay) : this(delay, TimeProvider.System)
		{
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x000D4F48 File Offset: 0x000D3148
		public CancellationTokenSource(TimeSpan delay, TimeProvider timeProvider)
		{
			ArgumentNullException.ThrowIfNull(timeProvider, "timeProvider");
			long num = (long)delay.TotalMilliseconds;
			if (num < -1L || num > (long)((ulong)-2))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.delay);
			}
			this.InitializeWithTimer(delay, timeProvider);
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x000D4F89 File Offset: 0x000D3189
		public CancellationTokenSource(int millisecondsDelay)
		{
			if (millisecondsDelay < -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.millisecondsDelay);
			}
			this.InitializeWithTimer(TimeSpan.FromMilliseconds((long)millisecondsDelay, 0L), TimeProvider.System);
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x000D4FB0 File Offset: 0x000D31B0
		private void InitializeWithTimer(TimeSpan millisecondsDelay, TimeProvider timeProvider)
		{
			if (millisecondsDelay == TimeSpan.Zero)
			{
				this._state = CancellationTokenSource.States.NotifyingCompleteState;
				return;
			}
			if (timeProvider == TimeProvider.System)
			{
				this._timer = new TimerQueueTimer(CancellationTokenSource.s_timerCallback, this, millisecondsDelay, Timeout.InfiniteTimeSpan, false);
				return;
			}
			using (ExecutionContext.SuppressFlow())
			{
				this._timer = timeProvider.CreateTimer(CancellationTokenSource.s_timerCallback, this, millisecondsDelay, Timeout.InfiniteTimeSpan);
			}
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x000D5038 File Offset: 0x000D3238
		public void Cancel()
		{
			this.Cancel(false);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x000D5041 File Offset: 0x000D3241
		public void Cancel(bool throwOnFirstException)
		{
			this.ThrowIfDisposed();
			this.NotifyCancellation(throwOnFirstException);
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x000D5050 File Offset: 0x000D3250
		public Task CancelAsync()
		{
			if (this._disposed)
			{
				return Task.FromException(new ObjectDisposedException(base.GetType().FullName, SR.CancellationTokenSource_Disposed));
			}
			if (this.TransitionToCancellationRequested())
			{
				CancellationTokenSource.Registrations registrations = Volatile.Read<CancellationTokenSource.Registrations>(ref this._registrations);
				if (registrations != null)
				{
					registrations.EnterLock();
					bool flag = registrations.Callbacks != null;
					registrations.ExitLock();
					if (flag)
					{
						return Task.Factory.StartNew(delegate(object s)
						{
							((CancellationTokenSource)s).ExecuteCallbackHandlers(false);
						}, this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
					}
				}
			}
			return Task.CompletedTask;
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x000D50EC File Offset: 0x000D32EC
		public void CancelAfter(TimeSpan delay)
		{
			long num = (long)delay.TotalMilliseconds;
			if (num < -1L || num > (long)((ulong)-2))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.delay);
			}
			this.CancelAfter((uint)num);
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x000D511C File Offset: 0x000D331C
		public void CancelAfter(int millisecondsDelay)
		{
			if (millisecondsDelay < -1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.millisecondsDelay);
			}
			this.CancelAfter((uint)millisecondsDelay);
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x000D5130 File Offset: 0x000D3330
		private void CancelAfter(uint millisecondsDelay)
		{
			this.ThrowIfDisposed();
			if (this.IsCancellationRequested)
			{
				return;
			}
			ITimer timer = this._timer;
			if (timer == null)
			{
				timer = new TimerQueueTimer(CancellationTokenSource.s_timerCallback, this, uint.MaxValue, uint.MaxValue, false);
				ITimer timer2 = Interlocked.CompareExchange<ITimer>(ref this._timer, timer, null);
				if (timer2 != null)
				{
					timer.Dispose();
					timer = timer2;
				}
			}
			timer.Change((millisecondsDelay == uint.MaxValue) ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds((long)((ulong)millisecondsDelay), 0L), Timeout.InfiniteTimeSpan);
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x000D51A0 File Offset: 0x000D33A0
		public bool TryReset()
		{
			this.ThrowIfDisposed();
			if (this._state == CancellationTokenSource.States.NotCanceledState)
			{
				bool flag;
				if (this._timer != null)
				{
					TimerQueueTimer timerQueueTimer = this._timer as TimerQueueTimer;
					flag = (timerQueueTimer != null && timerQueueTimer.Change(uint.MaxValue, uint.MaxValue) && !timerQueueTimer._everQueued);
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					CancellationTokenSource.Registrations registrations = Volatile.Read<CancellationTokenSource.Registrations>(ref this._registrations);
					if (registrations != null)
					{
						registrations.UnregisterAll();
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x000D520C File Offset: 0x000D340C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x000D521C File Offset: 0x000D341C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this._disposed)
			{
				ITimer timer = this._timer;
				if (timer != null)
				{
					this._timer = null;
					timer.Dispose();
				}
				this._registrations = null;
				if (this._kernelEvent != null)
				{
					ManualResetEvent manualResetEvent = Interlocked.Exchange<ManualResetEvent>(ref this._kernelEvent, null);
					if (manualResetEvent != null && this._state != CancellationTokenSource.States.NotifyingState)
					{
						manualResetEvent.Dispose();
					}
				}
				this._disposed = true;
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x000D5288 File Offset: 0x000D3488
		private void ThrowIfDisposed()
		{
			if (this._disposed)
			{
				ThrowHelper.ThrowObjectDisposedException(ExceptionResource.CancellationTokenSource_Disposed);
			}
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x000D529C File Offset: 0x000D349C
		internal CancellationTokenRegistration Register(Delegate callback, object stateForCallback, SynchronizationContext syncContext, ExecutionContext executionContext)
		{
			if (!this.IsCancellationRequested)
			{
				if (this._disposed)
				{
					return default(CancellationTokenRegistration);
				}
				CancellationTokenSource.Registrations registrations = Volatile.Read<CancellationTokenSource.Registrations>(ref this._registrations);
				if (registrations == null)
				{
					registrations = new CancellationTokenSource.Registrations(this);
					registrations = (Interlocked.CompareExchange<CancellationTokenSource.Registrations>(ref this._registrations, registrations, null) ?? registrations);
				}
				CancellationTokenSource.CallbackNode callbackNode = null;
				long id = 0L;
				if (registrations.FreeNodeList != null)
				{
					registrations.EnterLock();
					try
					{
						callbackNode = registrations.FreeNodeList;
						if (callbackNode != null)
						{
							registrations.FreeNodeList = callbackNode.Next;
							CancellationTokenSource.CallbackNode callbackNode2 = callbackNode;
							CancellationTokenSource.Registrations registrations2 = registrations;
							long nextAvailableId = registrations2.NextAvailableId;
							registrations2.NextAvailableId = nextAvailableId + 1L;
							id = (callbackNode2.Id = nextAvailableId);
							callbackNode.Callback = callback;
							callbackNode.CallbackState = stateForCallback;
							callbackNode.ExecutionContext = executionContext;
							callbackNode.SynchronizationContext = syncContext;
							callbackNode.Next = registrations.Callbacks;
							registrations.Callbacks = callbackNode;
							if (callbackNode.Next != null)
							{
								callbackNode.Next.Prev = callbackNode;
							}
						}
					}
					finally
					{
						registrations.ExitLock();
					}
				}
				if (callbackNode == null)
				{
					callbackNode = new CancellationTokenSource.CallbackNode(registrations);
					callbackNode.Callback = callback;
					callbackNode.CallbackState = stateForCallback;
					callbackNode.ExecutionContext = executionContext;
					callbackNode.SynchronizationContext = syncContext;
					registrations.EnterLock();
					try
					{
						CancellationTokenSource.CallbackNode callbackNode3 = callbackNode;
						CancellationTokenSource.Registrations registrations3 = registrations;
						long nextAvailableId = registrations3.NextAvailableId;
						registrations3.NextAvailableId = nextAvailableId + 1L;
						id = (callbackNode3.Id = nextAvailableId);
						callbackNode.Next = registrations.Callbacks;
						if (callbackNode.Next != null)
						{
							callbackNode.Next.Prev = callbackNode;
						}
						registrations.Callbacks = callbackNode;
					}
					finally
					{
						registrations.ExitLock();
					}
				}
				if (!this.IsCancellationRequested || !registrations.Unregister(id, callbackNode))
				{
					return new CancellationTokenRegistration(id, callbackNode);
				}
			}
			CancellationTokenSource.Invoke(callback, stateForCallback, this);
			return default(CancellationTokenRegistration);
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x000D5448 File Offset: 0x000D3648
		private void NotifyCancellation(bool throwOnFirstException)
		{
			if (this.TransitionToCancellationRequested())
			{
				this.ExecuteCallbackHandlers(throwOnFirstException);
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x000D545C File Offset: 0x000D365C
		private bool TransitionToCancellationRequested()
		{
			if (!this.IsCancellationRequested && Interlocked.CompareExchange<CancellationTokenSource.States>(ref this._state, CancellationTokenSource.States.NotifyingState, CancellationTokenSource.States.NotCanceledState) == CancellationTokenSource.States.NotCanceledState)
			{
				ITimer timer = this._timer;
				if (timer != null)
				{
					this._timer = null;
					timer.Dispose();
				}
				ManualResetEvent kernelEvent = this._kernelEvent;
				if (kernelEvent != null)
				{
					kernelEvent.Set();
				}
				return true;
			}
			return false;
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x000D54B4 File Offset: 0x000D36B4
		private void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
			CancellationTokenSource.Registrations registrations = Interlocked.Exchange<CancellationTokenSource.Registrations>(ref this._registrations, null);
			if (registrations == null)
			{
				Interlocked.Exchange<CancellationTokenSource.States>(ref this._state, CancellationTokenSource.States.NotifyingCompleteState);
				return;
			}
			registrations.ThreadIDExecutingCallbacks = Environment.CurrentManagedThreadId;
			List<Exception> list = null;
			try
			{
				for (;;)
				{
					registrations.EnterLock();
					CancellationTokenSource.CallbackNode callbacks;
					try
					{
						callbacks = registrations.Callbacks;
						if (callbacks == null)
						{
							break;
						}
						if (callbacks.Next != null)
						{
							callbacks.Next.Prev = null;
						}
						registrations.Callbacks = callbacks.Next;
						registrations.ExecutingCallbackId = callbacks.Id;
						callbacks.Id = 0L;
					}
					finally
					{
						registrations.ExitLock();
					}
					try
					{
						if (callbacks.SynchronizationContext != null)
						{
							callbacks.SynchronizationContext.Send(delegate(object s)
							{
								CancellationTokenSource.CallbackNode callbackNode = (CancellationTokenSource.CallbackNode)s;
								callbackNode.Registrations.ThreadIDExecutingCallbacks = Environment.CurrentManagedThreadId;
								callbackNode.ExecuteCallback();
							}, callbacks);
							registrations.ThreadIDExecutingCallbacks = Environment.CurrentManagedThreadId;
						}
						else
						{
							callbacks.ExecuteCallback();
						}
					}
					catch (Exception item) when (!throwOnFirstException)
					{
						List<Exception> list2;
						if ((list2 = list) == null)
						{
							list2 = (list = new List<Exception>());
						}
						list2.Add(item);
					}
				}
			}
			finally
			{
				this._state = CancellationTokenSource.States.NotifyingCompleteState;
				Interlocked.Exchange(ref registrations.ExecutingCallbackId, 0L);
			}
			if (list != null)
			{
				throw new AggregateException(list);
			}
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x000D5608 File Offset: 0x000D3808
		public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			if (!token1.CanBeCanceled)
			{
				return CancellationTokenSource.CreateLinkedTokenSource(token2);
			}
			if (!token2.CanBeCanceled)
			{
				return new CancellationTokenSource.Linked1CancellationTokenSource(token1);
			}
			return new CancellationTokenSource.Linked2CancellationTokenSource(token1, token2);
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x000D5631 File Offset: 0x000D3831
		public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
		{
			if (!token.CanBeCanceled)
			{
				return new CancellationTokenSource();
			}
			return new CancellationTokenSource.Linked1CancellationTokenSource(token);
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x000D5648 File Offset: 0x000D3848
		public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens)
		{
			ArgumentNullException.ThrowIfNull(tokens, "tokens");
			return CancellationTokenSource.CreateLinkedTokenSource(tokens);
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x000D5660 File Offset: 0x000D3860
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe static CancellationTokenSource CreateLinkedTokenSource([ParamCollection] [ScopedRef] ReadOnlySpan<CancellationToken> tokens)
		{
			CancellationTokenSource result;
			switch (tokens.Length)
			{
			case 0:
				throw new ArgumentException(SR.CancellationToken_CreateLinkedToken_TokensIsEmpty);
			case 1:
				result = CancellationTokenSource.CreateLinkedTokenSource(*tokens[0]);
				break;
			case 2:
				result = CancellationTokenSource.CreateLinkedTokenSource(*tokens[0], *tokens[1]);
				break;
			default:
				result = new CancellationTokenSource.LinkedNCancellationTokenSource(tokens);
				break;
			}
			return result;
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x000D56D4 File Offset: 0x000D38D4
		private static void Invoke(Delegate d, object state, CancellationTokenSource source)
		{
			Action<object> action = d as Action<object>;
			if (action != null)
			{
				action(state);
				return;
			}
			((Action<object, CancellationToken>)d)(state, new CancellationToken(source));
		}

		// Token: 0x04000D2B RID: 3371
		internal static readonly CancellationTokenSource s_canceledSource = new CancellationTokenSource
		{
			_state = CancellationTokenSource.States.NotifyingCompleteState
		};

		// Token: 0x04000D2C RID: 3372
		internal static readonly CancellationTokenSource s_neverCanceledSource = new CancellationTokenSource();

		// Token: 0x04000D2D RID: 3373
		private static readonly TimerCallback s_timerCallback = new TimerCallback(CancellationTokenSource.TimerCallback);

		// Token: 0x04000D2E RID: 3374
		private volatile CancellationTokenSource.States _state;

		// Token: 0x04000D2F RID: 3375
		private bool _disposed;

		// Token: 0x04000D30 RID: 3376
		private volatile ITimer _timer;

		// Token: 0x04000D31 RID: 3377
		private volatile ManualResetEvent _kernelEvent;

		// Token: 0x04000D32 RID: 3378
		private CancellationTokenSource.Registrations _registrations;

		// Token: 0x020003D8 RID: 984
		private enum States
		{
			// Token: 0x04000D34 RID: 3380
			NotCanceledState,
			// Token: 0x04000D35 RID: 3381
			NotifyingState,
			// Token: 0x04000D36 RID: 3382
			NotifyingCompleteState
		}

		// Token: 0x020003D9 RID: 985
		private sealed class Linked1CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06003FD5 RID: 16341 RVA: 0x000D5735 File Offset: 0x000D3935
			internal Linked1CancellationTokenSource(CancellationToken token1)
			{
				this._reg1 = token1.UnsafeRegister(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
			}

			// Token: 0x06003FD6 RID: 16342 RVA: 0x000D5750 File Offset: 0x000D3950
			protected override void Dispose(bool disposing)
			{
				if (!disposing || this._disposed)
				{
					return;
				}
				this._reg1.Dispose();
				base.Dispose(disposing);
			}

			// Token: 0x04000D37 RID: 3383
			private readonly CancellationTokenRegistration _reg1;
		}

		// Token: 0x020003DA RID: 986
		private sealed class Linked2CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06003FD7 RID: 16343 RVA: 0x000D5770 File Offset: 0x000D3970
			internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
			{
				this._reg1 = token1.UnsafeRegister(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
				this._reg2 = token2.UnsafeRegister(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
			}

			// Token: 0x06003FD8 RID: 16344 RVA: 0x000D579E File Offset: 0x000D399E
			protected override void Dispose(bool disposing)
			{
				if (!disposing || this._disposed)
				{
					return;
				}
				this._reg1.Dispose();
				this._reg2.Dispose();
				base.Dispose(disposing);
			}

			// Token: 0x04000D38 RID: 3384
			private readonly CancellationTokenRegistration _reg1;

			// Token: 0x04000D39 RID: 3385
			private readonly CancellationTokenRegistration _reg2;
		}

		// Token: 0x020003DB RID: 987
		private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x06003FD9 RID: 16345 RVA: 0x000D57CC File Offset: 0x000D39CC
			internal LinkedNCancellationTokenSource(ReadOnlySpan<CancellationToken> tokens)
			{
				this._linkingRegistrations = new CancellationTokenRegistration[tokens.Length];
				for (int i = 0; i < tokens.Length; i++)
				{
					if (tokens[i].CanBeCanceled)
					{
						this._linkingRegistrations[i] = tokens[i].UnsafeRegister(CancellationTokenSource.LinkedNCancellationTokenSource.s_linkedTokenCancelDelegate, this);
					}
				}
			}

			// Token: 0x06003FDA RID: 16346 RVA: 0x000D5834 File Offset: 0x000D3A34
			protected override void Dispose(bool disposing)
			{
				if (!disposing || this._disposed)
				{
					return;
				}
				CancellationTokenRegistration[] linkingRegistrations = this._linkingRegistrations;
				if (linkingRegistrations != null)
				{
					this._linkingRegistrations = null;
					for (int i = 0; i < linkingRegistrations.Length; i++)
					{
						linkingRegistrations[i].Dispose();
					}
				}
				base.Dispose(disposing);
			}

			// Token: 0x04000D3A RID: 3386
			internal static readonly Action<object> s_linkedTokenCancelDelegate = delegate(object s)
			{
				((CancellationTokenSource)s).NotifyCancellation(false);
			};

			// Token: 0x04000D3B RID: 3387
			private CancellationTokenRegistration[] _linkingRegistrations;
		}

		// Token: 0x020003DD RID: 989
		internal sealed class Registrations
		{
			// Token: 0x06003FDF RID: 16351 RVA: 0x000D58B0 File Offset: 0x000D3AB0
			public Registrations(CancellationTokenSource source)
			{
				this.Source = source;
			}

			// Token: 0x06003FE0 RID: 16352 RVA: 0x000D58D0 File Offset: 0x000D3AD0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void Recycle(CancellationTokenSource.CallbackNode node)
			{
				node.Id = 0L;
				node.Callback = null;
				node.CallbackState = null;
				node.ExecutionContext = null;
				node.SynchronizationContext = null;
				node.Prev = null;
				node.Next = this.FreeNodeList;
				this.FreeNodeList = node;
			}

			// Token: 0x06003FE1 RID: 16353 RVA: 0x000D5910 File Offset: 0x000D3B10
			public bool Unregister(long id, CancellationTokenSource.CallbackNode node)
			{
				if (id == 0L)
				{
					return false;
				}
				this.EnterLock();
				bool result;
				try
				{
					if (node.Id != id)
					{
						result = false;
					}
					else
					{
						if (this.Callbacks == node)
						{
							this.Callbacks = node.Next;
						}
						else
						{
							node.Prev.Next = node.Next;
						}
						if (node.Next != null)
						{
							node.Next.Prev = node.Prev;
						}
						this.Recycle(node);
						result = true;
					}
				}
				finally
				{
					this.ExitLock();
				}
				return result;
			}

			// Token: 0x06003FE2 RID: 16354 RVA: 0x000D599C File Offset: 0x000D3B9C
			public void UnregisterAll()
			{
				this.EnterLock();
				try
				{
					CancellationTokenSource.CallbackNode callbackNode = this.Callbacks;
					this.Callbacks = null;
					while (callbackNode != null)
					{
						CancellationTokenSource.CallbackNode next = callbackNode.Next;
						this.Recycle(callbackNode);
						callbackNode = next;
					}
				}
				finally
				{
					this.ExitLock();
				}
			}

			// Token: 0x06003FE3 RID: 16355 RVA: 0x000D59EC File Offset: 0x000D3BEC
			public void WaitForCallbackToComplete(long id)
			{
				SpinWait spinWait = default(SpinWait);
				while (Volatile.Read(ref this.ExecutingCallbackId) == id)
				{
					spinWait.SpinOnce();
				}
			}

			// Token: 0x06003FE4 RID: 16356 RVA: 0x000D5A18 File Offset: 0x000D3C18
			public ValueTask WaitForCallbackToCompleteAsync(long id)
			{
				CancellationTokenSource.Registrations.<WaitForCallbackToCompleteAsync>d__12 <WaitForCallbackToCompleteAsync>d__;
				<WaitForCallbackToCompleteAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
				<WaitForCallbackToCompleteAsync>d__.<>4__this = this;
				<WaitForCallbackToCompleteAsync>d__.id = id;
				<WaitForCallbackToCompleteAsync>d__.<>1__state = -1;
				<WaitForCallbackToCompleteAsync>d__.<>t__builder.Start<CancellationTokenSource.Registrations.<WaitForCallbackToCompleteAsync>d__12>(ref <WaitForCallbackToCompleteAsync>d__);
				return <WaitForCallbackToCompleteAsync>d__.<>t__builder.Task;
			}

			// Token: 0x06003FE5 RID: 16357 RVA: 0x000D5A64 File Offset: 0x000D3C64
			public void EnterLock()
			{
				ref bool ptr = ref this._locked;
				if (Interlocked.Exchange<bool>(ref ptr, true))
				{
					CancellationTokenSource.Registrations.<EnterLock>g__Contention|13_0(ref ptr);
				}
			}

			// Token: 0x06003FE6 RID: 16358 RVA: 0x000D5A87 File Offset: 0x000D3C87
			public void ExitLock()
			{
				this._locked = false;
			}

			// Token: 0x06003FE7 RID: 16359 RVA: 0x000D5A94 File Offset: 0x000D3C94
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void <EnterLock>g__Contention|13_0(ref bool value)
			{
				SpinWait spinWait = default(SpinWait);
				do
				{
					spinWait.SpinOnce();
				}
				while (Interlocked.Exchange<bool>(ref value, true));
			}

			// Token: 0x04000D3D RID: 3389
			public readonly CancellationTokenSource Source;

			// Token: 0x04000D3E RID: 3390
			public CancellationTokenSource.CallbackNode Callbacks;

			// Token: 0x04000D3F RID: 3391
			public CancellationTokenSource.CallbackNode FreeNodeList;

			// Token: 0x04000D40 RID: 3392
			public long NextAvailableId = 1L;

			// Token: 0x04000D41 RID: 3393
			public long ExecutingCallbackId;

			// Token: 0x04000D42 RID: 3394
			public volatile int ThreadIDExecutingCallbacks = -1;

			// Token: 0x04000D43 RID: 3395
			private volatile bool _locked;
		}

		// Token: 0x020003DF RID: 991
		internal sealed class CallbackNode
		{
			// Token: 0x06003FEA RID: 16362 RVA: 0x000D5B9E File Offset: 0x000D3D9E
			public CallbackNode(CancellationTokenSource.Registrations registrations)
			{
				this.Registrations = registrations;
			}

			// Token: 0x06003FEB RID: 16363 RVA: 0x000D5BB0 File Offset: 0x000D3DB0
			public void ExecuteCallback()
			{
				ExecutionContext executionContext = this.ExecutionContext;
				if (executionContext == null)
				{
					CancellationTokenSource.Invoke(this.Callback, this.CallbackState, this.Registrations.Source);
					return;
				}
				ExecutionContext.RunInternal(executionContext, delegate(object s)
				{
					CancellationTokenSource.CallbackNode callbackNode = (CancellationTokenSource.CallbackNode)s;
					CancellationTokenSource.Invoke(callbackNode.Callback, callbackNode.CallbackState, callbackNode.Registrations.Source);
				}, this);
			}

			// Token: 0x04000D49 RID: 3401
			public readonly CancellationTokenSource.Registrations Registrations;

			// Token: 0x04000D4A RID: 3402
			public CancellationTokenSource.CallbackNode Prev;

			// Token: 0x04000D4B RID: 3403
			public CancellationTokenSource.CallbackNode Next;

			// Token: 0x04000D4C RID: 3404
			public long Id;

			// Token: 0x04000D4D RID: 3405
			public Delegate Callback;

			// Token: 0x04000D4E RID: 3406
			public object CallbackState;

			// Token: 0x04000D4F RID: 3407
			public ExecutionContext ExecutionContext;

			// Token: 0x04000D50 RID: 3408
			public SynchronizationContext SynchronizationContext;
		}
	}
}
