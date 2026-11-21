using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A4 RID: 5796
	public class IResetPosTypeConverter : JsonConverter<IResetPosType>
	{
		// Token: 0x0600821A RID: 33306 RVA: 0x00137F84 File Offset: 0x00136184
		[return: Nullable(2)]
		public override IResetPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IResetPosType result;
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
					if (!(@string == "PosEntity"))
					{
						if (!(@string == "ResetPoint"))
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

		// Token: 0x0600821B RID: 33307 RVA: 0x00138028 File Offset: 0x00136228
		public override void Write(Utf8JsonWriter writer, IResetPosType value, JsonSerializerOptions options)
		{
			IResetPosByPosEntity resetPosByPosEntity = value as IResetPosByPosEntity;
			if (resetPosByPosEntity != null)
			{
				JsonSerializer.Serialize<IResetPosByPosEntity>(writer, resetPosByPosEntity, options);
				return;
			}
			IResetPosByResetPoint resetPosByResetPoint = value as IResetPosByResetPoint;
			if (resetPosByResetPoint == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IResetPosByResetPoint>(writer, resetPosByResetPoint, options);
		}
	}
}
