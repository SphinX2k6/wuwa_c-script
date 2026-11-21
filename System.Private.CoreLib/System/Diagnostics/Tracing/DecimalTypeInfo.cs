using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200094F RID: 2383
	internal sealed class DecimalTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E64 RID: 36452 RVA: 0x0015F35E File Offset: 0x0015D55E
		public DecimalTypeInfo() : base(typeof(decimal))
		{
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x0015F370 File Offset: 0x0015D570
		public static TraceLoggingTypeInfo Instance()
		{
			DecimalTypeInfo result;
			if ((result = DecimalTypeInfo.s_instance) == null)
			{
				result = (DecimalTypeInfo.s_instance = new DecimalTypeInfo());
			}
			return result;
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x0015F386 File Offset: 0x0015D586
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.AddScalar(name, Statics.MakeDataType(TraceLoggingDataType.Double, format));
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x0015F397 File Offset: 0x0015D597
		public override void WriteData(PropertyValue value)
		{
			TraceLoggingDataCollector.AddScalar((double)value.ScalarValue.AsDecimal);
		}

		// Token: 0x04002177 RID: 8567
		private static DecimalTypeInfo s_instance;
	}
}
