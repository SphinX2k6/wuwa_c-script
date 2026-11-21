using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200026C RID: 620
	[NullableContext(1)]
	[Nullable(0)]
	public class VulkanSettingIntegerConverter : JsonConverter<int?>
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x0005BD18 File Offset: 0x00059F18
		public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String)
			{
				string @string = reader.GetString();
				if (string.IsNullOrEmpty(@string))
				{
					return null;
				}
				char c = @string[0];
				bool flag = c == '+' || c == '-';
				for (int i = (flag > false) ? 1 : 0; i < @string.Length; i++)
				{
					if (@string[i] < '0' || @string[i] > '9')
					{
						return null;
					}
				}
				int value;
				if (!int.TryParse(@string, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out value))
				{
					return null;
				}
				return new int?(value);
			}
			else
			{
				double num;
				if (reader.TokenType == JsonTokenType.Number && reader.TryGetDouble(out num) && num >= -2147483648.0 && num <= 2147483647.0 && num == Math.Truncate(num))
				{
					return new int?((int)num);
				}
				reader.Skip();
				return null;
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0005BE0E File Offset: 0x0005A00E
		public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
		{
			if (value != null)
			{
				writer.WriteNumberValue(value.Value);
				return;
			}
			writer.WriteNullValue();
		}
	}
}
