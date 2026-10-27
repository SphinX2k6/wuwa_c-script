using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FE RID: 8958
	public class EDeliverTypeJsonConverter : JsonConverter<EDeliverType>
	{
		// Token: 0x0600C3F7 RID: 50167 RVA: 0x001C9DF0 File Offset: 0x001C7FF0
		public override EDeliverType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDeliverType.ItemIdCellIndependent;
			}
			return EDeliverTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C3F8 RID: 50168 RVA: 0x001C9E14 File Offset: 0x001C8014
		public override void Write(Utf8JsonWriter writer, EDeliverType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
