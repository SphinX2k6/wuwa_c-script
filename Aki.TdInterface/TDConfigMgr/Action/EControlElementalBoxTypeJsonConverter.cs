using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200255D RID: 9565
	public class EControlElementalBoxTypeJsonConverter : JsonConverter<EControlElementalBoxType>
	{
		// Token: 0x0600CF7E RID: 53118 RVA: 0x001E13B0 File Offset: 0x001DF5B0
		public override EControlElementalBoxType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EControlElementalBoxType.Capture;
			}
			return EControlElementalBoxTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x001E13D4 File Offset: 0x001DF5D4
		public override void Write(Utf8JsonWriter writer, EControlElementalBoxType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
