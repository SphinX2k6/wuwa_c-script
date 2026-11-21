using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A0 RID: 5792
	public class IPlayerAiControlBaseConverter : JsonConverter<IPlayerAiControlBase>
	{
		// Token: 0x0600820E RID: 33294 RVA: 0x00137D54 File Offset: 0x00135F54
		[return: Nullable(2)]
		public override IPlayerAiControlBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IPlayerAiControlBase result;
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

		// Token: 0x0600820F RID: 33295 RVA: 0x00137DF8 File Offset: 0x00135FF8
		public override void Write(Utf8JsonWriter writer, IPlayerAiControlBase value, JsonSerializerOptions options)
		{
			IEnablePlayerAiControl enablePlayerAiControl = value as IEnablePlayerAiControl;
			if (enablePlayerAiControl != null)
			{
				JsonSerializer.Serialize<IEnablePlayerAiControl>(writer, enablePlayerAiControl, options);
				return;
			}
			IDisablePlayerAiControl disablePlayerAiControl = value as IDisablePlayerAiControl;
			if (disablePlayerAiControl == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IDisablePlayerAiControl>(writer, disablePlayerAiControl, options);
		}
	}
}
