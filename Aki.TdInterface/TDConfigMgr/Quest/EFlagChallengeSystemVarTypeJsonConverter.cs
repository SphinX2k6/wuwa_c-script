using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001381 RID: 4993
	public class EFlagChallengeSystemVarTypeJsonConverter : JsonConverter<EFlagChallengeSystemVarType>
	{
		// Token: 0x06007020 RID: 28704 RVA: 0x0010B43C File Offset: 0x0010963C
		public override EFlagChallengeSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlagChallengeSystemVarType.IsCompleted;
			}
			return EFlagChallengeSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x0010B460 File Offset: 0x00109660
		public override void Write(Utf8JsonWriter writer, EFlagChallengeSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
