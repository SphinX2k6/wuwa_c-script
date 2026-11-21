using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024F1 RID: 9457
	public class EPlotModeJsonConverter : JsonConverter<EPlotMode>
	{
		// Token: 0x0600CD98 RID: 52632 RVA: 0x001D4350 File Offset: 0x001D2550
		public override EPlotMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlotMode.LevelA;
			}
			return EPlotModeExtensions.FromString(@string);
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x001D4374 File Offset: 0x001D2574
		public override void Write(Utf8JsonWriter writer, EPlotMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
