using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002494 RID: 9364
	public class EUiStyleTypeOfLevelDJsonConverter : JsonConverter<EUiStyleTypeOfLevelD>
	{
		// Token: 0x0600CB1A RID: 51994 RVA: 0x001DE6E0 File Offset: 0x001DC8E0
		public override EUiStyleTypeOfLevelD Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUiStyleTypeOfLevelD.GiantSubtitle;
			}
			return EUiStyleTypeOfLevelDExtensions.FromString(@string);
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x001DE704 File Offset: 0x001DC904
		public override void Write(Utf8JsonWriter writer, EUiStyleTypeOfLevelD value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
