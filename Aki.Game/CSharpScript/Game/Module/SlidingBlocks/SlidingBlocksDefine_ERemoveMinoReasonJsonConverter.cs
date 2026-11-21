using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B35 RID: 15157
	public class SlidingBlocksDefine_ERemoveMinoReasonJsonConverter : JsonConverter<SlidingBlocksDefine.ERemoveMinoReason>
	{
		// Token: 0x06026F85 RID: 159621 RVA: 0x00AE873C File Offset: 0x00AE693C
		public override SlidingBlocksDefine.ERemoveMinoReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SlidingBlocksDefine.ERemoveMinoReason.LineClearFall;
			}
			return SlidingBlocksDefine_ERemoveMinoReasonExtensions.FromString(@string);
		}

		// Token: 0x06026F86 RID: 159622 RVA: 0x00AE8760 File Offset: 0x00AE6960
		public override void Write(Utf8JsonWriter writer, SlidingBlocksDefine.ERemoveMinoReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
