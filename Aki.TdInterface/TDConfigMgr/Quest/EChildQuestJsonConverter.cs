using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200136F RID: 4975
	public class EChildQuestJsonConverter : JsonConverter<EChildQuest>
	{
		// Token: 0x06006FCF RID: 28623 RVA: 0x0010A4BC File Offset: 0x001086BC
		public override EChildQuest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChildQuest.DoInteract;
			}
			return EChildQuestExtensions.FromString(@string);
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x0010A4E0 File Offset: 0x001086E0
		public override void Write(Utf8JsonWriter writer, EChildQuest value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
