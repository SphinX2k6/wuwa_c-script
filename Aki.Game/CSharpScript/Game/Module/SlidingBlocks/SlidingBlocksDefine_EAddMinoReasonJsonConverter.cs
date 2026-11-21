using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B33 RID: 15155
	public class SlidingBlocksDefine_EAddMinoReasonJsonConverter : JsonConverter<SlidingBlocksDefine.EAddMinoReason>
	{
		// Token: 0x06026F7C RID: 159612 RVA: 0x00AE8628 File Offset: 0x00AE6828
		public override SlidingBlocksDefine.EAddMinoReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SlidingBlocksDefine.EAddMinoReason.LineClearFall;
			}
			return SlidingBlocksDefine_EAddMinoReasonExtensions.FromString(@string);
		}

		// Token: 0x06026F7D RID: 159613 RVA: 0x00AE864C File Offset: 0x00AE684C
		public override void Write(Utf8JsonWriter writer, SlidingBlocksDefine.EAddMinoReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
