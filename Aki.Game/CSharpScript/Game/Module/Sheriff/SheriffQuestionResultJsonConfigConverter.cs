using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C38 RID: 19512
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SheriffQuestionResultJsonConfigConverter : JsonConverter<ISheriffQuestionResultJsonConfig>
	{
		// Token: 0x060327AB RID: 206763 RVA: 0x00BC3156 File Offset: 0x00BC1356
		[return: Nullable(2)]
		public override ISheriffQuestionResultJsonConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return JsonSerializer.Deserialize<SheriffQuestionResultJsonConfig>(ref reader, options);
		}

		// Token: 0x060327AC RID: 206764 RVA: 0x00BC315F File Offset: 0x00BC135F
		public override void Write(Utf8JsonWriter writer, ISheriffQuestionResultJsonConfig value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<SheriffQuestionResultJsonConfig>(writer, (SheriffQuestionResultJsonConfig)value, options);
		}
	}
}
