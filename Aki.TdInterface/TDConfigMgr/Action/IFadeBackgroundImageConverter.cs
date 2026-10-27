using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200153E RID: 5438
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundImageConverter : JsonConverter<IFadeBackgroundImage>
	{
		// Token: 0x06007B28 RID: 31528 RVA: 0x00128B00 File Offset: 0x00126D00
		[return: Nullable(2)]
		public override IFadeBackgroundImage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundImage.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundImage_SetValue>(ref reader, options));
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x00128B0E File Offset: 0x00126D0E
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundImage value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundImage_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
