using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02003554 RID: 13652
public class CharacterFootEffectComponent_EFootstepTextureJsonConverter : JsonConverter<CharacterFootEffectComponent.EFootstepTexture>
{
	// Token: 0x0601DFA2 RID: 122786 RVA: 0x00866F98 File Offset: 0x00865198
	public override CharacterFootEffectComponent.EFootstepTexture Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return CharacterFootEffectComponent.EFootstepTexture.DirtSurface;
		}
		return CharacterFootEffectComponent_EFootstepTextureExtensions.FromString(@string);
	}

	// Token: 0x0601DFA3 RID: 122787 RVA: 0x00866FBC File Offset: 0x008651BC
	public override void Write(Utf8JsonWriter writer, CharacterFootEffectComponent.EFootstepTexture value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
