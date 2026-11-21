using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BE9 RID: 15337
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffQuestionResultJsonConfigConverter : JsonConverter<ISheriffQuestionResultJsonConfig>
	{
		// Token: 0x0602755E RID: 161118 RVA: 0x00B07D6E File Offset: 0x00B05F6E
		[return: Nullable(2)]
		public override ISheriffQuestionResultJsonConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SheriffQuestionResultJsonConfig>(ref reader, options);
		}

		// Token: 0x0602755F RID: 161119 RVA: 0x00B07D77 File Offset: 0x00B05F77
		public override void Write(Utf8JsonWriter writer, ISheriffQuestionResultJsonConfig value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<SheriffQuestionResultJsonConfig>(writer, (SheriffQuestionResultJsonConfig)value, options);
		}
	}
}
