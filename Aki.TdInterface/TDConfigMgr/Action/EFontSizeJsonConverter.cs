using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002342 RID: 9026
	public class EFontSizeJsonConverter : JsonConverter<EFontSize>
	{
		// Token: 0x0600C529 RID: 50473 RVA: 0x001CC734 File Offset: 0x001CA934
		public override EFontSize Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFontSize.Small;
			}
			return EFontSizeExtensions.FromString(@string);
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x001CC758 File Offset: 0x001CA958
		public override void Write(Utf8JsonWriter writer, EFontSize value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
