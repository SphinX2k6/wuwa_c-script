using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200094C RID: 2380
	internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E58 RID: 36440 RVA: 0x0015F1DE File Offset: 0x0015D3DE
		public DateTimeTypeInfo() : base(typeof(DateTime))
		{
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x0015F1F0 File Offset: 0x0015D3F0
		public static TraceLoggingTypeInfo Instance()
		{
			DateTimeTypeInfo result;
			if ((result = DateTimeTypeInfo.s_instance) == null)
			{
				result = (DateTimeTypeInfo.s_instance = new DateTimeTypeInfo());
			}
			return result;
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x0015F206 File Offset: 0x0015D406
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.AddScalar(name, Statics.MakeDataType(TraceLoggingDataType.FileTime, format));
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x0015F218 File Offset: 0x0015D418
		public override void WriteData(PropertyValue value)
		{
			DateTime asDateTime = value.ScalarValue.AsDateTime;
			long value2 = 0L;
			if (asDateTime.Ticks > 504911232000000000L)
			{
				value2 = asDateTime.ToFileTimeUtc();
			}
			TraceLoggingDataCollector.AddScalar(value2);
		}

		// Token: 0x04002174 RID: 8564
		private static DateTimeTypeInfo s_instance;
	}
}
