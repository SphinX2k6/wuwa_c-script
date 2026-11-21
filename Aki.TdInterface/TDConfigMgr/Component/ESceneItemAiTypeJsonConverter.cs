using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC6 RID: 2758
	public class ESceneItemAiTypeJsonConverter : JsonConverter<ESceneItemAiType>
	{
		// Token: 0x06003C8F RID: 15503 RVA: 0x0009B434 File Offset: 0x00099634
		public override ESceneItemAiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneItemAiType.SceneItemPatrol;
			}
			return ESceneItemAiTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x0009B458 File Offset: 0x00099658
		public override void Write(Utf8JsonWriter writer, ESceneItemAiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
