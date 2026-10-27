using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007B RID: 123
	public class ESpecialValueJsonConverter : JsonConverter<ESpecialValue>
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00011790 File Offset: 0x0000F990
		public override ESpecialValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialValue.Undefined;
			}
			return ESpecialValueExtensions.FromString(@string);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000117B4 File Offset: 0x0000F9B4
		public override void Write(Utf8JsonWriter writer, ESpecialValue value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
