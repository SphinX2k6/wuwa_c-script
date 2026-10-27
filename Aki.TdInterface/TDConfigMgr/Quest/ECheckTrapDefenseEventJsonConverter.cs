using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001231 RID: 4657
	public class ECheckTrapDefenseEventJsonConverter : JsonConverter<ECheckTrapDefenseEvent>
	{
		// Token: 0x06006985 RID: 27013 RVA: 0x000FB834 File Offset: 0x000F9A34
		public override ECheckTrapDefenseEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECheckTrapDefenseEvent.MonsterKilled;
			}
			return ECheckTrapDefenseEventExtensions.FromString(@string);
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x000FB858 File Offset: 0x000F9A58
		public override void Write(Utf8JsonWriter writer, ECheckTrapDefenseEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
