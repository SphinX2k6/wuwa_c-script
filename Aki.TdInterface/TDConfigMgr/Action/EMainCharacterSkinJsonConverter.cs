using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002605 RID: 9733
	public class EMainCharacterSkinJsonConverter : JsonConverter<EMainCharacterSkin>
	{
		// Token: 0x0600D272 RID: 53874 RVA: 0x001E97E4 File Offset: 0x001E79E4
		public override EMainCharacterSkin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMainCharacterSkin.Uniform;
			}
			return EMainCharacterSkinExtensions.FromString(@string);
		}

		// Token: 0x0600D273 RID: 53875 RVA: 0x001E9808 File Offset: 0x001E7A08
		public override void Write(Utf8JsonWriter writer, EMainCharacterSkin value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
