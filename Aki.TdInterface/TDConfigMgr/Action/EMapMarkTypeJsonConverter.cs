using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002380 RID: 9088
	public class EMapMarkTypeJsonConverter : JsonConverter<EMapMarkType>
	{
		// Token: 0x0600C640 RID: 50752 RVA: 0x001D0A7C File Offset: 0x001CEC7C
		public override EMapMarkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMapMarkType.Custom;
			}
			return EMapMarkTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C641 RID: 50753 RVA: 0x001D0AA0 File Offset: 0x001CECA0
		public override void Write(Utf8JsonWriter writer, EMapMarkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
