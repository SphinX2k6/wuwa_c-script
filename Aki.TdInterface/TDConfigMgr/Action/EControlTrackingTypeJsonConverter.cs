using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200255F RID: 9567
	public class EControlTrackingTypeJsonConverter : JsonConverter<EControlTrackingType>
	{
		// Token: 0x0600CF87 RID: 53127 RVA: 0x001E14C4 File Offset: 0x001DF6C4
		public override EControlTrackingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EControlTrackingType.Self;
			}
			return EControlTrackingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF88 RID: 53128 RVA: 0x001E14E8 File Offset: 0x001DF6E8
		public override void Write(Utf8JsonWriter writer, EControlTrackingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
