using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B8D RID: 19341
	public class SlidingBlocksDefine_ETetrominoTypeJsonConverter : JsonConverter<SlidingBlocksDefine.ETetrominoType>
	{
		// Token: 0x060321FE RID: 205310 RVA: 0x00BA4E30 File Offset: 0x00BA3030
		public override SlidingBlocksDefine.ETetrominoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SlidingBlocksDefine.ETetrominoType.I块;
			}
			return SlidingBlocksDefine_ETetrominoTypeExtensions.FromString(@string);
		}

		// Token: 0x060321FF RID: 205311 RVA: 0x00BA4E54 File Offset: 0x00BA3054
		public override void Write(Utf8JsonWriter writer, SlidingBlocksDefine.ETetrominoType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
