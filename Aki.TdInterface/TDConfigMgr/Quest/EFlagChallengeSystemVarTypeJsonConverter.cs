using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001241 RID: 4673
	public class EFlagChallengeSystemVarTypeJsonConverter : JsonConverter<EFlagChallengeSystemVarType>
	{
		// Token: 0x060069CD RID: 27085 RVA: 0x000FD810 File Offset: 0x000FBA10
		public override EFlagChallengeSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlagChallengeSystemVarType.IsCompleted;
			}
			return EFlagChallengeSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x000FD834 File Offset: 0x000FBA34
		public override void Write(Utf8JsonWriter writer, EFlagChallengeSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
