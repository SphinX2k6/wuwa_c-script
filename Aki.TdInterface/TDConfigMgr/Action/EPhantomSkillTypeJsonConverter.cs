using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C0 RID: 9152
	public class EPhantomSkillTypeJsonConverter : JsonConverter<EPhantomSkillType>
	{
		// Token: 0x0600C760 RID: 51040 RVA: 0x001D3044 File Offset: 0x001D1244
		public override EPhantomSkillType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhantomSkillType.ChallengeSuccess;
			}
			return EPhantomSkillTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C761 RID: 51041 RVA: 0x001D3068 File Offset: 0x001D1268
		public override void Write(Utf8JsonWriter writer, EPhantomSkillType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
