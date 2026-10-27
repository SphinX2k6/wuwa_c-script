using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200154D RID: 5453
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IUiOperationTypeConverter : JsonConverter<IUiOperationType>
	{
		// Token: 0x06007B55 RID: 31573 RVA: 0x00129380 File Offset: 0x00127580
		[return: Nullable(2)]
		public override IUiOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IUiOperationType result;
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
							if (!(@string == "EnableSectionalUi"))
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

		// Token: 0x06007B56 RID: 31574 RVA: 0x0012943C File Offset: 0x0012763C
		public override void Write(Utf8JsonWriter writer, IUiOperationType value, JsonSerializerOptions options)
		{
			IEnableUiOperation enableUiOperation = value as IEnableUiOperation;
			if (enableUiOperation != null)
			{
				JsonSerializer.Serialize<IEnableUiOperation>(writer, enableUiOperation, options);
				return;
			}
			IDisableUiOperation disableUiOperation = value as IDisableUiOperation;
			if (disableUiOperation != null)
			{
				JsonSerializer.Serialize<IDisableUiOperation>(writer, disableUiOperation, options);
				return;
			}
			IEnableSectionalUi enableSectionalUi = value as IEnableSectionalUi;
			if (enableSectionalUi == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IEnableSectionalUi>(writer, enableSectionalUi, options);
		}
	}
}
