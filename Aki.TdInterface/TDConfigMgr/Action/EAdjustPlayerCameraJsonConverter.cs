using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002298 RID: 8856
	public class EAdjustPlayerCameraJsonConverter : JsonConverter<EAdjustPlayerCamera>
	{
		// Token: 0x0600C22C RID: 49708 RVA: 0x001C5F9C File Offset: 0x001C419C
		public override EAdjustPlayerCamera Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAdjustPlayerCamera.Basic;
			}
			return EAdjustPlayerCameraExtensions.FromString(@string);
		}

		// Token: 0x0600C22D RID: 49709 RVA: 0x001C5FC0 File Offset: 0x001C41C0
		public override void Write(Utf8JsonWriter writer, EAdjustPlayerCamera value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
