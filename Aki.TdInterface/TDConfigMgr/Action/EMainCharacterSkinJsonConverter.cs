using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237C RID: 9084
	public class EMainCharacterSkinJsonConverter : JsonConverter<EMainCharacterSkin>
	{
		// Token: 0x0600C62E RID: 50734 RVA: 0x001D0810 File Offset: 0x001CEA10
		public override EMainCharacterSkin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMainCharacterSkin.Uniform;
			}
			return EMainCharacterSkinExtensions.FromString(@string);
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x001D0834 File Offset: 0x001CEA34
		public override void Write(Utf8JsonWriter writer, EMainCharacterSkin value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
