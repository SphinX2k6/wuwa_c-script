using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EE RID: 8942
	public class EControlElementalBoxTypeJsonConverter : JsonConverter<EControlElementalBoxType>
	{
		// Token: 0x0600C3AF RID: 50095 RVA: 0x001C9564 File Offset: 0x001C7764
		public override EControlElementalBoxType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EControlElementalBoxType.Capture;
			}
			return EControlElementalBoxTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x001C9588 File Offset: 0x001C7788
		public override void Write(Utf8JsonWriter writer, EControlElementalBoxType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
