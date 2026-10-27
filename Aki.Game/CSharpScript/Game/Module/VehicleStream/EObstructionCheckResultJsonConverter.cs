using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048B3 RID: 18611
	public class EObstructionCheckResultJsonConverter : JsonConverter<EObstructionCheckResult>
	{
		// Token: 0x06030A4E RID: 199246 RVA: 0x00B4ADD0 File Offset: 0x00B48FD0
		public override EObstructionCheckResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EObstructionCheckResult.None;
			}
			return EObstructionCheckResultExtensions.FromString(@string);
		}

		// Token: 0x06030A4F RID: 199247 RVA: 0x00B4ADF4 File Offset: 0x00B48FF4
		public override void Write(Utf8JsonWriter writer, EObstructionCheckResult value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
