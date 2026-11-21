using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025CD RID: 9677
	public class EHighlightTypeJsonConverter : JsonConverter<EHighlightType>
	{
		// Token: 0x0600D176 RID: 53622 RVA: 0x001E57F4 File Offset: 0x001E39F4
		public override EHighlightType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHighlightType.CommonWhite;
			}
			return EHighlightTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x001E5818 File Offset: 0x001E3A18
		public override void Write(Utf8JsonWriter writer, EHighlightType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
