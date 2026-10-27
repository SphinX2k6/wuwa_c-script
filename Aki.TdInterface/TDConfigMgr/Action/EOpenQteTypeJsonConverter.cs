using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B8 RID: 9144
	public class EOpenQteTypeJsonConverter : JsonConverter<EOpenQteType>
	{
		// Token: 0x0600C73C RID: 51004 RVA: 0x001D2B74 File Offset: 0x001D0D74
		public override EOpenQteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOpenQteType.PanelQte;
			}
			return EOpenQteTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C73D RID: 51005 RVA: 0x001D2B98 File Offset: 0x001D0D98
		public override void Write(Utf8JsonWriter writer, EOpenQteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
