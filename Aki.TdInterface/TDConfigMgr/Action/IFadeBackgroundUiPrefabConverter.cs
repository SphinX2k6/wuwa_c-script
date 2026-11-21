using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200169D RID: 5789
	public class IFadeBackgroundUiPrefabConverter : JsonConverter<IFadeBackgroundUiPrefab>
	{
		// Token: 0x06008205 RID: 33285 RVA: 0x00137B48 File Offset: 0x00135D48
		[return: Nullable(2)]
		public override IFadeBackgroundUiPrefab Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundUiPrefab.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundUiPrefab_SetValue>(ref reader, options));
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x00137B56 File Offset: 0x00135D56
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundUiPrefab value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundUiPrefab_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
