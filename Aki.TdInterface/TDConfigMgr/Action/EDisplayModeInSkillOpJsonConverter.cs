using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002575 RID: 9589
	public class EDisplayModeInSkillOpJsonConverter : JsonConverter<EDisplayModeInSkillOp>
	{
		// Token: 0x0600CFEA RID: 53226 RVA: 0x001E210C File Offset: 0x001E030C
		public override EDisplayModeInSkillOp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDisplayModeInSkillOp.Ashen;
			}
			return EDisplayModeInSkillOpExtensions.FromString(@string);
		}

		// Token: 0x0600CFEB RID: 53227 RVA: 0x001E2130 File Offset: 0x001E0330
		public override void Write(Utf8JsonWriter writer, EDisplayModeInSkillOp value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
