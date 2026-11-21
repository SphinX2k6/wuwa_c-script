using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000280 RID: 640
	public class EAppTypeJsonConverter : JsonConverter<EAppType>
	{
		// Token: 0x06000FAA RID: 4010 RVA: 0x0005C9D8 File Offset: 0x0005ABD8
		public override EAppType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAppType.DEVELOPMENT;
			}
			return EAppTypeExtensions.FromString(@string);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0005C9FC File Offset: 0x0005ABFC
		public override void Write(Utf8JsonWriter writer, EAppType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
