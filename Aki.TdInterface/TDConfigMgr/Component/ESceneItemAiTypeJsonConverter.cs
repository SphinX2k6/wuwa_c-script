using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A01 RID: 2561
	public class ESceneItemAiTypeJsonConverter : JsonConverter<ESceneItemAiType>
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x00092B44 File Offset: 0x00090D44
		public override ESceneItemAiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneItemAiType.SceneItemPatrol;
			}
			return ESceneItemAiTypeExtensions.FromString(@string);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00092B68 File Offset: 0x00090D68
		public override void Write(Utf8JsonWriter writer, ESceneItemAiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
