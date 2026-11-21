using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x0200382C RID: 14380
	public class EMoveCheckResultJsonConverter : JsonConverter<EMoveCheckResult>
	{
		// Token: 0x06025583 RID: 152963 RVA: 0x00A85F28 File Offset: 0x00A84128
		public override EMoveCheckResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveCheckResult.None;
			}
			return EMoveCheckResultExtensions.FromString(@string);
		}

		// Token: 0x06025584 RID: 152964 RVA: 0x00A85F4C File Offset: 0x00A8414C
		public override void Write(Utf8JsonWriter writer, EMoveCheckResult value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
