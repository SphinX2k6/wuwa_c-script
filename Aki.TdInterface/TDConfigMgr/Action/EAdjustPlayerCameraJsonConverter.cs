using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002505 RID: 9477
	public class EAdjustPlayerCameraJsonConverter : JsonConverter<EAdjustPlayerCamera>
	{
		// Token: 0x0600CDF2 RID: 52722 RVA: 0x001DDC90 File Offset: 0x001DBE90
		public override EAdjustPlayerCamera Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAdjustPlayerCamera.Basic;
			}
			return EAdjustPlayerCameraExtensions.FromString(@string);
		}

		// Token: 0x0600CDF3 RID: 52723 RVA: 0x001DDCB4 File Offset: 0x001DBEB4
		public override void Write(Utf8JsonWriter writer, EAdjustPlayerCamera value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
