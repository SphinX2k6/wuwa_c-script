using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122B RID: 4651
	public class EBtNodeJsonConverter : JsonConverter<EBtNode>
	{
		// Token: 0x0600696A RID: 26986 RVA: 0x000FB568 File Offset: 0x000F9768
		public override EBtNode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBtNode.Start;
			}
			return EBtNodeExtensions.FromString(@string);
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x000FB58C File Offset: 0x000F978C
		public override void Write(Utf8JsonWriter writer, EBtNode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
