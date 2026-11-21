using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
	// Token: 0x020004ED RID: 1261
	[NullableContext(1)]
	[Nullable(0)]
	[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<>))]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct ValueTask<[Nullable(2)] TResult> : IEquatable<ValueTask<TResult>>
	{
		// Token: 0x060047D3 RID: 18387 RVA: 0x000EF8E8 File Offset: 0x000EDAE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(TResult result)
		{
			this._result = result;
			this._obj = null;
			this._continueOnCapturedContext = true;
			this._token = 0;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x000EF906 File Offset: 0x000EDB06
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(Task<TResult> task)
		{
			if (task == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			this._obj = task;
			this._result = default(TResult);
			this._continueOnCapturedContext = true;
			this._token = 0;
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x000EF933 File Offset: 0x000EDB33
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(IValueTaskSource<TResult> source, short token)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			this._obj = source;
			this._token = token;
			this._result = default(TResult);
			this._continueOnCapturedContext = true;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x000EF960 File Offset: 0x000EDB60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext)
		{
			this._obj = obj;
			this._result = result;
			this._token = token;
			this._continueOnCapturedContext = continueOnCapturedContext;
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x000EF980 File Offset: 0x000EDB80
		public override int GetHashCode()
		{
			if (this._obj != null)
			{
				return this._obj.GetHashCode();
			}
			if (this._result == null)
			{
				return 0;
			}
			TResult result = this._result;
			return result.GetHashCode();
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x000EF9C4 File Offset: 0x000EDBC4
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is ValueTask<TResult> && this.Equals((ValueTask<TResult>)obj);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x000EF9DC File Offset: 0x000EDBDC
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] ValueTask<TResult> other)
		{
			if (this._obj == null && other._obj == null)
			{
				return EqualityComparer<TResult>.Default.Equals(this._result, other._result);
			}
			return this._obj == other._obj && this._token == other._token;
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x000EFA2E File Offset: 0x000EDC2E
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] ValueTask<TResult> left, [Nullable(new byte[]
		{
			0,
			1
		})] ValueTask<TResult> right)
		{
			return left.Equals(right);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x000EFA38 File Offset: 0x000EDC38
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] ValueTask<TResult> left, [Nullable(new byte[]
		{
			0,
			1
		})] ValueTask<TResult> right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x000EFA48 File Offset: 0x000EDC48
		public Task<TResult> AsTask()
		{
			object obj = this._obj;
			if (obj == null)
			{
				return Task.FromResult<TResult>(this._result);
			}
			Task<TResult> task = obj as Task<TResult>;
			if (task != null)
			{
				return task;
			}
			return this.GetTaskForValueTaskSource(Unsafe.As<IValueTaskSource<TResult>>(obj));
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x000EFA83 File Offset: 0x000EDC83
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTask<TResult> Preserve()
		{
			if (this._obj != null)
			{
				return new ValueTask<TResult>(this.AsTask());
			}
			return this;
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x000EFAA0 File Offset: 0x000EDCA0
		private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t)
		{
			ValueTaskSourceStatus status = t.GetStatus(this._token);
			if (status != ValueTaskSourceStatus.Pending)
			{
				try
				{
					return Task.FromResult<TResult>(t.GetResult(this._token));
				}
				catch (Exception ex)
				{
					if (status != ValueTaskSourceStatus.Canceled)
					{
						return Task.FromException<TResult>(ex);
					}
					OperationCanceledException ex2 = ex as OperationCanceledException;
					if (ex2 != null)
					{
						Task<TResult> task = new Task<TResult>();
						task.TrySetCanceled(ex2.CancellationToken, ex2);
						return task;
					}
					Task<TResult> result;
					if ((result = ValueTask<TResult>.s_canceledTask) == null)
					{
						result = (ValueTask<TResult>.s_canceledTask = Task.FromCanceled<TResult>(new CancellationToken(true)));
					}
					return result;
				}
			}
			return new ValueTask<TResult>.ValueTaskSourceAsTask(t, this._token);
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x000EFB40 File Offset: 0x000EDD40
		public bool IsCompleted
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return true;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					return task.IsCompleted;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetStatus(this._token) > ValueTaskSourceStatus.Pending;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x000EFB80 File Offset: 0x000EDD80
		public bool IsCompletedSuccessfully
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return true;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					return task.IsCompletedSuccessfully;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Succeeded;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x000EFBC0 File Offset: 0x000EDDC0
		public bool IsFaulted
		{
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return false;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					return task.IsFaulted;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Faulted;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x000EFC00 File Offset: 0x000EDE00
		public bool IsCanceled
		{
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return false;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					return task.IsCanceled;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Canceled;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x000EFC40 File Offset: 0x000EDE40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return this._result;
				}
				Task<TResult> task = obj as Task<TResult>;
				if (task != null)
				{
					TaskAwaiter.ValidateEnd(task, ConfigureAwaitOptions.None);
					return task.ResultOnSuccess;
				}
				return Unsafe.As<IValueTaskSource<TResult>>(obj).GetResult(this._token);
			}
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000EFC87 File Offset: 0x000EDE87
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTaskAwaiter<TResult> GetAwaiter()
		{
			return new ValueTaskAwaiter<TResult>(ref this);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x000EFC90 File Offset: 0x000EDE90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			ValueTask<TResult> valueTask = new ValueTask<TResult>(this._obj, this._result, this._token, continueOnCapturedContext);
			return new ConfiguredValueTaskAwaitable<TResult>(ref valueTask);
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x000EFCC0 File Offset: 0x000EDEC0
		[NullableContext(2)]
		public override string ToString()
		{
			if (this.IsCompletedSuccessfully)
			{
				Debugger.NotifyOfCrossThreadDependency();
				TResult result = this.Result;
				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}

		// Token: 0x040010FB RID: 4347
		private static volatile Task<TResult> s_canceledTask;

		// Token: 0x040010FC RID: 4348
		internal readonly object _obj;

		// Token: 0x040010FD RID: 4349
		internal readonly TResult _result;

		// Token: 0x040010FE RID: 4350
		internal readonly short _token;

		// Token: 0x040010FF RID: 4351
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x020004EE RID: 1262
		private sealed class ValueTaskSourceAsTask : Task<TResult>
		{
			// Token: 0x060047E7 RID: 18407 RVA: 0x000EFCFC File Offset: 0x000EDEFC
			public ValueTaskSourceAsTask(IValueTaskSource<TResult> source, short token)
			{
				this._source = source;
				this._token = token;
				source.OnCompleted(ValueTask<TResult>.ValueTaskSourceAsTask.s_completionAction, this, token, ValueTaskSourceOnCompletedFlags.None);
			}

			// Token: 0x060047E9 RID: 18409 RVA: 0x000EFD38 File Offset: 0x000EDF38
			[CompilerGenerated]
			internal static void <.cctor>g__ThrowUnexpectedStateForKnownCallback|4_1(object state)
			{
				string paramName = "state";
				ValueTask<TResult>.ValueTaskSourceAsTask valueTaskSourceAsTask = state as ValueTask<TResult>.ValueTaskSourceAsTask;
				object actualValue;
				if (valueTaskSourceAsTask == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
					defaultInterpolatedStringHandler.AppendFormatted("state");
					defaultInterpolatedStringHandler.AppendLiteral(" : ");
					defaultInterpolatedStringHandler.AppendFormatted<object>(state);
					actualValue = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 3);
					defaultInterpolatedStringHandler.AppendFormatted("ValueTaskSourceAsTask");
					defaultInterpolatedStringHandler.AppendLiteral(".");
					defaultInterpolatedStringHandler.AppendFormatted("_source");
					defaultInterpolatedStringHandler.AppendLiteral(" : ");
					defaultInterpolatedStringHandler.AppendFormatted<IValueTaskSource<TResult>>(valueTaskSourceAsTask._source);
					actualValue = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				throw new ArgumentOutOfRangeException(paramName, actualValue, SR.Argument_UnexpectedStateForKnownCallback);
			}

			// Token: 0x04001100 RID: 4352
			private static readonly Action<object> s_completionAction = delegate(object state)
			{
				ValueTask<TResult>.ValueTaskSourceAsTask valueTaskSourceAsTask = state as ValueTask<TResult>.ValueTaskSourceAsTask;
				if (valueTaskSourceAsTask != null)
				{
					IValueTaskSource<TResult> source = valueTaskSourceAsTask._source;
					if (source != null)
					{
						valueTaskSourceAsTask._source = null;
						ValueTaskSourceStatus status = source.GetStatus(valueTaskSourceAsTask._token);
						try
						{
							valueTaskSourceAsTask.TrySetResult(source.GetResult(valueTaskSourceAsTask._token));
						}
						catch (Exception ex)
						{
							if (status == ValueTaskSourceStatus.Canceled)
							{
								OperationCanceledException ex2 = ex as OperationCanceledException;
								if (ex2 != null)
								{
									valueTaskSourceAsTask.TrySetCanceled(ex2.CancellationToken, ex2);
								}
								else
								{
									valueTaskSourceAsTask.TrySetCanceled(new CancellationToken(true));
								}
							}
							else
							{
								valueTaskSourceAsTask.TrySetException(ex);
							}
						}
						return;
					}
				}
				ValueTask<TResult>.ValueTaskSourceAsTask.<.cctor>g__ThrowUnexpectedStateForKnownCallback|4_1(state);
			};

			// Token: 0x04001101 RID: 4353
			private IValueTaskSource<TResult> _source;

			// Token: 0x04001102 RID: 4354
			private readonly short _token;
		}
	}
}
