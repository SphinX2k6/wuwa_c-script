using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001542 RID: 5442
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundUiPrefabConverter : JsonConverter<IFadeBackgroundUiPrefab>
	{
		// Token: 0x06007B34 RID: 31540 RVA: 0x00128CAC File Offset: 0x00126EAC
		[return: Nullable(2)]
		public override IFadeBackgroundUiPrefab Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundUiPrefab.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundUiPrefab_SetValue>(ref reader, options));
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x00128CBA File Offset: 0x00126EBA
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundUiPrefab value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundUiPrefab_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
