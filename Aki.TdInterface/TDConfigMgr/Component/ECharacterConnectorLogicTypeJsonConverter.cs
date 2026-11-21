using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B2 RID: 2482
	public class ECharacterConnectorLogicTypeJsonConverter : JsonConverter<ECharacterConnectorLogicType>
	{
		// Token: 0x060037B5 RID: 14261 RVA: 0x0008D36C File Offset: 0x0008B56C
		public override ECharacterConnectorLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECharacterConnectorLogicType.Range;
			}
			return ECharacterConnectorLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x0008D390 File Offset: 0x0008B590
		public override void Write(Utf8JsonWriter writer, ECharacterConnectorLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
