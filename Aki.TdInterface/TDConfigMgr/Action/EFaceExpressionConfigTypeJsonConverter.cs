using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002330 RID: 9008
	public class EFaceExpressionConfigTypeJsonConverter : JsonConverter<EFaceExpressionConfigType>
	{
		// Token: 0x0600C4D8 RID: 50392 RVA: 0x001CBD5C File Offset: 0x001C9F5C
		public override EFaceExpressionConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFaceExpressionConfigType.Morph;
			}
			return EFaceExpressionConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x001CBD80 File Offset: 0x001C9F80
		public override void Write(Utf8JsonWriter writer, EFaceExpressionConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
