using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C1 RID: 5057
	public class ERoleTowerChallengeTitleTypeJsonConverter : JsonConverter<ERoleTowerChallengeTitleType>
	{
		// Token: 0x06007140 RID: 28992 RVA: 0x0010E4A0 File Offset: 0x0010C6A0
		public override ERoleTowerChallengeTitleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleTowerChallengeTitleType.KillProgress;
			}
			return ERoleTowerChallengeTitleTypeExtensions.FromString(@string);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x0010E4C4 File Offset: 0x0010C6C4
		public override void Write(Utf8JsonWriter writer, ERoleTowerChallengeTitleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
