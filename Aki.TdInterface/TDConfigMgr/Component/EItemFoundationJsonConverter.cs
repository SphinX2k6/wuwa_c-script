using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000983 RID: 2435
	public class EItemFoundationJsonConverter : JsonConverter<EItemFoundation>
	{
		// Token: 0x06003680 RID: 13952 RVA: 0x0008E060 File Offset: 0x0008C260
		public override EItemFoundation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EItemFoundation.CategoryMatching;
			}
			return EItemFoundationExtensions.FromString(@string);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x0008E084 File Offset: 0x0008C284
		public override void Write(Utf8JsonWriter writer, EItemFoundation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
