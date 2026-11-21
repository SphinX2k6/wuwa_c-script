using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020003E9 RID: 1001
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ExecutionContext : IDisposable, ISerializable
	{
		// Token: 0x0600400C RID: 16396 RVA: 0x000D5F87 File Offset: 0x000D4187
		private ExecutionContext()
		{
			this.m_isDefault = true;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x000D5F96 File Offset: 0x000D4196
		private ExecutionContext(IAsyncLocalValueMap localValues, IAsyncLocal[] localChangeNotifications, bool isFlowSuppressed)
		{
			this.m_localValues = localValues;
			this.m_localChangeNotifications = localChangeNotifications;
			this.m_isFlowSuppressed = isFlowSuppressed;
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x000D5FB4 File Offset: 0x000D41B4
		[NullableContext(2)]
		public static ExecutionContext Capture()
		{
			ExecutionContext executionContext = Thread.CurrentThread._executionContext;
			if (executionContext == null)
			{
				executionContext = ExecutionContext.Default;
			}
			else if (executionContext.m_isFlowSuppressed)
			{
				executionContext = null;
			}
			return executionContext;
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x000D5FE2 File Offset: 0x000D41E2
		internal static ExecutionContext CaptureForRestore()
		{
			return Thread.CurrentThread._executionContext;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x000D5FF0 File Offset: 0x000D41F0
		private ExecutionContext ShallowClone(bool isFlowSuppressed)
		{
			if (this.m_localValues != null && !AsyncLocalValueMap.IsEmpty(this.m_localValues))
			{
				return new ExecutionContext(this.m_localValues, this.m_localChangeNotifications, isFlowSuppressed);
			}
			if (!isFlowSuppressed)
			{
				return null;
			}
			ExecutionContext result;
			if ((result = ExecutionContext.s_defaultFlowSuppressed) == null)
			{
				result = (ExecutionContext.s_defaultFlowSuppressed = new ExecutionContext(AsyncLocalValueMap.Empty, new IAsyncLocal[0], true));
			}
			return result;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x000D604C File Offset: 0x000D424C
		public static AsyncFlowControl SuppressFlow()
		{
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext = currentThread._executionContext ?? ExecutionContext.Default;
			AsyncFlowControl result = default(AsyncFlowControl);
			if (!executionContext.m_isFlowSuppressed)
			{
				currentThread._executionContext = executionContext.ShallowClone(true);
				result.Initialize(currentThread);
			}
			return result;
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x000D6098 File Offset: 0x000D4298
		public static void RestoreFlow()
		{
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext = currentThread._executionContext;
			if (executionContext == null || !executionContext.m_isFlowSuppressed)
			{
				throw new InvalidOperationException(SR.InvalidOperation_CannotRestoreUnsuppressedFlow);
			}
			currentThread._executionContext = executionContext.ShallowClone(false);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x000D60D4 File Offset: 0x000D42D4
		public static bool IsFlowSuppressed()
		{
			ExecutionContext executionContext = Thread.CurrentThread._executionContext;
			return executionContext != null && executionContext.m_isFlowSuppressed;
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x000D60F7 File Offset: 0x000D42F7
		internal bool HasChangeNotifications
		{
			get
			{
				return this.m_localChangeNotifications != null;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x000D6102 File Offset: 0x000D4302
		internal bool IsDefault
		{
			get
			{
				return this.m_isDefault;
			}
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x000D610A File Offset: 0x000D430A
		public static void Run(ExecutionContext executionContext, ContextCallback callback, [Nullable(2)] object state)
		{
			if (executionContext == null)
			{
				ExecutionContext.ThrowNullContext();
			}
			ExecutionContext.RunInternal(executionContext, callback, state);
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x000D611C File Offset: 0x000D431C
		internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
		{
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext2 = currentThread._executionContext;
			if (executionContext2 != null && executionContext2.m_isDefault)
			{
				executionContext2 = null;
			}
			ExecutionContext executionContext3 = executionContext2;
			SynchronizationContext synchronizationContext = currentThread._synchronizationContext;
			if (executionContext != null && executionContext.m_isDefault)
			{
				executionContext = null;
			}
			if (executionContext3 != executionContext)
			{
				ExecutionContext.RestoreChangedContextToThread(currentThread, executionContext, executionContext3);
			}
			ExceptionDispatchInfo exceptionDispatchInfo = null;
			try
			{
				callback(state);
			}
			catch (Exception source)
			{
				exceptionDispatchInfo = ExceptionDispatchInfo.Capture(source);
			}
			if (currentThread._synchronizationContext != synchronizationContext)
			{
				currentThread._synchronizationContext = synchronizationContext;
			}
			ExecutionContext executionContext4 = currentThread._executionContext;
			if (executionContext4 != executionContext3)
			{
				ExecutionContext.RestoreChangedContextToThread(currentThread, executionContext3, executionContext4);
			}
			if (exceptionDispatchInfo != null)
			{
				exceptionDispatchInfo.Throw();
			}
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x000D61BC File Offset: 0x000D43BC
		public static void Restore(ExecutionContext executionContext)
		{
			if (executionContext == null)
			{
				ExecutionContext.ThrowNullContext();
			}
			ExecutionContext.RestoreInternal(executionContext);
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x000D61CC File Offset: 0x000D43CC
		internal static void RestoreInternal(ExecutionContext executionContext)
		{
			Thread currentThread = Thread.CurrentThread;
			ExecutionContext executionContext2 = currentThread._executionContext;
			if (executionContext2 != null && executionContext2.m_isDefault)
			{
				executionContext2 = null;
			}
			if (executionContext != null && executionContext.m_isDefault)
			{
				executionContext = null;
			}
			if (executionContext2 != executionContext)
			{
				ExecutionContext.RestoreChangedContextToThread(currentThread, executionContext, executionContext2);
			}
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x000D6210 File Offset: 0x000D4410
		internal static void RunFromThreadPoolDispatchLoop(Thread threadPoolThread, ExecutionContext executionContext, ContextCallback callback, object state)
		{
			if (executionContext != null && !executionContext.m_isDefault)
			{
				ExecutionContext.RestoreChangedContextToThread(threadPoolThread, executionContext, null);
			}
			ExceptionDispatchInfo exceptionDispatchInfo = null;
			try
			{
				callback(state);
			}
			catch (Exception source)
			{
				exceptionDispatchInfo = ExceptionDispatchInfo.Capture(source);
			}
			ExecutionContext executionContext2 = threadPoolThread._executionContext;
			threadPoolThread._synchronizationContext = null;
			if (executionContext2 != null)
			{
				ExecutionContext.RestoreChangedContextToThread(threadPoolThread, null, executionContext2);
			}
			if (exceptionDispatchInfo != null)
			{
				exceptionDispatchInfo.Throw();
			}
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x000D6278 File Offset: 0x000D4478
		internal static void RunForThreadPoolUnsafe<TState>(ExecutionContext executionContext, Action<TState> callback, in TState state)
		{
			Thread.CurrentThread._executionContext = executionContext;
			if (executionContext.HasChangeNotifications)
			{
				ExecutionContext.OnValuesChanged(null, executionContext);
			}
			callback(state);
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x000D62A0 File Offset: 0x000D44A0
		internal static void RestoreChangedContextToThread(Thread currentThread, ExecutionContext contextToRestore, ExecutionContext currentContext)
		{
			currentThread._executionContext = contextToRestore;
			if ((currentContext != null && currentContext.HasChangeNotifications) || (contextToRestore != null && contextToRestore.HasChangeNotifications))
			{
				ExecutionContext.OnValuesChanged(currentContext, contextToRestore);
			}
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x000D62C8 File Offset: 0x000D44C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ResetThreadPoolThread(Thread currentThread)
		{
			ExecutionContext executionContext = currentThread._executionContext;
			currentThread._synchronizationContext = null;
			currentThread._executionContext = null;
			if (executionContext != null && executionContext.HasChangeNotifications)
			{
				ExecutionContext.OnValuesChanged(executionContext, null);
				currentThread._synchronizationContext = null;
				currentThread._executionContext = null;
			}
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x000D630C File Offset: 0x000D450C
		internal static void OnValuesChanged(ExecutionContext previousExecutionCtx, ExecutionContext nextExecutionCtx)
		{
			IAsyncLocal[] array = (previousExecutionCtx != null) ? previousExecutionCtx.m_localChangeNotifications : null;
			IAsyncLocal[] array2 = (nextExecutionCtx != null) ? nextExecutionCtx.m_localChangeNotifications : null;
			try
			{
				if (array != null && array2 != null)
				{
					foreach (IAsyncLocal asyncLocal in array)
					{
						object obj;
						previousExecutionCtx.m_localValues.TryGetValue(asyncLocal, out obj);
						object obj2;
						nextExecutionCtx.m_localValues.TryGetValue(asyncLocal, out obj2);
						if (obj != obj2)
						{
							asyncLocal.OnValueChanged(obj, obj2, true);
						}
					}
					if (array2 != array)
					{
						foreach (IAsyncLocal asyncLocal2 in array2)
						{
							object obj3;
							if (!previousExecutionCtx.m_localValues.TryGetValue(asyncLocal2, out obj3))
							{
								object obj4;
								nextExecutionCtx.m_localValues.TryGetValue(asyncLocal2, out obj4);
								if (obj3 != obj4)
								{
									asyncLocal2.OnValueChanged(obj3, obj4, true);
								}
							}
						}
					}
				}
				else if (array != null)
				{
					foreach (IAsyncLocal asyncLocal3 in array)
					{
						object obj5;
						previousExecutionCtx.m_localValues.TryGetValue(asyncLocal3, out obj5);
						if (obj5 != null)
						{
							asyncLocal3.OnValueChanged(obj5, null, true);
						}
					}
				}
				else
				{
					foreach (IAsyncLocal asyncLocal4 in array2)
					{
						object obj6;
						nextExecutionCtx.m_localValues.TryGetValue(asyncLocal4, out obj6);
						if (obj6 != null)
						{
							asyncLocal4.OnValueChanged(null, obj6, true);
						}
					}
				}
			}
			catch (Exception exception)
			{
				Environment.FailFast(SR.ExecutionContext_ExceptionInAsyncLocalNotification, exception);
			}
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x000D6474 File Offset: 0x000D4674
		[DoesNotReturn]
		[StackTraceHidden]
		private static void ThrowNullContext()
		{
			throw new InvalidOperationException(SR.InvalidOperation_NullContext);
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x000D6480 File Offset: 0x000D4680
		internal static object GetLocalValue(IAsyncLocal local)
		{
			ExecutionContext executionContext = Thread.CurrentThread._executionContext;
			if (executionContext == null)
			{
				return null;
			}
			object result;
			executionContext.m_localValues.TryGetValue(local, out result);
			return result;
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x000D64B0 File Offset: 0x000D46B0
		internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications)
		{
			ExecutionContext executionContext = Thread.CurrentThread._executionContext;
			object obj = null;
			bool flag = false;
			if (executionContext != null)
			{
				flag = executionContext.m_localValues.TryGetValue(local, out obj);
			}
			if (obj == newValue)
			{
				return;
			}
			IAsyncLocal[] array = null;
			bool flag2 = false;
			IAsyncLocalValueMap asyncLocalValueMap;
			if (executionContext != null)
			{
				flag2 = executionContext.m_isFlowSuppressed;
				asyncLocalValueMap = executionContext.m_localValues.Set(local, newValue, !needChangeNotifications);
				array = executionContext.m_localChangeNotifications;
			}
			else
			{
				asyncLocalValueMap = AsyncLocalValueMap.Create(local, newValue, !needChangeNotifications);
			}
			if (needChangeNotifications && !flag)
			{
				if (array == null)
				{
					array = new IAsyncLocal[]
					{
						local
					};
				}
				else
				{
					int num = array.Length;
					Array.Resize<IAsyncLocal>(ref array, num + 1);
					array[num] = local;
				}
			}
			Thread.CurrentThread._executionContext = ((!flag2 && AsyncLocalValueMap.IsEmpty(asyncLocalValueMap)) ? null : new ExecutionContext(asyncLocalValueMap, array, flag2));
			if (needChangeNotifications)
			{
				local.OnValueChanged(obj, newValue, false);
			}
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00007B62 File Offset: 0x00005D62
		public ExecutionContext CreateCopy()
		{
			return this;
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void Dispose()
		{
		}

		// Token: 0x04000D5F RID: 3423
		internal static readonly ExecutionContext Default = new ExecutionContext();

		// Token: 0x04000D60 RID: 3424
		private static ExecutionContext s_defaultFlowSuppressed;

		// Token: 0x04000D61 RID: 3425
		private readonly IAsyncLocalValueMap m_localValues;

		// Token: 0x04000D62 RID: 3426
		private readonly IAsyncLocal[] m_localChangeNotifications;

		// Token: 0x04000D63 RID: 3427
		private readonly bool m_isFlowSuppressed;

		// Token: 0x04000D64 RID: 3428
		private readonly bool m_isDefault;
	}
}
