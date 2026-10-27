using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002464 RID: 9316
	public class ETeamDisplayModeInSkillOpJsonConverter : JsonConverter<ETeamDisplayModeInSkillOp>
	{
		// Token: 0x0600CA42 RID: 51778 RVA: 0x001DC37C File Offset: 0x001DA57C
		public override ETeamDisplayModeInSkillOp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeamDisplayModeInSkillOp.Normal;
			}
			return ETeamDisplayModeInSkillOpExtensions.FromString(@string);
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x001DC3A0 File Offset: 0x001DA5A0
		public override void Write(Utf8JsonWriter writer, ETeamDisplayModeInSkillOp value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
