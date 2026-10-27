using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002390 RID: 9104
	public class EMotorEnterSlideModeJsonConverter : JsonConverter<EMotorEnterSlideMode>
	{
		// Token: 0x0600C688 RID: 50824 RVA: 0x001D1420 File Offset: 0x001CF620
		public override EMotorEnterSlideMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorEnterSlideMode.Jump;
			}
			return EMotorEnterSlideModeExtensions.FromString(@string);
		}

		// Token: 0x0600C689 RID: 50825 RVA: 0x001D1444 File Offset: 0x001CF644
		public override void Write(Utf8JsonWriter writer, EMotorEnterSlideMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
