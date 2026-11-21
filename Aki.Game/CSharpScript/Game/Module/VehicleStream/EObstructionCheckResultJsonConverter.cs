using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x0200382A RID: 14378
	public class EObstructionCheckResultJsonConverter : JsonConverter<EObstructionCheckResult>
	{
		// Token: 0x0602557A RID: 152954 RVA: 0x00A85BD8 File Offset: 0x00A83DD8
		public override EObstructionCheckResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EObstructionCheckResult.None;
			}
			return EObstructionCheckResultExtensions.FromString(@string);
		}

		// Token: 0x0602557B RID: 152955 RVA: 0x00A85BFC File Offset: 0x00A83DFC
		public override void Write(Utf8JsonWriter writer, EObstructionCheckResult value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
