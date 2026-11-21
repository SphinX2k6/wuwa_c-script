using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC2 RID: 2754
	public class ERotationTypeJsonConverter : JsonConverter<ERotationType>
	{
		// Token: 0x06003C7D RID: 15485 RVA: 0x0009B27C File Offset: 0x0009947C
		public override ERotationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERotationType.Relative;
			}
			return ERotationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0009B2A0 File Offset: 0x000994A0
		public override void Write(Utf8JsonWriter writer, ERotationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
