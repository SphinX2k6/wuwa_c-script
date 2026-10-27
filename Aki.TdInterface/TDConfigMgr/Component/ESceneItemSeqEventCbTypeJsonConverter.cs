using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A03 RID: 2563
	public class ESceneItemSeqEventCbTypeJsonConverter : JsonConverter<ESceneItemSeqEventCbType>
	{
		// Token: 0x060038C0 RID: 14528 RVA: 0x00092C58 File Offset: 0x00090E58
		public override ESceneItemSeqEventCbType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneItemSeqEventCbType.ANS;
			}
			return ESceneItemSeqEventCbTypeExtensions.FromString(@string);
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00092C7C File Offset: 0x00090E7C
		public override void Write(Utf8JsonWriter writer, ESceneItemSeqEventCbType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
