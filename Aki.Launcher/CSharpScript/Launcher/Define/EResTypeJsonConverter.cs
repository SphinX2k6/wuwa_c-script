using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024B RID: 587
	public class EResTypeJsonConverter : JsonConverter<EResType>
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x00056A60 File Offset: 0x00054C60
		public override EResType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResType.Launcher;
			}
			return EResTypeExtensions.FromString(@string);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00056A84 File Offset: 0x00054C84
		public override void Write(Utf8JsonWriter writer, EResType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
