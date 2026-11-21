using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200007E RID: 126
	public class ESpecialValueJsonConverter : JsonConverter<ESpecialValue>
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00012614 File Offset: 0x00010814
		public override ESpecialValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialValue.Undefined;
			}
			return ESpecialValueExtensions.FromString(@string);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00012638 File Offset: 0x00010838
		public override void Write(Utf8JsonWriter writer, ESpecialValue value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
