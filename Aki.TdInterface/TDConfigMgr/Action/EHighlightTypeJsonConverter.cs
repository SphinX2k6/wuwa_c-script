using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002358 RID: 9048
	public class EHighlightTypeJsonConverter : JsonConverter<EHighlightType>
	{
		// Token: 0x0600C58C RID: 50572 RVA: 0x001CD514 File Offset: 0x001CB714
		public override EHighlightType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHighlightType.CommonWhite;
			}
			return EHighlightTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x001CD538 File Offset: 0x001CB738
		public override void Write(Utf8JsonWriter writer, EHighlightType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
