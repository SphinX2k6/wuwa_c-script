using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x02000082 RID: 130
	[NullableContext(1)]
	[Nullable(0)]
	public class TsBigIntJsonConverter : JsonConverter<long>
	{
		// Token: 0x06000370 RID: 880 RVA: 0x00012B48 File Offset: 0x00010D48
		public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Number)
			{
				return reader.GetInt64();
			}
			if (reader.TokenType == JsonTokenType.String)
			{
				string @string = reader.GetString();
				if (@string != null)
				{
					ReadOnlySpan<char> span = @string.AsSpan();
					if (span.StartsWith("__kr_long__"))
					{
						long result;
						long.TryParse(span.Slice("__kr_long__".Length), out result);
						return result;
					}
				}
			}
			return 0L;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00012BB0 File Offset: 0x00010DB0
		public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("__kr_long__");
			defaultInterpolatedStringHandler.AppendFormatted<long>(value);
			writer.WriteStringValue(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}
}
