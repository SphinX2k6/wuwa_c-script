using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000250 RID: 592
	public class EResTypeJsonConverter : JsonConverter<EResType>
	{
		// Token: 0x06000F04 RID: 3844 RVA: 0x000595A4 File Offset: 0x000577A4
		public override EResType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResType.Launcher;
			}
			return EResTypeExtensions.FromString(@string);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000595C8 File Offset: 0x000577C8
		public override void Write(Utf8JsonWriter writer, EResType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
