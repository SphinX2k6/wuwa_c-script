using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240A RID: 9226
	public class ESetJigsawItemTypeJsonConverter : JsonConverter<ESetJigsawItemType>
	{
		// Token: 0x0600C8AD RID: 51373 RVA: 0x001D5D5C File Offset: 0x001D3F5C
		public override ESetJigsawItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetJigsawItemType.MoveJigsawItem;
			}
			return ESetJigsawItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8AE RID: 51374 RVA: 0x001D5D80 File Offset: 0x001D3F80
		public override void Write(Utf8JsonWriter writer, ESetJigsawItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
