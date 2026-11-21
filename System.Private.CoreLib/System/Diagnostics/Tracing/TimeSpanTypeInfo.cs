using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200094E RID: 2382
	internal sealed class TimeSpanTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E60 RID: 36448 RVA: 0x0015F2FE File Offset: 0x0015D4FE
		public TimeSpanTypeInfo() : base(typeof(TimeSpan))
		{
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x0015F310 File Offset: 0x0015D510
		public static TraceLoggingTypeInfo Instance()
		{
			TimeSpanTypeInfo result;
			if ((result = TimeSpanTypeInfo.s_instance) == null)
			{
				result = (TimeSpanTypeInfo.s_instance = new TimeSpanTypeInfo());
			}
			return result;
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x0015F326 File Offset: 0x0015D526
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.AddScalar(name, Statics.MakeDataType(TraceLoggingDataType.Int64, format));
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x0015F338 File Offset: 0x0015D538
		public override void WriteData(PropertyValue value)
		{
			TraceLoggingDataCollector.AddScalar(value.ScalarValue.AsTimeSpan.Ticks);
		}

		// Token: 0x04002176 RID: 8566
		private static TimeSpanTypeInfo s_instance;
	}
}
