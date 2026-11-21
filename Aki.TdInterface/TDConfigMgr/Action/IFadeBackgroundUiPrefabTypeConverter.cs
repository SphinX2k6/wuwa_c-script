using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200169E RID: 5790
	public class IFadeBackgroundUiPrefabTypeConverter : JsonConverter<IFadeBackgroundUiPrefabType>
	{
		// Token: 0x06008208 RID: 33288 RVA: 0x00137B70 File Offset: 0x00135D70
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

		// Token: 0x06008209 RID: 33289 RVA: 0x00137BEC File Offset: 0x00135DEC
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
