using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FF RID: 2559
	public class ESceneItemAiPatrolTypeJsonConverter : JsonConverter<ESceneItemAiPatrolType>
	{
		// Token: 0x060038AE RID: 14510 RVA: 0x00092A68 File Offset: 0x00090C68
		public override ESceneItemAiPatrolType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneItemAiPatrolType.ByGameTime;
			}
			return ESceneItemAiPatrolTypeExtensions.FromString(@string);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00092A8C File Offset: 0x00090C8C
		public override void Write(Utf8JsonWriter writer, ESceneItemAiPatrolType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
