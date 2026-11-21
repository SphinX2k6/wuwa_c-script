using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026EF RID: 9967
	public class ESystemTypeJsonConverter : JsonConverter<ESystemType>
	{
		// Token: 0x0600D68F RID: 54927 RVA: 0x001F4F60 File Offset: 0x001F3160
		public override ESystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemType.Shop;
			}
			return ESystemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D690 RID: 54928 RVA: 0x001F4F84 File Offset: 0x001F3184
		public override void Write(Utf8JsonWriter writer, ESystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
