using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001540 RID: 5440
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundTypeConverter : JsonConverter<IFadeBackgroundType>
	{
		// Token: 0x06007B2E RID: 31534 RVA: 0x00128B4C File Offset: 0x00126D4C
		[return: Nullable(2)]
		public override IFadeBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IFadeBackgroundType result;
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
					string @string = jsonElement.GetString();
					if (!(@string == "Spine"))
					{
						if (!(@string == "BackgroundImage"))
						{
							if (!(@string == "UiPrefab"))
							{
								result = rootElement.Deserialize(options);
							}
							else
							{
								result = rootElement.Deserialize(options);
							}
						}
						else
						{
							result = rootElement.Deserialize(options);
						}
					}
					else
					{
						result = rootElement.Deserialize(options);
					}
				}
			}
			return result;
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x00128C08 File Offset: 0x00126E08
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundType value, JsonSerializerOptions options)
		{
			IFadeBackgroundSpine fadeBackgroundSpine = value as IFadeBackgroundSpine;
			if (fadeBackgroundSpine != null)
			{
				JsonSerializer.Serialize<IFadeBackgroundSpine>(writer, fadeBackgroundSpine, options);
				return;
			}
			IFadeBackgroundImage fadeBackgroundImage = value as IFadeBackgroundImage;
			if (fadeBackgroundImage != null)
			{
				JsonSerializer.Serialize<IFadeBackgroundImage>(writer, fadeBackgroundImage, options);
				return;
			}
			IFadeBackgroundUiPrefab fadeBackgroundUiPrefab = value as IFadeBackgroundUiPrefab;
			if (fadeBackgroundUiPrefab == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IFadeBackgroundUiPrefab>(writer, fadeBackgroundUiPrefab, options);
		}
	}
}
