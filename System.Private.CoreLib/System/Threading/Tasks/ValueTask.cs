using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
	// Token: 0x020004EA RID: 1258
	[NullableContext(1)]
	[Nullable(0)]
	[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct ValueTask : IEquatable<ValueTask>
	{
		// Token: 0x060047B4 RID: 18356 RVA: 0x000EF3D4 File Offset: 0x000ED5D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(Task task)
		{
			if (task == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			this._obj = task;
			this._continueOnCapturedContext = true;
			this._token = 0;
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x000EF3F5 File Offset: 0x000ED5F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ValueTask(IValueTaskSource source, short token)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			this._obj = source;
			this._token = token;
			this._continueOnCapturedContext = true;
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x000EF416 File Offset: 0x000ED616
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ValueTask(object obj, short token, bool continueOnCapturedContext)
		{
			this._obj = obj;
			this._token = token;
			this._continueOnCapturedContext = continueOnCapturedContext;
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x000EF430 File Offset: 0x000ED630
		public static ValueTask CompletedTask
		{
			get
			{
				return default(ValueTask);
			}
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x000EF446 File Offset: 0x000ED646
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ValueTask<TResult> FromResult<[Nullable(2)] TResult>(TResult result)
		{
			return new ValueTask<TResult>(result);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x000EF44E File Offset: 0x000ED64E
		public static ValueTask FromCanceled(CancellationToken cancellationToken)
		{
			return new ValueTask(Task.FromCanceled(cancellationToken));
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x000EF45B File Offset: 0x000ED65B
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ValueTask<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return new ValueTask<TResult>(Task.FromCanceled<TResult>(cancellationToken));
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x000EF468 File Offset: 0x000ED668
		public static ValueTask FromException(Exception exception)
		{
			return new ValueTask(Task.FromException(exception));
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x000EF475 File Offset: 0x000ED675
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ValueTask<TResult> FromException<[Nullable(2)] TResult>(Exception exception)
		{
			return new ValueTask<TResult>(Task.FromException<TResult>(exception));
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x000EF482 File Offset: 0x000ED682
		public override int GetHashCode()
		{
			object obj = this._obj;
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x000EF495 File Offset: 0x000ED695
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is ValueTask && this.Equals((ValueTask)obj);
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x000EF4AD File Offset: 0x000ED6AD
		public bool Equals(ValueTask other)
		{
			return this._obj == other._obj && this._token == other._token;
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x000EF4CD File Offset: 0x000ED6CD
		public static bool operator ==(ValueTask left, ValueTask right)
		{
			return left.Equals(right);
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x000EF4D7 File Offset: 0x000ED6D7
		public static bool operator !=(ValueTask left, ValueTask right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x000EF4E4 File Offset: 0x000ED6E4
		public Task AsTask()
		{
			object obj = this._obj;
			Task result;
			if (obj != null)
			{
				if ((result = (obj as Task)) == null)
				{
					return this.GetTaskForValueTaskSource(Unsafe.As<IValueTaskSource>(obj));
				}
			}
			else
			{
				result = Task.CompletedTask;
			}
			return result;
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x000EF517 File Offset: 0x000ED717
		public ValueTask Preserve()
		{
			if (this._obj != null)
			{
				return new ValueTask(this.AsTask());
			}
			return this;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x000EF534 File Offset: 0x000ED734
		private Task GetTaskForValueTaskSource(IValueTaskSource t)
		{
			ValueTaskSourceStatus status = t.GetStatus(this._token);
			if (status != ValueTaskSourceStatus.Pending)
			{
				try
				{
					t.GetResult(this._token);
					return Task.CompletedTask;
				}
				catch (Exception ex)
				{
					if (status != ValueTaskSourceStatus.Canceled)
					{
						return Task.FromException(ex);
					}
					OperationCanceledException ex2 = ex as OperationCanceledException;
					if (ex2 != null)
					{
						Task task = new Task();
						task.TrySetCanceled(ex2.CancellationToken, ex2);
						return task;
					}
					Task result;
					if ((result = ValueTask.s_canceledTask) == null)
					{
						result = (ValueTask.s_canceledTask = Task.FromCanceled(new CancellationToken(true)));
					}
					return result;
				}
			}
			return new ValueTask.ValueTaskSourceAsTask(t, this._token);
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x000EF5D4 File Offset: 0x000ED7D4
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
				Task task = obj as Task;
				if (task != null)
				{
					return task.IsCompleted;
				}
				return Unsafe.As<IValueTaskSource>(obj).GetStatus(this._token) > ValueTaskSourceStatus.Pending;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x000EF614 File Offset: 0x000ED814
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
				Task task = obj as Task;
				if (task != null)
				{
					return task.IsCompletedSuccessfully;
				}
				return Unsafe.As<IValueTaskSource>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Succeeded;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x000EF654 File Offset: 0x000ED854
		public bool IsFaulted
		{
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return false;
				}
				Task task = obj as Task;
				if (task != null)
				{
					return task.IsFaulted;
				}
				return Unsafe.As<IValueTaskSource>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Faulted;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x000EF694 File Offset: 0x000ED894
		public bool IsCanceled
		{
			get
			{
				object obj = this._obj;
				if (obj == null)
				{
					return false;
				}
				Task task = obj as Task;
				if (task != null)
				{
					return task.IsCanceled;
				}
				return Unsafe.As<IValueTaskSource>(obj).GetStatus(this._token) == ValueTaskSourceStatus.Canceled;
			}
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x000EF6D4 File Offset: 0x000ED8D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ThrowIfCompletedUnsuccessfully()
		{
			object obj = this._obj;
			if (obj != null)
			{
				Task task = obj as Task;
				if (task != null)
				{
					TaskAwaiter.ValidateEnd(task, ConfigureAwaitOptions.None);
					return;
				}
				Unsafe.As<IValueTaskSource>(obj).GetResult(this._token);
			}
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x000EF70E File Offset: 0x000ED90E
		internal static ValueTask DangerousCreateFromTypedValueTask<TResult>(ValueTask<TResult> valueTask)
		{
			return new ValueTask(valueTask._obj, valueTask._token, valueTask._continueOnCapturedContext);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x000EF727 File Offset: 0x000ED927
		public ValueTaskAwaiter GetAwaiter()
		{
			return new ValueTaskAwaiter(ref this);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x000EF730 File Offset: 0x000ED930
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			ValueTask valueTask = new ValueTask(this._obj, this._token, continueOnCapturedContext);
			return new ConfiguredValueTaskAwaitable(ref valueTask);
		}

		// Token: 0x040010F3 RID: 4339
		private static volatile Task s_canceledTask;

		// Token: 0x040010F4 RID: 4340
		internal readonly object _obj;

		// Token: 0x040010F5 RID: 4341
		internal readonly short _token;

		// Token: 0x040010F6 RID: 4342
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x020004EB RID: 1259
		private sealed class ValueTaskSourceAsTask : Task
		{
			// Token: 0x060047CD RID: 18381 RVA: 0x000EF757 File Offset: 0x000ED957
			internal ValueTaskSourceAsTask(IValueTaskSource source, short token)
			{
				this._token = token;
				this._source = source;
				source.OnCompleted(ValueTask.ValueTaskSourceAsTask.s_completionAction, this, token, ValueTaskSourceOnCompletedFlags.None);
			}

			// Token: 0x060047CF RID: 18383 RVA: 0x000EF794 File Offset: 0x000ED994
			[CompilerGenerated]
			internal static void <.cctor>g__ThrowUnexpectedStateForKnownCallback|4_1(object state)
			{
				string paramName = "state";
				ValueTask.ValueTaskSourceAsTask valueTaskSourceAsTask = state as ValueTask.ValueTaskSourceAsTask;
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
					defaultInterpolatedStringHandler.AppendFormatted<IValueTaskSource>(valueTaskSourceAsTask._source);
					actualValue = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				throw new ArgumentOutOfRangeException(paramName, actualValue, SR.Argument_UnexpectedStateForKnownCallback);
			}

			// Token: 0x040010F7 RID: 4343
			private static readonly Action<object> s_completionAction = delegate(object state)
			{
				ValueTask.ValueTaskSourceAsTask valueTaskSourceAsTask = state as ValueTask.ValueTaskSourceAsTask;
				if (valueTaskSourceAsTask != null)
				{
					IValueTaskSource source = valueTaskSourceAsTask._source;
					if (source != null)
					{
						valueTaskSourceAsTask._source = null;
						ValueTaskSourceStatus status = source.GetStatus(valueTaskSourceAsTask._token);
						try
						{
							source.GetResult(valueTaskSourceAsTask._token);
							valueTaskSourceAsTask.TrySetResult();
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
				ValueTask.ValueTaskSourceAsTask.<.cctor>g__ThrowUnexpectedStateForKnownCallback|4_1(state);
			};

			// Token: 0x040010F8 RID: 4344
			private IValueTaskSource _source;

			// Token: 0x040010F9 RID: 4345
			private readonly short _token;
		}
	}
}
