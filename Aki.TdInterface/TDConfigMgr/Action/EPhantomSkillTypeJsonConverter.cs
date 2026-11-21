using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002655 RID: 9813
	public class EPhantomSkillTypeJsonConverter : JsonConverter<EPhantomSkillType>
	{
		// Token: 0x0600D3DA RID: 54234 RVA: 0x001EC6DC File Offset: 0x001EA8DC
		public override EPhantomSkillType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhantomSkillType.ChallengeSuccess;
			}
			return EPhantomSkillTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3DB RID: 54235 RVA: 0x001EC700 File Offset: 0x001EA900
		public override void Write(Utf8JsonWriter writer, EPhantomSkillType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
