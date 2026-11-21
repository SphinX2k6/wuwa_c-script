using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000947 RID: 2375
	internal static class SimpleEventTypes<T>
	{
		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x0015EC5C File Offset: 0x0015CE5C
		public static TraceLoggingEventTypes Instance
		{
			[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
			get
			{
				TraceLoggingEventTypes result;
				if ((result = SimpleEventTypes<T>.instance) == null)
				{
					result = (SimpleEventTypes<T>.instance = SimpleEventTypes<T>.InitInstance());
				}
				return result;
			}
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x0015EC74 File Offset: 0x0015CE74
		[RequiresUnreferencedCode("EventSource WriteEvent will serialize the whole object graph. Trimmer will not safely handle this case because properties may be trimmed. This can be suppressed if the object is a primitive type")]
		private static TraceLoggingEventTypes InitInstance()
		{
			TraceLoggingTypeInfo traceLoggingTypeInfo = TraceLoggingTypeInfo.GetInstance(typeof(T), null);
			TraceLoggingEventTypes value = new TraceLoggingEventTypes(traceLoggingTypeInfo.Name, traceLoggingTypeInfo.Tags, new TraceLoggingTypeInfo[]
			{
				traceLoggingTypeInfo
			});
			Interlocked.CompareExchange<TraceLoggingEventTypes>(ref SimpleEventTypes<T>.instance, value, null);
			return SimpleEventTypes<T>.instance;
		}

		// Token: 0x04002150 RID: 8528
		private static TraceLoggingEventTypes instance;
	}
}
