using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x02000080 RID: 128
	public class EMetaTypeJsonConverter : JsonConverter<EMetaType>
	{
		// Token: 0x0600035A RID: 858 RVA: 0x00012728 File Offset: 0x00010928
		public override EMetaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMetaType.Map;
			}
			return EMetaTypeExtensions.FromString(@string);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001274C File Offset: 0x0001094C
		public override void Write(Utf8JsonWriter writer, EMetaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
