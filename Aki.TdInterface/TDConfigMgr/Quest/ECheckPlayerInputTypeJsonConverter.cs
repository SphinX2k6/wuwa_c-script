using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200136B RID: 4971
	public class ECheckPlayerInputTypeJsonConverter : JsonConverter<ECheckPlayerInputType>
	{
		// Token: 0x06006FBD RID: 28605 RVA: 0x0010902C File Offset: 0x0010722C
		public override ECheckPlayerInputType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECheckPlayerInputType.PressButton;
			}
			return ECheckPlayerInputTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00109050 File Offset: 0x00107250
		public override void Write(Utf8JsonWriter writer, ECheckPlayerInputType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
