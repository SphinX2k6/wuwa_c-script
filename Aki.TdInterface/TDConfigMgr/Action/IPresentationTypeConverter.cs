using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A1 RID: 5793
	public class IPresentationTypeConverter : JsonConverter<IPresentationType>
	{
		// Token: 0x06008211 RID: 33297 RVA: 0x00137E64 File Offset: 0x00136064
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

		// Token: 0x06008212 RID: 33298 RVA: 0x00137EE0 File Offset: 0x001360E0
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
