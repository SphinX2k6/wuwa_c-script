using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002705 RID: 9989
	public class ETeamDisplayModeInSkillOpJsonConverter : JsonConverter<ETeamDisplayModeInSkillOp>
	{
		// Token: 0x0600D6F2 RID: 55026 RVA: 0x001F6430 File Offset: 0x001F4630
		public override ETeamDisplayModeInSkillOp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeamDisplayModeInSkillOp.Normal;
			}
			return ETeamDisplayModeInSkillOpExtensions.FromString(@string);
		}

		// Token: 0x0600D6F3 RID: 55027 RVA: 0x001F6454 File Offset: 0x001F4654
		public override void Write(Utf8JsonWriter writer, ETeamDisplayModeInSkillOp value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
