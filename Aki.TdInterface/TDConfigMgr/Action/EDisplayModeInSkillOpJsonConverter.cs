using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002306 RID: 8966
	public class EDisplayModeInSkillOpJsonConverter : JsonConverter<EDisplayModeInSkillOp>
	{
		// Token: 0x0600C41B RID: 50203 RVA: 0x001CA244 File Offset: 0x001C8444
		public override EDisplayModeInSkillOp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDisplayModeInSkillOp.Ashen;
			}
			return EDisplayModeInSkillOpExtensions.FromString(@string);
		}

		// Token: 0x0600C41C RID: 50204 RVA: 0x001CA268 File Offset: 0x001C8468
		public override void Write(Utf8JsonWriter writer, EDisplayModeInSkillOp value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
