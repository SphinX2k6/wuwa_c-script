using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C1 RID: 9665
	public class EGuestOperateUiAnimationJsonConverter : JsonConverter<EGuestOperateUiAnimation>
	{
		// Token: 0x0600D140 RID: 53568 RVA: 0x001E50CC File Offset: 0x001E32CC
		public override EGuestOperateUiAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuestOperateUiAnimation.Play;
			}
			return EGuestOperateUiAnimationExtensions.FromString(@string);
		}

		// Token: 0x0600D141 RID: 53569 RVA: 0x001E50F0 File Offset: 0x001E32F0
		public override void Write(Utf8JsonWriter writer, EGuestOperateUiAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
