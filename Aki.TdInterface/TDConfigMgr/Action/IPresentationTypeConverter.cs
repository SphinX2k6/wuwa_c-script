using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001545 RID: 5445
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IPresentationTypeConverter : JsonConverter<IPresentationType>
	{
		// Token: 0x06007B3D RID: 31549 RVA: 0x00128EB8 File Offset: 0x001270B8
		[return: Nullable(2)]
		public override IPresentationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			IPresentationType result;
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
					jsonElement.GetString() == "Failure";
					result = rootElement.Deserialize(options);
				}
			}
			return result;
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x00128F34 File Offset: 0x00127134
		public override void Write(Utf8JsonWriter writer, IPresentationType value, JsonSerializerOptions options)
		{
			IResetPresentationFailure resetPresentationFailure = value as IResetPresentationFailure;
			if (resetPresentationFailure != null)
			{
				JsonSerializer.Serialize<IResetPresentationFailure>(writer, resetPresentationFailure, options);
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
			defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
			throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}
}
