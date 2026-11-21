using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002647 RID: 9799
	public class EOnlineParticipateRuleJsonConverter : JsonConverter<EOnlineParticipateRule>
	{
		// Token: 0x0600D39B RID: 54171 RVA: 0x001EBE94 File Offset: 0x001EA094
		public override EOnlineParticipateRule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOnlineParticipateRule.AnyPlayer;
			}
			return EOnlineParticipateRuleExtensions.FromString(@string);
		}

		// Token: 0x0600D39C RID: 54172 RVA: 0x001EBEB8 File Offset: 0x001EA0B8
		public override void Write(Utf8JsonWriter writer, EOnlineParticipateRule value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
