using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D5 RID: 9685
	public class EInteractIconJsonConverter : JsonConverter<EInteractIcon>
	{
		// Token: 0x0600D19A RID: 53658 RVA: 0x001E6B84 File Offset: 0x001E4D84
		public override EInteractIcon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractIcon.Dialog;
			}
			return EInteractIconExtensions.FromString(@string);
		}

		// Token: 0x0600D19B RID: 53659 RVA: 0x001E6BA8 File Offset: 0x001E4DA8
		public override void Write(Utf8JsonWriter writer, EInteractIcon value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
