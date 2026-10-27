using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200154B RID: 5451
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ISkillOperationTypeConverter : JsonConverter<ISkillOperationType>
	{
		// Token: 0x06007B4F RID: 31567 RVA: 0x00129220 File Offset: 0x00127420
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

		// Token: 0x06007B50 RID: 31568 RVA: 0x001292DC File Offset: 0x001274DC
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
