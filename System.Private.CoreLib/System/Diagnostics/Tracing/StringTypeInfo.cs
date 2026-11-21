using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200094B RID: 2379
	internal sealed class StringTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E53 RID: 36435 RVA: 0x0015F17D File Offset: 0x0015D37D
		public StringTypeInfo() : base(typeof(string))
		{
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x0015F18F File Offset: 0x0015D38F
		public static TraceLoggingTypeInfo Instance()
		{
			StringTypeInfo result;
			if ((result = StringTypeInfo.s_instance) == null)
			{
				result = (StringTypeInfo.s_instance = new StringTypeInfo());
			}
			return result;
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x0015F1A5 File Offset: 0x0015D3A5
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			if (name == null)
			{
				name = "message";
			}
			collector.AddNullTerminatedString(name, Statics.MakeDataType(TraceLoggingDataType.Utf16String, format));
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x0015F1BF File Offset: 0x0015D3BF
		public override void WriteData(PropertyValue value)
		{
			TraceLoggingDataCollector.AddNullTerminatedString((string)value.ReferenceValue);
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x0015F1D2 File Offset: 0x0015D3D2
		public override object GetData(object value)
		{
			if (value == null)
			{
				return "";
			}
			return value;
		}

		// Token: 0x04002173 RID: 8563
		private static StringTypeInfo s_instance;
	}
}
