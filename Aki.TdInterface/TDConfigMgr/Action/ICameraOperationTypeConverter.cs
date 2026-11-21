using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200167A RID: 5754
	public class ICameraOperationTypeConverter : JsonConverter<ICameraOperationType>
	{
		// Token: 0x0600819C RID: 33180 RVA: 0x00137234 File Offset: 0x00135434
		[return: Nullable(2)]
		public override ICameraOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ICameraOperationType result;
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
						if (!(@string == "EnableSection"))
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
					else
					{
						result = rootElement.Deserialize(options);
					}
				}
			}
			return result;
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x001372F0 File Offset: 0x001354F0
		public override void Write(Utf8JsonWriter writer, ICameraOperationType value, JsonSerializerOptions options)
		{
			IEnableCameraOperation enableCameraOperation = value as IEnableCameraOperation;
			if (enableCameraOperation != null)
			{
				JsonSerializer.Serialize<IEnableCameraOperation>(writer, enableCameraOperation, options);
				return;
			}
			IEnableSectionalCameraOperation enableSectionalCameraOperation = value as IEnableSectionalCameraOperation;
			if (enableSectionalCameraOperation != null)
			{
				JsonSerializer.Serialize<IEnableSectionalCameraOperation>(writer, enableSectionalCameraOperation, options);
				return;
			}
			IDisableCameraOperation disableCameraOperation = value as IDisableCameraOperation;
			if (disableCameraOperation == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IDisableCameraOperation>(writer, disableCameraOperation, options);
		}
	}
}
