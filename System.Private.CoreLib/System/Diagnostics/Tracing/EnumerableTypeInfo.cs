using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200091F RID: 2335
	internal sealed class EnumerableTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008D7E RID: 36222 RVA: 0x0015D215 File Offset: 0x0015B415
		public EnumerableTypeInfo(Type type, TraceLoggingTypeInfo elementInfo) : base(type)
		{
			this.elementInfo = elementInfo;
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06008D7F RID: 36223 RVA: 0x0015D225 File Offset: 0x0015B425
		internal TraceLoggingTypeInfo ElementInfo
		{
			get
			{
				return this.elementInfo;
			}
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0015D22D File Offset: 0x0015B42D
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			collector.BeginBufferedArray();
			this.elementInfo.WriteMetadata(collector, name, format);
			collector.EndBufferedArray();
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x0015D24C File Offset: 0x0015B44C
		public override void WriteData(PropertyValue value)
		{
			int bookmark = TraceLoggingDataCollector.BeginBufferedArray();
			int num = 0;
			IEnumerable enumerable = (IEnumerable)value.ReferenceValue;
			if (enumerable != null)
			{
				foreach (object arg in enumerable)
				{
					this.elementInfo.WriteData(this.elementInfo.PropertyValueFactory(arg));
					num++;
				}
			}
			TraceLoggingDataCollector.EndBufferedArray(bookmark, num);
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x0015D2D8 File Offset: 0x0015B4D8
		public override object GetData(object value)
		{
			IEnumerable enumerable = (IEnumerable)value;
			List<object> list = new List<object>();
			foreach (object value2 in enumerable)
			{
				list.Add(this.elementInfo.GetData(value2));
			}
			return list.ToArray();
		}

		// Token: 0x040020DD RID: 8413
		private readonly TraceLoggingTypeInfo elementInfo;
	}
}
