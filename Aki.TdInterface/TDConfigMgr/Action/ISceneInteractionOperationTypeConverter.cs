using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A6 RID: 5798
	public class ISceneInteractionOperationTypeConverter : JsonConverter<ISceneInteractionOperationType>
	{
		// Token: 0x06008220 RID: 33312 RVA: 0x001380BC File Offset: 0x001362BC
		[return: Nullable(2)]
		public override ISceneInteractionOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ISceneInteractionOperationType result;
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
					if (!(@string == "Enable"))
					{
						if (!(@string == "Disable"))
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

		// Token: 0x06008221 RID: 33313 RVA: 0x00138160 File Offset: 0x00136360
		public override void Write(Utf8JsonWriter writer, ISceneInteractionOperationType value, JsonSerializerOptions options)
		{
			IEnableSceneInteractionOperation enableSceneInteractionOperation = value as IEnableSceneInteractionOperation;
			if (enableSceneInteractionOperation != null)
			{
				JsonSerializer.Serialize<IEnableSceneInteractionOperation>(writer, enableSceneInteractionOperation, options);
				return;
			}
			IDisableSceneInteractionOperation disableSceneInteractionOperation = value as IDisableSceneInteractionOperation;
			if (disableSceneInteractionOperation == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IDisableSceneInteractionOperation>(writer, disableSceneInteractionOperation, options);
		}
	}
}
