using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002721 RID: 10017
	public class ETraceTracingGridTypeJsonConverter : JsonConverter<ETraceTracingGridType>
	{
		// Token: 0x0600D770 RID: 55152 RVA: 0x001F78F0 File Offset: 0x001F5AF0
		public override ETraceTracingGridType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETraceTracingGridType.Block;
			}
			return ETraceTracingGridTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D771 RID: 55153 RVA: 0x001F7914 File Offset: 0x001F5B14
		public override void Write(Utf8JsonWriter writer, ETraceTracingGridType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
