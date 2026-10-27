using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001539 RID: 5433
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeInEffectTypeBaseConverter : JsonConverter<IFadeBackgroundFadeInEffectTypeBase>
	{
		// Token: 0x06007B19 RID: 31513 RVA: 0x00128870 File Offset: 0x00126A70
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffectTypeBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IFadeBackgroundFadeInEffectTypeBase result;
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

		// Token: 0x06007B1A RID: 31514 RVA: 0x00128914 File Offset: 0x00126B14
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffectTypeBase value, JsonSerializerOptions options)
		{
			IFadeBackgroundFadeInEffectBlack fadeBackgroundFadeInEffectBlack = value as IFadeBackgroundFadeInEffectBlack;
			if (fadeBackgroundFadeInEffectBlack != null)
			{
				JsonSerializer.Serialize<IFadeBackgroundFadeInEffectBlack>(writer, fadeBackgroundFadeInEffectBlack, options);
				return;
			}
			IFadeBackgroundFadeInEffectScreenEffect fadeBackgroundFadeInEffectScreenEffect = value as IFadeBackgroundFadeInEffectScreenEffect;
			if (fadeBackgroundFadeInEffectScreenEffect == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffectScreenEffect>(writer, fadeBackgroundFadeInEffectScreenEffect, options);
		}
	}
}
