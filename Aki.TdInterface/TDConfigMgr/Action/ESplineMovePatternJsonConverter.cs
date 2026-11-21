using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026CB RID: 9931
	public class ESplineMovePatternJsonConverter : JsonConverter<ESplineMovePattern>
	{
		// Token: 0x0600D5ED RID: 54765 RVA: 0x001F163C File Offset: 0x001EF83C
		public override ESplineMovePattern Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMovePattern.PathLine;
			}
			return ESplineMovePatternExtensions.FromString(@string);
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x001F1660 File Offset: 0x001EF860
		public override void Write(Utf8JsonWriter writer, ESplineMovePattern value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
