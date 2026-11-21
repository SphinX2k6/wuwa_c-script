using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002671 RID: 9841
	public class EPlotModeUiStyleTypeJsonConverter : JsonConverter<EPlotModeUiStyleType>
	{
		// Token: 0x0600D458 RID: 54360 RVA: 0x001ED83C File Offset: 0x001EBA3C
		public override EPlotModeUiStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlotModeUiStyleType.LevelD;
			}
			return EPlotModeUiStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x001ED860 File Offset: 0x001EBA60
		public override void Write(Utf8JsonWriter writer, EPlotModeUiStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
