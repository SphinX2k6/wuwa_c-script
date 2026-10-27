using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001233 RID: 4659
	public class EChildQuestJsonConverter : JsonConverter<EChildQuest>
	{
		// Token: 0x0600698E RID: 27022 RVA: 0x000FCBB0 File Offset: 0x000FADB0
		public override EChildQuest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChildQuest.DoInteract;
			}
			return EChildQuestExtensions.FromString(@string);
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x000FCBD4 File Offset: 0x000FADD4
		public override void Write(Utf8JsonWriter writer, EChildQuest value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
