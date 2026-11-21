using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013BF RID: 5055
	public class ERogueTowerTrialSystemVarTypeJsonConverter : JsonConverter<ERogueTowerTrialSystemVarType>
	{
		// Token: 0x06007137 RID: 28983 RVA: 0x0010E348 File Offset: 0x0010C548
		public override ERogueTowerTrialSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueTowerTrialSystemVarType.KillBoss1;
			}
			return ERogueTowerTrialSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x0010E36C File Offset: 0x0010C56C
		public override void Write(Utf8JsonWriter writer, ERogueTowerTrialSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
