using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002442 RID: 9282
	public class ESwitchDataLayersTransitionTypeJsonConverter : JsonConverter<ESwitchDataLayersTransitionType>
	{
		// Token: 0x0600C9A9 RID: 51625 RVA: 0x001D85D8 File Offset: 0x001D67D8
		public override ESwitchDataLayersTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwitchDataLayersTransitionType.Sequence;
			}
			return ESwitchDataLayersTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9AA RID: 51626 RVA: 0x001D85FC File Offset: 0x001D67FC
		public override void Write(Utf8JsonWriter writer, ESwitchDataLayersTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
