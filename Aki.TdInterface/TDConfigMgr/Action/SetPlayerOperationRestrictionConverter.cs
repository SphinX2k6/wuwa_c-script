using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001550 RID: 5456
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SetPlayerOperationRestrictionConverter : JsonConverter<SetPlayerOperationRestriction>
	{
		// Token: 0x06007B5E RID: 31582 RVA: 0x00129508 File Offset: 0x00127708
		[return: Nullable(2)]
		public override SetPlayerOperationRestriction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			SetPlayerOperationRestriction result;
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
					if (!(@string == "EnableAll"))
					{
						if (!(@string == "DisableAll"))
						{
							if (!(@string == "DisableModule"))
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

		// Token: 0x06007B5F RID: 31583 RVA: 0x001295C4 File Offset: 0x001277C4
		public override void Write(Utf8JsonWriter writer, SetPlayerOperationRestriction value, JsonSerializerOptions options)
		{
			IEnableAllPlayerOperation enableAllPlayerOperation = value as IEnableAllPlayerOperation;
			if (enableAllPlayerOperation != null)
			{
				JsonSerializer.Serialize<IEnableAllPlayerOperation>(writer, enableAllPlayerOperation, options);
				return;
			}
			IDisableAllPlayerOperation disableAllPlayerOperation = value as IDisableAllPlayerOperation;
			if (disableAllPlayerOperation != null)
			{
				JsonSerializer.Serialize<IDisableAllPlayerOperation>(writer, disableAllPlayerOperation, options);
				return;
			}
			IDisableModulePlayerOperation disableModulePlayerOperation = value as IDisableModulePlayerOperation;
			if (disableModulePlayerOperation == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IDisableModulePlayerOperation>(writer, disableModulePlayerOperation, options);
		}
	}
}
