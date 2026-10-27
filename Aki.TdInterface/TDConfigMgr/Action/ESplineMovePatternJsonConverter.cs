using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242A RID: 9258
	public class ESplineMovePatternJsonConverter : JsonConverter<ESplineMovePattern>
	{
		// Token: 0x0600C93D RID: 51517 RVA: 0x001D77E8 File Offset: 0x001D59E8
		public override ESplineMovePattern Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMovePattern.PathLine;
			}
			return ESplineMovePatternExtensions.FromString(@string);
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x001D780C File Offset: 0x001D5A0C
		public override void Write(Utf8JsonWriter writer, ESplineMovePattern value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
