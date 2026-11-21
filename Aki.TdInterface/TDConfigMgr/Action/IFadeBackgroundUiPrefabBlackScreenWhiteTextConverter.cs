using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200169C RID: 5788
	public class IFadeBackgroundUiPrefabBlackScreenWhiteTextConverter : JsonConverter<IFadeBackgroundUiPrefabBlackScreenWhiteText>
	{
		// Token: 0x06008202 RID: 33282 RVA: 0x00137B23 File Offset: 0x00135D23
		[return: Nullable(2)]
		public override IFadeBackgroundUiPrefabBlackScreenWhiteText Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundUiPrefabBlackScreenWhiteText.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue>(ref reader, options));
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x00137B31 File Offset: 0x00135D31
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundUiPrefabBlackScreenWhiteText value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundUiPrefabBlackScreenWhiteText_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
