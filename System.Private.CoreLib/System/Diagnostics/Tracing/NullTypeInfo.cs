using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000948 RID: 2376
	internal sealed class NullTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008E2A RID: 36394 RVA: 0x0015ECC0 File Offset: 0x0015CEC0
		public NullTypeInfo() : base(typeof(EmptyStruct))
		{
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x0015ECD2 File Offset: 0x0015CED2
		public static TraceLoggingTypeInfo Instance()
		{
			NullTypeInfo result;
			if ((result = NullTypeInfo.s_instance) == null)
			{
				result = (NullTypeInfo.s_instance = new NullTypeInfo());
			}
			return result;
		}

		// Token: 0x06008E2C RID: 36396 RVA: 0x0015ECE8 File Offset: 0x0015CEE8
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.AddGroup(name);
		}

		// Token: 0x06008E2D RID: 36397 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public override void WriteData(PropertyValue value)
		{
		}

		// Token: 0x06008E2E RID: 36398 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override object GetData(object value)
		{
			return null;
		}

		// Token: 0x04002151 RID: 8529
		private static NullTypeInfo s_instance;
	}
}
