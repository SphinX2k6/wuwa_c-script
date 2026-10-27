using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000279 RID: 633
	public class EAppTypeJsonConverter : JsonConverter<EAppType>
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x00059A34 File Offset: 0x00057C34
		public override EAppType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAppType.DEVELOPMENT;
			}
			return EAppTypeExtensions.FromString(@string);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00059A58 File Offset: 0x00057C58
		public override void Write(Utf8JsonWriter writer, EAppType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
