using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F2 RID: 9202
	public class EResetPresentationTypeJsonConverter : JsonConverter<EResetPresentationType>
	{
		// Token: 0x0600C841 RID: 51265 RVA: 0x001D500C File Offset: 0x001D320C
		public override EResetPresentationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetPresentationType.Failure;
			}
			return EResetPresentationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C842 RID: 51266 RVA: 0x001D5030 File Offset: 0x001D3230
		public override void Write(Utf8JsonWriter writer, EResetPresentationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
