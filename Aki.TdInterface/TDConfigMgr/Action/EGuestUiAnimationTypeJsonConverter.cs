using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002350 RID: 9040
	public class EGuestUiAnimationTypeJsonConverter : JsonConverter<EGuestUiAnimationType>
	{
		// Token: 0x0600C568 RID: 50536 RVA: 0x001CCFDC File Offset: 0x001CB1DC
		public override EGuestUiAnimationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuestUiAnimationType.GuestCartethyia;
			}
			return EGuestUiAnimationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C569 RID: 50537 RVA: 0x001CD000 File Offset: 0x001CB200
		public override void Write(Utf8JsonWriter writer, EGuestUiAnimationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
