using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002360 RID: 9056
	public class EInteractIconJsonConverter : JsonConverter<EInteractIcon>
	{
		// Token: 0x0600C5B0 RID: 50608 RVA: 0x001CE8A4 File Offset: 0x001CCAA4
		public override EInteractIcon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractIcon.Dialog;
			}
			return EInteractIconExtensions.FromString(@string);
		}

		// Token: 0x0600C5B1 RID: 50609 RVA: 0x001CE8C8 File Offset: 0x001CCAC8
		public override void Write(Utf8JsonWriter writer, EInteractIcon value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
