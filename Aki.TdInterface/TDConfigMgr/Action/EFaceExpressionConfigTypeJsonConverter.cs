using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A1 RID: 9633
	public class EFaceExpressionConfigTypeJsonConverter : JsonConverter<EFaceExpressionConfigType>
	{
		// Token: 0x0600D0B0 RID: 53424 RVA: 0x001E3E14 File Offset: 0x001E2014
		public override EFaceExpressionConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFaceExpressionConfigType.Morph;
			}
			return EFaceExpressionConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x001E3E38 File Offset: 0x001E2038
		public override void Write(Utf8JsonWriter writer, EFaceExpressionConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
