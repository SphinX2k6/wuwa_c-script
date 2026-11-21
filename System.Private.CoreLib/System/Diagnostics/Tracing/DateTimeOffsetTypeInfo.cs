using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200094D RID: 2381
	internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E5C RID: 36444 RVA: 0x0015F255 File Offset: 0x0015D455
		public DateTimeOffsetTypeInfo() : base(typeof(DateTimeOffset))
		{
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x0015F267 File Offset: 0x0015D467
		public static TraceLoggingTypeInfo Instance()
		{
			DateTimeOffsetTypeInfo result;
			if ((result = DateTimeOffsetTypeInfo.s_instance) == null)
			{
				result = (DateTimeOffsetTypeInfo.s_instance = new DateTimeOffsetTypeInfo());
			}
			return result;
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x0015F27D File Offset: 0x0015D47D
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			TraceLoggingMetadataCollector traceLoggingMetadataCollector = collector.AddGroup(name);
			traceLoggingMetadataCollector.AddScalar("Ticks", Statics.MakeDataType(TraceLoggingDataType.FileTime, format));
			traceLoggingMetadataCollector.AddScalar("Offset", TraceLoggingDataType.Int64);
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x0015F2A8 File Offset: 0x0015D4A8
		public override void WriteData(PropertyValue value)
		{
			DateTimeOffset asDateTimeOffset = value.ScalarValue.AsDateTimeOffset;
			long ticks = asDateTimeOffset.Ticks;
			TraceLoggingDataCollector.AddScalar((ticks < 504911232000000000L) ? 0L : (ticks - 504911232000000000L));
			TraceLoggingDataCollector.AddScalar(asDateTimeOffset.Offset.Ticks);
		}

		// Token: 0x04002175 RID: 8565
		private static DateTimeOffsetTypeInfo s_instance;
	}
}
