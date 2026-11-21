using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F5 RID: 245
	public class EResourceQualityTierTextIdJsonConverter : JsonConverter<EResourceQualityTierTextId>
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x0003F268 File Offset: 0x0003D468
		public override EResourceQualityTierTextId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResourceQualityTierTextId.Smooth;
			}
			return EResourceQualityTierTextIdExtensions.FromString(@string);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0003F28C File Offset: 0x0003D48C
		public override void Write(Utf8JsonWriter writer, EResourceQualityTierTextId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
