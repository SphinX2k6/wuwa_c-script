using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F0 RID: 8944
	public class EControlTrackingTypeJsonConverter : JsonConverter<EControlTrackingType>
	{
		// Token: 0x0600C3B8 RID: 50104 RVA: 0x001C9678 File Offset: 0x001C7878
		public override EControlTrackingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EControlTrackingType.Self;
			}
			return EControlTrackingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x001C969C File Offset: 0x001C789C
		public override void Write(Utf8JsonWriter writer, EControlTrackingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
