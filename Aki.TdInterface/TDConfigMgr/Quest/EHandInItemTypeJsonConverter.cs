using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001249 RID: 4681
	public class EHandInItemTypeJsonConverter : JsonConverter<EHandInItemType>
	{
		// Token: 0x060069F1 RID: 27121 RVA: 0x000FDC64 File Offset: 0x000FBE64
		public override EHandInItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHandInItemType.ItemIds;
			}
			return EHandInItemTypeExtensions.FromString(@string);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x000FDC88 File Offset: 0x000FBE88
		public override void Write(Utf8JsonWriter writer, EHandInItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
