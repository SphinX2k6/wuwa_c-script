using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F1 RID: 241
	public class EResourceQualityTierTextIdJsonConverter : JsonConverter<EResourceQualityTierTextId>
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
		public override EResourceQualityTierTextId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResourceQualityTierTextId.Smooth;
			}
			return EResourceQualityTierTextIdExtensions.FromString(@string);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0003CEEC File Offset: 0x0003B0EC
		public override void Write(Utf8JsonWriter writer, EResourceQualityTierTextId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
