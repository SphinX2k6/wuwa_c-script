using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000971 RID: 2417
	public class EInteractAdditionalInfoTypeJsonConverter : JsonConverter<EInteractAdditionalInfoType>
	{
		// Token: 0x0600362F RID: 13871 RVA: 0x0008D5C0 File Offset: 0x0008B7C0
		public override EInteractAdditionalInfoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractAdditionalInfoType.FishingPoint;
			}
			return EInteractAdditionalInfoTypeExtensions.FromString(@string);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x0008D5E4 File Offset: 0x0008B7E4
		public override void Write(Utf8JsonWriter writer, EInteractAdditionalInfoType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
