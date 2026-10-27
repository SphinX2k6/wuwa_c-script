using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001543 RID: 5443
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundUiPrefabTypeConverter : JsonConverter<IFadeBackgroundUiPrefabType>
	{
		// Token: 0x06007B37 RID: 31543 RVA: 0x00128CD4 File Offset: 0x00126ED4
		[return: Nullable(2)]
		public override IFadeBackgroundUiPrefabType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IFadeBackgroundUiPrefabType result;
			using (JsonDocument jsonDocument = JsonDocument.ParseValue(ref reader))
			{
				JsonElement rootElement = jsonDocument.RootElement;
				JsonElement jsonElement;
				if (!rootElement.TryGetProperty("Type", out jsonElement))
				{
					result = rootElement.Deserialize(options);
				}
				else if (jsonElement.ValueKind != JsonValueKind.String)
				{
					result = null;
				}
				else
				{
					jsonElement.GetString() == "BlackScreenWhiteText";
					result = rootElement.Deserialize(options);
				}
			}
			return result;
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x00128D50 File Offset: 0x00126F50
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundUiPrefabType value, JsonSerializerOptions options)
		{
			IFadeBackgroundUiPrefabBlackScreenWhiteText fadeBackgroundUiPrefabBlackScreenWhiteText = value as IFadeBackgroundUiPrefabBlackScreenWhiteText;
			if (fadeBackgroundUiPrefabBlackScreenWhiteText != null)
			{
				JsonSerializer.Serialize<IFadeBackgroundUiPrefabBlackScreenWhiteText>(writer, fadeBackgroundUiPrefabBlackScreenWhiteText, options);
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
			defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
			throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}
}
