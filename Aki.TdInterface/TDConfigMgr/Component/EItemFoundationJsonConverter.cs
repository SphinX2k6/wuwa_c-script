using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A36 RID: 2614
	public class EItemFoundationJsonConverter : JsonConverter<EItemFoundation>
	{
		// Token: 0x06003A07 RID: 14855 RVA: 0x00095FCC File Offset: 0x000941CC
		public override EItemFoundation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EItemFoundation.CategoryMatching;
			}
			return EItemFoundationExtensions.FromString(@string);
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00095FF0 File Offset: 0x000941F0
		public override void Write(Utf8JsonWriter writer, EItemFoundation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
