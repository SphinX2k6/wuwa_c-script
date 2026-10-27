using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001263 RID: 4707
	public class EPlayerButtonTypeJsonConverter : JsonConverter<EPlayerButtonType>
	{
		// Token: 0x06006A66 RID: 27238 RVA: 0x000FEFEC File Offset: 0x000FD1EC
		public override EPlayerButtonType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerButtonType.ChallengeAgain;
			}
			return EPlayerButtonTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x000FF010 File Offset: 0x000FD210
		public override void Write(Utf8JsonWriter writer, EPlayerButtonType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
