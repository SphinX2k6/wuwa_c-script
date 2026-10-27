using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C6 RID: 8902
	public class EBvbPlayDialogTypeJsonConverter : JsonConverter<EBvbPlayDialogType>
	{
		// Token: 0x0600C2FB RID: 49915 RVA: 0x001C7D24 File Offset: 0x001C5F24
		public override EBvbPlayDialogType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBvbPlayDialogType.DungeonBegin;
			}
			return EBvbPlayDialogTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x001C7D48 File Offset: 0x001C5F48
		public override void Write(Utf8JsonWriter writer, EBvbPlayDialogType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
