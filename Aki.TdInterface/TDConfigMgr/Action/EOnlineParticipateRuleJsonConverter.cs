using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B6 RID: 9142
	public class EOnlineParticipateRuleJsonConverter : JsonConverter<EOnlineParticipateRule>
	{
		// Token: 0x0600C733 RID: 50995 RVA: 0x001D2A60 File Offset: 0x001D0C60
		public override EOnlineParticipateRule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOnlineParticipateRule.AnyPlayer;
			}
			return EOnlineParticipateRuleExtensions.FromString(@string);
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x001D2A84 File Offset: 0x001D0C84
		public override void Write(Utf8JsonWriter writer, EOnlineParticipateRule value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
