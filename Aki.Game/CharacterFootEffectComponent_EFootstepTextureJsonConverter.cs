using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002AC9 RID: 10953
public class CharacterFootEffectComponent_EFootstepTextureJsonConverter : JsonConverter<CharacterFootEffectComponent.EFootstepTexture>
{
	// Token: 0x0601BCCA RID: 113866 RVA: 0x0088EB5C File Offset: 0x0088CD5C
	public override CharacterFootEffectComponent.EFootstepTexture Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		return CharacterFootEffectComponent_EFootstepTextureExtensions.FromString(@string);
	}

	// Token: 0x0601BCCB RID: 113867 RVA: 0x0088EB80 File Offset: 0x0088CD80
	public override void Write(Utf8JsonWriter writer, CharacterFootEffectComponent.EFootstepTexture value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
