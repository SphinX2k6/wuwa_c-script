using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DA RID: 9178
	public class EPlotModeUiStyleTypeJsonConverter : JsonConverter<EPlotModeUiStyleType>
	{
		// Token: 0x0600C7D5 RID: 51157 RVA: 0x001D4090 File Offset: 0x001D2290
		public override EPlotModeUiStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlotModeUiStyleType.LevelD;
			}
			return EPlotModeUiStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x001D40B4 File Offset: 0x001D22B4
		public override void Write(Utf8JsonWriter writer, EPlotModeUiStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
