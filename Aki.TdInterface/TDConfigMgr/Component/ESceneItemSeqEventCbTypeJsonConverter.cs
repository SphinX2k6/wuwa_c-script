using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC8 RID: 2760
	public class ESceneItemSeqEventCbTypeJsonConverter : JsonConverter<ESceneItemSeqEventCbType>
	{
		// Token: 0x06003C98 RID: 15512 RVA: 0x0009B548 File Offset: 0x00099748
		public override ESceneItemSeqEventCbType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneItemSeqEventCbType.ANS;
			}
			return ESceneItemSeqEventCbTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x0009B56C File Offset: 0x0009976C
		public override void Write(Utf8JsonWriter writer, ESceneItemSeqEventCbType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
