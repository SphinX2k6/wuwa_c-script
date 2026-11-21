using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000929 RID: 2345
	internal sealed class InvokeTypeInfo : TraceLoggingTypeInfo
	{
		// Token: 0x06008DB8 RID: 36280 RVA: 0x0015D884 File Offset: 0x0015BA84
		public InvokeTypeInfo(Type type, TypeAnalysis typeAnalysis) : base(type, typeAnalysis.name, typeAnalysis.level, typeAnalysis.opcode, typeAnalysis.keywords, typeAnalysis.tags)
		{
			if (typeAnalysis.properties.Length != 0)
			{
				this.properties = typeAnalysis.properties;
			}
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x0015D8C0 File Offset: 0x0015BAC0
		public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format)
		{
			TraceLoggingMetadataCollector traceLoggingMetadataCollector = collector.AddGroup(name);
			if (this.properties != null)
			{
				foreach (PropertyAnalysis propertyAnalysis in this.properties)
				{
					EventFieldFormat format2 = EventFieldFormat.Default;
					EventFieldAttribute fieldAttribute = propertyAnalysis.fieldAttribute;
					if (fieldAttribute != null)
					{
						traceLoggingMetadataCollector.Tags = fieldAttribute.Tags;
						format2 = fieldAttribute.Format;
					}
					propertyAnalysis.typeInfo.WriteMetadata(traceLoggingMetadataCollector, propertyAnalysis.name, format2);
				}
			}
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x0015D930 File Offset: 0x0015BB30
		public override void WriteData(PropertyValue value)
		{
			if (this.properties != null)
			{
				foreach (PropertyAnalysis propertyAnalysis in this.properties)
				{
					propertyAnalysis.typeInfo.WriteData(propertyAnalysis.getter(value));
				}
			}
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x0015D978 File Offset: 0x0015BB78
		public override object GetData(object value)
		{
			if (this.properties != null)
			{
				string[] array = new string[this.properties.Length];
				object[] array2 = new object[this.properties.Length];
				for (int i = 0; i < this.properties.Length; i++)
				{
					object value2 = this.properties[i].propertyInfo.GetValue(value);
					array[i] = this.properties[i].name;
					array2[i] = this.properties[i].typeInfo.GetData(value2);
				}
				return new EventPayload(array, array2);
			}
			return null;
		}

		// Token: 0x04002103 RID: 8451
		internal readonly PropertyAnalysis[] properties;
	}
}
