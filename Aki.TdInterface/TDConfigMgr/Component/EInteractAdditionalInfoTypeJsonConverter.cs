using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A24 RID: 2596
	public class EInteractAdditionalInfoTypeJsonConverter : JsonConverter<EInteractAdditionalInfoType>
	{
		// Token: 0x060039B6 RID: 14774 RVA: 0x0009552C File Offset: 0x0009372C
		public override EInteractAdditionalInfoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractAdditionalInfoType.FishingPoint;
			}
			return EInteractAdditionalInfoTypeExtensions.FromString(@string);
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x00095550 File Offset: 0x00093750
		public override void Write(Utf8JsonWriter writer, EInteractAdditionalInfoType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
