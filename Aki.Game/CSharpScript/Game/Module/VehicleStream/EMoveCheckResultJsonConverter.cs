using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048B5 RID: 18613
	public class EMoveCheckResultJsonConverter : JsonConverter<EMoveCheckResult>
	{
		// Token: 0x06030A57 RID: 199255 RVA: 0x00B4B120 File Offset: 0x00B49320
		public override EMoveCheckResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveCheckResult.None;
			}
			return EMoveCheckResultExtensions.FromString(@string);
		}

		// Token: 0x06030A58 RID: 199256 RVA: 0x00B4B144 File Offset: 0x00B49344
		public override void Write(Utf8JsonWriter writer, EMoveCheckResult value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
