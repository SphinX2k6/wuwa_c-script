using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000664 RID: 1636
	internal static class AsyncMethodBuilderCore
	{
		// Token: 0x0600732A RID: 29482 RVA: 0x00112710 File Offset: 0x00110910
		[DebuggerStepThrough]
		public static void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			if (stateMachine == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.stateMachine);
			}
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext = currentThread._executionContext;
			SynchronizationContext synchronizationContext = currentThread._synchronizationContext;
			try
			{
				stateMachine.MoveNext();
			}
			finally
			{
				if (synchronizationContext != currentThread._synchronizationContext)
				{
					currentThread._synchronizationContext = synchronizationContext;
				}
				ExecutionContext executionContext2 = currentThread._executionContext;
				if (executionContext != executionContext2)
				{
					ExecutionContext.RestoreChangedContextToThread(currentThread, executionContext, executionContext2);
				}
			}
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00112788 File Offset: 0x00110988
		public static void SetStateMachine(IAsyncStateMachine stateMachine, Task task)
		{
			if (stateMachine == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.stateMachine);
			}
			if (task != null)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.AsyncMethodBuilder_InstanceNotInitialized);
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x0011279E File Offset: 0x0011099E
		internal static bool TrackAsyncMethodCompletion
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return TplEventSource.Log.IsEnabled(EventLevel.Warning, (EventKeywords)256L);
			}
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x001127B4 File Offset: 0x001109B4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075:UnrecognizedReflectionPattern", Justification = "It's okay if unused fields disappear from debug views")]
		internal static string GetAsyncStateMachineDescription(IAsyncStateMachine stateMachine)
		{
			Type type = stateMachine.GetType();
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(type.FullName);
			foreach (FieldInfo fieldInfo in fields)
			{
				stringBuilder.Append("    ").Append(fieldInfo.Name).Append(": ").Append(fieldInfo.GetValue(stateMachine)).AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x00112831 File Offset: 0x00110A31
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LogTraceOperationBegin(Task t, Type stateMachineType)
		{
			TplEventSource.Log.TraceOperationBegin(t.Id, "Async: " + stateMachineType.Name, 0L);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00112855 File Offset: 0x00110A55
		internal static Action CreateContinuationWrapper(Action continuation, Action<Action, Task> invokeAction, Task innerTask)
		{
			return new Action(new AsyncMethodBuilderCore.ContinuationWrapper(continuation, invokeAction, innerTask).Invoke);
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x0011286C File Offset: 0x00110A6C
		internal static Action TryGetStateMachineForDebugger(Action action)
		{
			object target = action.Target;
			IAsyncStateMachineBox asyncStateMachineBox = target as IAsyncStateMachineBox;
			if (asyncStateMachineBox != null)
			{
				return new Action(asyncStateMachineBox.GetStateMachineObject().MoveNext);
			}
			AsyncMethodBuilderCore.ContinuationWrapper continuationWrapper = target as AsyncMethodBuilderCore.ContinuationWrapper;
			if (continuationWrapper == null)
			{
				return action;
			}
			return AsyncMethodBuilderCore.TryGetStateMachineForDebugger(continuationWrapper._continuation);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x001128B4 File Offset: 0x00110AB4
		internal static Task TryGetContinuationTask(Action continuation)
		{
			AsyncMethodBuilderCore.ContinuationWrapper continuationWrapper = continuation.Target as AsyncMethodBuilderCore.ContinuationWrapper;
			if (continuationWrapper == null)
			{
				return continuation.Target as Task;
			}
			return continuationWrapper._innerTask;
		}

		// Token: 0x02000665 RID: 1637
		private sealed class ContinuationWrapper
		{
			// Token: 0x06007332 RID: 29490 RVA: 0x001128E2 File Offset: 0x00110AE2
			internal ContinuationWrapper(Action continuation, Action<Action, Task> invokeAction, Task innerTask)
			{
				this._invokeAction = invokeAction;
				this._continuation = continuation;
				this._innerTask = innerTask;
			}

			// Token: 0x06007333 RID: 29491 RVA: 0x001128FF File Offset: 0x00110AFF
			internal void Invoke()
			{
				this._invokeAction(this._continuation, this._innerTask);
			}

			// Token: 0x04001474 RID: 5236
			private readonly Action<Action, Task> _invokeAction;

			// Token: 0x04001475 RID: 5237
			internal readonly Action _continuation;

			// Token: 0x04001476 RID: 5238
			internal readonly Task _innerTask;
		}
	}
}
