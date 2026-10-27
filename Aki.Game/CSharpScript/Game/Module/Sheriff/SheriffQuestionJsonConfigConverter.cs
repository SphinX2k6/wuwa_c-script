using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C35 RID: 19509
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffQuestionJsonConfigConverter : JsonConverter<ISheriffQuestionJsonConfig>
	{
		// Token: 0x0603278F RID: 206735 RVA: 0x00BC30A7 File Offset: 0x00BC12A7
		[return: Nullable(2)]
		public override ISheriffQuestionJsonConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SheriffQuestionJsonConfig>(ref reader, options);
		}

		// Token: 0x06032790 RID: 206736 RVA: 0x00BC30B0 File Offset: 0x00BC12B0
		public override void Write(Utf8JsonWriter writer, ISheriffQuestionJsonConfig value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<SheriffQuestionJsonConfig>(writer, (SheriffQuestionJsonConfig)value, options);
		}
	}
}
