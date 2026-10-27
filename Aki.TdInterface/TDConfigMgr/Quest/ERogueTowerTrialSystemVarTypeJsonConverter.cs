using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127F RID: 4735
	public class ERogueTowerTrialSystemVarTypeJsonConverter : JsonConverter<ERogueTowerTrialSystemVarType>
	{
		// Token: 0x06006AE4 RID: 27364 RVA: 0x0010071C File Offset: 0x000FE91C
		public override ERogueTowerTrialSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueTowerTrialSystemVarType.KillBoss1;
			}
			return ERogueTowerTrialSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x00100740 File Offset: 0x000FE940
		public override void Write(Utf8JsonWriter writer, ERogueTowerTrialSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
