using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001281 RID: 4737
	public class ERoleTowerChallengeTitleTypeJsonConverter : JsonConverter<ERoleTowerChallengeTitleType>
	{
		// Token: 0x06006AED RID: 27373 RVA: 0x00100874 File Offset: 0x000FEA74
		public override ERoleTowerChallengeTitleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleTowerChallengeTitleType.KillProgress;
			}
			return ERoleTowerChallengeTitleTypeExtensions.FromString(@string);
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x00100898 File Offset: 0x000FEA98
		public override void Write(Utf8JsonWriter writer, ERoleTowerChallengeTitleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
