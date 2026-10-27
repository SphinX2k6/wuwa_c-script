using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234E RID: 9038
	public class EGuestOperateUiAnimationJsonConverter : JsonConverter<EGuestOperateUiAnimation>
	{
		// Token: 0x0600C55F RID: 50527 RVA: 0x001CCF00 File Offset: 0x001CB100
		public override EGuestOperateUiAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuestOperateUiAnimation.Play;
			}
			return EGuestOperateUiAnimationExtensions.FromString(@string);
		}

		// Token: 0x0600C560 RID: 50528 RVA: 0x001CCF24 File Offset: 0x001CB124
		public override void Write(Utf8JsonWriter writer, EGuestOperateUiAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
