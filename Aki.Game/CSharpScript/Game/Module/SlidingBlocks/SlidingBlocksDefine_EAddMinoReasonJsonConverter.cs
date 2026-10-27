using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B89 RID: 19337
	public class SlidingBlocksDefine_EAddMinoReasonJsonConverter : JsonConverter<SlidingBlocksDefine.EAddMinoReason>
	{
		// Token: 0x060321EC RID: 205292 RVA: 0x00BA44DC File Offset: 0x00BA26DC
		public override SlidingBlocksDefine.EAddMinoReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SlidingBlocksDefine.EAddMinoReason.LineClearFall;
			}
			return SlidingBlocksDefine_EAddMinoReasonExtensions.FromString(@string);
		}

		// Token: 0x060321ED RID: 205293 RVA: 0x00BA4500 File Offset: 0x00BA2700
		public override void Write(Utf8JsonWriter writer, SlidingBlocksDefine.EAddMinoReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
