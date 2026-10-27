using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247E RID: 9342
	public class ETraceTracingGridTypeJsonConverter : JsonConverter<ETraceTracingGridType>
	{
		// Token: 0x0600CAB7 RID: 51895 RVA: 0x001DD728 File Offset: 0x001DB928
		public override ETraceTracingGridType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETraceTracingGridType.Block;
			}
			return ETraceTracingGridTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x001DD74C File Offset: 0x001DB94C
		public override void Write(Utf8JsonWriter writer, ETraceTracingGridType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
