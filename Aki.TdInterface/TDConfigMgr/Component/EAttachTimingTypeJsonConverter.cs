using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A0 RID: 2464
	public class EAttachTimingTypeJsonConverter : JsonConverter<EAttachTimingType>
	{
		// Token: 0x06003764 RID: 14180 RVA: 0x0008C890 File Offset: 0x0008AA90
		public override EAttachTimingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachTimingType.Default;
			}
			return EAttachTimingTypeExtensions.FromString(@string);
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x0008C8B4 File Offset: 0x0008AAB4
		public override void Write(Utf8JsonWriter writer, EAttachTimingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
