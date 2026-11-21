using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001367 RID: 4967
	public class EBtNodeJsonConverter : JsonConverter<EBtNode>
	{
		// Token: 0x06006FAB RID: 28587 RVA: 0x00108E74 File Offset: 0x00107074
		public override EBtNode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBtNode.Start;
			}
			return EBtNodeExtensions.FromString(@string);
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x00108E98 File Offset: 0x00107098
		public override void Write(Utf8JsonWriter writer, EBtNode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
