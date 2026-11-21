using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A7 RID: 5799
	public class ISkillOperationTypeConverter : JsonConverter<ISkillOperationType>
	{
		// Token: 0x06008223 RID: 33315 RVA: 0x001381CC File Offset: 0x001363CC
		[return: Nullable(2)]
		public override ISkillOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ISkillOperationType result;
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
							if (!(@string == "DisableSection"))
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

		// Token: 0x06008224 RID: 33316 RVA: 0x00138288 File Offset: 0x00136488
		public override void Write(Utf8JsonWriter writer, ISkillOperationType value, JsonSerializerOptions options)
		{
			IEnableSkillOperation enableSkillOperation = value as IEnableSkillOperation;
			if (enableSkillOperation != null)
			{
				JsonSerializer.Serialize<IEnableSkillOperation>(writer, enableSkillOperation, options);
				return;
			}
			IDisableSkillOperation disableSkillOperation = value as IDisableSkillOperation;
			if (disableSkillOperation != null)
			{
				JsonSerializer.Serialize<IDisableSkillOperation>(writer, disableSkillOperation, options);
				return;
			}
			IDisableSectionalSkillOperation disableSectionalSkillOperation = value as IDisableSectionalSkillOperation;
			if (disableSectionalSkillOperation == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<IDisableSectionalSkillOperation>(writer, disableSectionalSkillOperation, options);
		}
	}
}
