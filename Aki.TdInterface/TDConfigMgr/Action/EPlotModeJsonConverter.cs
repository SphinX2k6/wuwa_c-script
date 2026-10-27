using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002284 RID: 8836
	public class EPlotModeJsonConverter : JsonConverter<EPlotMode>
	{
		// Token: 0x0600C1D2 RID: 49618 RVA: 0x001BCBCC File Offset: 0x001BADCC
		public override EPlotMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlotMode.LevelA;
			}
			return EPlotModeExtensions.FromString(@string);
		}

		// Token: 0x0600C1D3 RID: 49619 RVA: 0x001BCBF0 File Offset: 0x001BADF0
		public override void Write(Utf8JsonWriter writer, EPlotMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
