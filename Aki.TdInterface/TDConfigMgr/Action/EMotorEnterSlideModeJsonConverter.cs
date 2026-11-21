using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002619 RID: 9753
	public class EMotorEnterSlideModeJsonConverter : JsonConverter<EMotorEnterSlideMode>
	{
		// Token: 0x0600D2CC RID: 53964 RVA: 0x001EA3F4 File Offset: 0x001E85F4
		public override EMotorEnterSlideMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorEnterSlideMode.Jump;
			}
			return EMotorEnterSlideModeExtensions.FromString(@string);
		}

		// Token: 0x0600D2CD RID: 53965 RVA: 0x001EA418 File Offset: 0x001E8618
		public override void Write(Utf8JsonWriter writer, EMotorEnterSlideMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
