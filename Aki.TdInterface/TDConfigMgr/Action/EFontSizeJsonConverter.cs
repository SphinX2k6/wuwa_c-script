using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B5 RID: 9653
	public class EFontSizeJsonConverter : JsonConverter<EFontSize>
	{
		// Token: 0x0600D10A RID: 53514 RVA: 0x001E4900 File Offset: 0x001E2B00
		public override EFontSize Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFontSize.Small;
			}
			return EFontSizeExtensions.FromString(@string);
		}

		// Token: 0x0600D10B RID: 53515 RVA: 0x001E4924 File Offset: 0x001E2B24
		public override void Write(Utf8JsonWriter writer, EFontSize value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
