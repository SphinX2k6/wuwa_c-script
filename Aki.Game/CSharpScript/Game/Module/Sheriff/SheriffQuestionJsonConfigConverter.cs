using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE6 RID: 15334
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffQuestionJsonConfigConverter : JsonConverter<ISheriffQuestionJsonConfig>
	{
		// Token: 0x06027542 RID: 161090 RVA: 0x00B07CBF File Offset: 0x00B05EBF
		[return: Nullable(2)]
		public override ISheriffQuestionJsonConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SheriffQuestionJsonConfig>(ref reader, options);
		}

		// Token: 0x06027543 RID: 161091 RVA: 0x00B07CC8 File Offset: 0x00B05EC8
		public override void Write(Utf8JsonWriter writer, ISheriffQuestionJsonConfig value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<SheriffQuestionJsonConfig>(writer, (SheriffQuestionJsonConfig)value, options);
		}
	}
}
