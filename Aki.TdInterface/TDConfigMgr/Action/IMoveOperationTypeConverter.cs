using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001544 RID: 5444
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IMoveOperationTypeConverter : JsonConverter<IMoveOperationType>
	{
		// Token: 0x06007B3A RID: 31546 RVA: 0x00128DA8 File Offset: 0x00126FA8
		[return: Nullable(2)]
		public override IMoveOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IMoveOperationType result;
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

		// Token: 0x06007B3B RID: 31547 RVA: 0x00128E4C File Offset: 0x0012704C
		public override void Write(Utf8JsonWriter writer, IMoveOperationType value, JsonSerializerOptions options)
		{
			IEnableMoveOperation enableMoveOperation = value as IEnableMoveOperation;
			if (enableMoveOperation != null)
			{
				JsonSerializer.Serialize<IEnableMoveOperation>(writer, enableMoveOperation, options);
				return;
			}
			IDisableMoveOperation disableMoveOperation = value as IDisableMoveOperation;
			if (disableMoveOperation == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IDisableMoveOperation>(writer, disableMoveOperation, options);
		}
	}
}
