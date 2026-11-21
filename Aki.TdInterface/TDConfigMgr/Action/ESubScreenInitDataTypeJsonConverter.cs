using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D5 RID: 9941
	public class ESubScreenInitDataTypeJsonConverter : JsonConverter<ESubScreenInitDataType>
	{
		// Token: 0x0600D61A RID: 54810 RVA: 0x001F1CCC File Offset: 0x001EFECC
		public override ESubScreenInitDataType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenInitDataType.Preset;
			}
			return ESubScreenInitDataTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x001F1CF0 File Offset: 0x001EFEF0
		public override void Write(Utf8JsonWriter writer, ESubScreenInitDataType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
