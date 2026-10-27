using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001291 RID: 4753
	public class ESpecialGamePlayConfigTypeJsonConverter : JsonConverter<ESpecialGamePlayConfigType>
	{
		// Token: 0x06006B35 RID: 27445 RVA: 0x001015BC File Offset: 0x000FF7BC
		public override ESpecialGamePlayConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialGamePlayConfigType.Stalking;
			}
			return ESpecialGamePlayConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x001015E0 File Offset: 0x000FF7E0
		public override void Write(Utf8JsonWriter writer, ESpecialGamePlayConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
