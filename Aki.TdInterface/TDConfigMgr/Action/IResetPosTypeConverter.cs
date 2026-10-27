using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001548 RID: 5448
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IResetPosTypeConverter : JsonConverter<IResetPosType>
	{
		// Token: 0x06007B46 RID: 31558 RVA: 0x00128FD8 File Offset: 0x001271D8
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

		// Token: 0x06007B47 RID: 31559 RVA: 0x0012907C File Offset: 0x0012727C
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
