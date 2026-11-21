using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001699 RID: 5785
	public class IFadeBackgroundImageConverter : JsonConverter<IFadeBackgroundImage>
	{
		// Token: 0x060081F9 RID: 33273 RVA: 0x0013799C File Offset: 0x00135B9C
		[return: Nullable(2)]
		public override IFadeBackgroundImage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundImage.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundImage_SetValue>(ref reader, options));
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x001379AA File Offset: 0x00135BAA
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundImage value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundImage_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
