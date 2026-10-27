using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001541 RID: 5441
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundUiPrefabBlackScreenWhiteTextConverter : JsonConverter<IFadeBackgroundUiPrefabBlackScreenWhiteText>
	{
		// Token: 0x06007B31 RID: 31537 RVA: 0x00128C87 File Offset: 0x00126E87
		[return: Nullable(2)]
		public override IFadeBackgroundUiPrefabBlackScreenWhiteText Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue>(ref reader, options));
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x00128C95 File Offset: 0x00126E95
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundUiPrefabBlackScreenWhiteText value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
