using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002601 RID: 9729
	public class ELongPressInteractStyleJsonConverter : JsonConverter<ELongPressInteractStyle>
	{
		// Token: 0x0600D260 RID: 53856 RVA: 0x001E95F4 File Offset: 0x001E77F4
		public override ELongPressInteractStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELongPressInteractStyle.Default;
			}
			return ELongPressInteractStyleExtensions.FromString(@string);
		}

		// Token: 0x0600D261 RID: 53857 RVA: 0x001E9618 File Offset: 0x001E7818
		public override void Write(Utf8JsonWriter writer, ELongPressInteractStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
