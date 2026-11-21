using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B37 RID: 15159
	public class SlidingBlocksDefine_ETetrominoTypeJsonConverter : JsonConverter<SlidingBlocksDefine.ETetrominoType>
	{
		// Token: 0x06026F8E RID: 159630 RVA: 0x00AE8F7C File Offset: 0x00AE717C
		public override SlidingBlocksDefine.ETetrominoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SlidingBlocksDefine.ETetrominoType.I块;
			}
			return SlidingBlocksDefine_ETetrominoTypeExtensions.FromString(@string);
		}

		// Token: 0x06026F8F RID: 159631 RVA: 0x00AE8FA0 File Offset: 0x00AE71A0
		public override void Write(Utf8JsonWriter writer, SlidingBlocksDefine.ETetrominoType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
