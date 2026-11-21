using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200136D RID: 4973
	public class ECheckTrapDefenseEventJsonConverter : JsonConverter<ECheckTrapDefenseEvent>
	{
		// Token: 0x06006FC6 RID: 28614 RVA: 0x00109140 File Offset: 0x00107340
		public override ECheckTrapDefenseEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECheckTrapDefenseEvent.MonsterKilled;
			}
			return ECheckTrapDefenseEventExtensions.FromString(@string);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00109164 File Offset: 0x00107364
		public override void Write(Utf8JsonWriter writer, ECheckTrapDefenseEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
