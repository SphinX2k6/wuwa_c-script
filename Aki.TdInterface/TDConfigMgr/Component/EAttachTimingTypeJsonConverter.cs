using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F7 RID: 2295
	public class EAttachTimingTypeJsonConverter : JsonConverter<EAttachTimingType>
	{
		// Token: 0x0600340A RID: 13322 RVA: 0x00085020 File Offset: 0x00083220
		public override EAttachTimingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachTimingType.Default;
			}
			return EAttachTimingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00085044 File Offset: 0x00083244
		public override void Write(Utf8JsonWriter writer, EAttachTimingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
