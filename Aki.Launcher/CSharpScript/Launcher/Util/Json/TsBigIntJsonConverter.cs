using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x02000085 RID: 133
	[NullableContext(1)]
	[Nullable(0)]
	public class TsBigIntJsonConverter : JsonConverter<long>
	{
		// Token: 0x06000381 RID: 897 RVA: 0x00013AA4 File Offset: 0x00011CA4
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

		// Token: 0x06000382 RID: 898 RVA: 0x00013B0C File Offset: 0x00011D0C
		public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted("__kr_long__");
			defaultInterpolatedStringHandler.AppendFormatted<long>(value);
			writer.WriteStringValue(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}
}
