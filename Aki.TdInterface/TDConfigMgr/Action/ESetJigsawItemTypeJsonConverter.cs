using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A9 RID: 9897
	public class ESetJigsawItemTypeJsonConverter : JsonConverter<ESetJigsawItemType>
	{
		// Token: 0x0600D554 RID: 54612 RVA: 0x001EF958 File Offset: 0x001EDB58
		public override ESetJigsawItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetJigsawItemType.MoveJigsawItem;
			}
			return ESetJigsawItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D555 RID: 54613 RVA: 0x001EF97C File Offset: 0x001EDB7C
		public override void Write(Utf8JsonWriter writer, ESetJigsawItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
