using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200153D RID: 5437
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeOutEffectTypeBaseConverter : JsonConverter<IFadeBackgroundFadeOutEffectTypeBase>
	{
		// Token: 0x06007B25 RID: 31525 RVA: 0x001289F0 File Offset: 0x00126BF0
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffectTypeBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IFadeBackgroundFadeOutEffectTypeBase result;
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
					if (!(@string == "Black"))
					{
						if (!(@string == "ScreenEffect"))
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
			}
			return result;
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x00128A94 File Offset: 0x00126C94
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffectTypeBase value, JsonSerializerOptions options)
		{
			IFadeBackgroundFadeOutEffectBlack fadeBackgroundFadeOutEffectBlack = value as IFadeBackgroundFadeOutEffectBlack;
			if (fadeBackgroundFadeOutEffectBlack != null)
			{
				JsonSerializer.Serialize<IFadeBackgroundFadeOutEffectBlack>(writer, fadeBackgroundFadeOutEffectBlack, options);
				return;
			}
			IFadeBackgroundFadeOutEffectScreenEffect fadeBackgroundFadeOutEffectScreenEffect = value as IFadeBackgroundFadeOutEffectScreenEffect;
			if (fadeBackgroundFadeOutEffectScreenEffect == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffectScreenEffect>(writer, fadeBackgroundFadeOutEffectScreenEffect, options);
		}
	}
}
