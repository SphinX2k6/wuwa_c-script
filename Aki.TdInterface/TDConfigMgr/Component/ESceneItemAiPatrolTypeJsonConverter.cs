using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC4 RID: 2756
	public class ESceneItemAiPatrolTypeJsonConverter : JsonConverter<ESceneItemAiPatrolType>
	{
		// Token: 0x06003C86 RID: 15494 RVA: 0x0009B358 File Offset: 0x00099558
		public override ESceneItemAiPatrolType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneItemAiPatrolType.ByGameTime;
			}
			return ESceneItemAiPatrolTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0009B37C File Offset: 0x0009957C
		public override void Write(Utf8JsonWriter writer, ESceneItemAiPatrolType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
