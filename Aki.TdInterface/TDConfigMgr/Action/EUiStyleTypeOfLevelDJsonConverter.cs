using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002737 RID: 10039
	public class EUiStyleTypeOfLevelDJsonConverter : JsonConverter<EUiStyleTypeOfLevelD>
	{
		// Token: 0x0600D7D3 RID: 55251 RVA: 0x001F88A8 File Offset: 0x001F6AA8
		public override EUiStyleTypeOfLevelD Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUiStyleTypeOfLevelD.GiantSubtitle;
			}
			return EUiStyleTypeOfLevelDExtensions.FromString(@string);
		}

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x001F88CC File Offset: 0x001F6ACC
		public override void Write(Utf8JsonWriter writer, EUiStyleTypeOfLevelD value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
