using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123D RID: 4669
	public class EEnableSystemTypeJsonConverter : JsonConverter<EEnableSystemType>
	{
		// Token: 0x060069BB RID: 27067 RVA: 0x000FD620 File Offset: 0x000FB820
		public override EEnableSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableSystemType.GradingSystem;
			}
			return EEnableSystemTypeExtensions.FromString(@string);
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x000FD644 File Offset: 0x000FB844
		public override void Write(Utf8JsonWriter writer, EEnableSystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
