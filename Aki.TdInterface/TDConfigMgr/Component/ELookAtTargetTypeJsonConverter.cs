using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4A RID: 2634
	public class ELookAtTargetTypeJsonConverter : JsonConverter<ELookAtTargetType>
	{
		// Token: 0x06003A61 RID: 14945 RVA: 0x00096B88 File Offset: 0x00094D88
		public override ELookAtTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELookAtTargetType.Entity;
			}
			return ELookAtTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x00096BAC File Offset: 0x00094DAC
		public override void Write(Utf8JsonWriter writer, ELookAtTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
