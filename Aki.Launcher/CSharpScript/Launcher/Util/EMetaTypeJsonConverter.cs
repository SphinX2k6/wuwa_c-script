using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007D RID: 125
	public class EMetaTypeJsonConverter : JsonConverter<EMetaType>
	{
		// Token: 0x0600034A RID: 842 RVA: 0x000118A4 File Offset: 0x0000FAA4
		public override EMetaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMetaType.Map;
			}
			return EMetaTypeExtensions.FromString(@string);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000118C8 File Offset: 0x0000FAC8
		public override void Write(Utf8JsonWriter writer, EMetaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
