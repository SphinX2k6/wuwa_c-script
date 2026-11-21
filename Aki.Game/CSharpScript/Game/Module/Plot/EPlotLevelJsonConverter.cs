using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FD5 RID: 16341
	public class EPlotLevelJsonConverter : JsonConverter<EPlotLevel>
	{
		// Token: 0x060295A6 RID: 169382 RVA: 0x00BA4B58 File Offset: 0x00BA2D58
		public override EPlotLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlotLevel.LevelA;
			}
			return EPlotLevelExtensions.FromString(@string);
		}

		// Token: 0x060295A7 RID: 169383 RVA: 0x00BA4B7C File Offset: 0x00BA2D7C
		public override void Write(Utf8JsonWriter writer, EPlotLevel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
