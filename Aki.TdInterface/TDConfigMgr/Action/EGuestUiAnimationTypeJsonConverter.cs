using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C3 RID: 9667
	public class EGuestUiAnimationTypeJsonConverter : JsonConverter<EGuestUiAnimationType>
	{
		// Token: 0x0600D149 RID: 53577 RVA: 0x001E51A8 File Offset: 0x001E33A8
		public override EGuestUiAnimationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuestUiAnimationType.GuestCartethyia;
			}
			return EGuestUiAnimationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D14A RID: 53578 RVA: 0x001E51CC File Offset: 0x001E33CC
		public override void Write(Utf8JsonWriter writer, EGuestUiAnimationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
