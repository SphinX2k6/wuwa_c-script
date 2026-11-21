using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200260B RID: 9739
	public class EMechStuntTypeJsonConverter : JsonConverter<EMechStuntType>
	{
		// Token: 0x0600D28D RID: 53901 RVA: 0x001E9C34 File Offset: 0x001E7E34
		public override EMechStuntType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechStuntType.Dive;
			}
			return EMechStuntTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D28E RID: 53902 RVA: 0x001E9C58 File Offset: 0x001E7E58
		public override void Write(Utf8JsonWriter writer, EMechStuntType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
