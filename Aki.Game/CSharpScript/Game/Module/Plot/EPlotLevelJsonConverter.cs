using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x0200500B RID: 20491
	public class EPlotLevelJsonConverter : JsonConverter<EPlotLevel>
	{
		// Token: 0x06034703 RID: 214787 RVA: 0x00C59658 File Offset: 0x00C57858
		public override EPlotLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlotLevel.LevelA;
			}
			return EPlotLevelExtensions.FromString(@string);
		}

		// Token: 0x06034704 RID: 214788 RVA: 0x00C5967C File Offset: 0x00C5787C
		public override void Write(Utf8JsonWriter writer, EPlotLevel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
