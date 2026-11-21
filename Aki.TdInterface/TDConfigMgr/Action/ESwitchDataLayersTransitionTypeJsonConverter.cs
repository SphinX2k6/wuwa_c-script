using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E3 RID: 9955
	public class ESwitchDataLayersTransitionTypeJsonConverter : JsonConverter<ESwitchDataLayersTransitionType>
	{
		// Token: 0x0600D659 RID: 54873 RVA: 0x001F24A0 File Offset: 0x001F06A0
		public override ESwitchDataLayersTransitionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwitchDataLayersTransitionType.Sequence;
			}
			return ESwitchDataLayersTransitionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D65A RID: 54874 RVA: 0x001F24C4 File Offset: 0x001F06C4
		public override void Write(Utf8JsonWriter writer, ESwitchDataLayersTransitionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
