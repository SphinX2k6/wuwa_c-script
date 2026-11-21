using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200091A RID: 2330
	internal sealed class ArrayTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008D65 RID: 36197 RVA: 0x0015CBC7 File Offset: 0x0015ADC7
		public ArrayTypeInfo(Type type, TraceLoggingTypeInfo elementInfo) : base(type)
		{
			this.elementInfo = elementInfo;
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0015CBD7 File Offset: 0x0015ADD7
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.BeginBufferedArray();
			this.elementInfo.WriteMetadata(collector, name, format);
			collector.EndBufferedArray();
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x0015CBF4 File Offset: 0x0015ADF4
		public override void WriteData(PropertyValue value)
		{
			int bookmark = TraceLoggingDataCollector.BeginBufferedArray();
			int count = 0;
			Array array = (Array)value.ReferenceValue;
			if (array != null)
			{
				count = array.Length;
				for (int i = 0; i < array.Length; i++)
				{
					this.elementInfo.WriteData(this.elementInfo.PropertyValueFactory(array.GetValue(i)));
				}
			}
			TraceLoggingDataCollector.EndBufferedArray(bookmark, count);
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x0015CC5C File Offset: 0x0015AE5C
		public override object GetData(object value)
		{
			Array array = (Array)value;
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = this.elementInfo.GetData(array.GetValue(i));
			}
			return array2;
		}

		// Token: 0x040020CF RID: 8399
		private readonly TraceLoggingTypeInfo elementInfo;
	}
}
