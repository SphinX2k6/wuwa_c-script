using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B8B RID: 19339
	public class SlidingBlocksDefine_ERemoveMinoReasonJsonConverter : JsonConverter<SlidingBlocksDefine.ERemoveMinoReason>
	{
		// Token: 0x060321F5 RID: 205301 RVA: 0x00BA45F0 File Offset: 0x00BA27F0
		public override SlidingBlocksDefine.ERemoveMinoReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SlidingBlocksDefine.ERemoveMinoReason.LineClearFall;
			}
			return SlidingBlocksDefine_ERemoveMinoReasonExtensions.FromString(@string);
		}

		// Token: 0x060321F6 RID: 205302 RVA: 0x00BA4614 File Offset: 0x00BA2814
		public override void Write(Utf8JsonWriter writer, SlidingBlocksDefine.ERemoveMinoReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
