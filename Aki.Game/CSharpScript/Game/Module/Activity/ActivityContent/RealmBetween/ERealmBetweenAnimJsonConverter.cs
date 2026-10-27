using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200629D RID: 25245
	public class ERealmBetweenAnimJsonConverter : JsonConverter<ERealmBetweenAnim>
	{
		// Token: 0x0603F824 RID: 260132 RVA: 0x00F5AF28 File Offset: 0x00F59128
		public override ERealmBetweenAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERealmBetweenAnim.AniOpen;
			}
			return ERealmBetweenAnimExtensions.FromString(@string);
		}

		// Token: 0x0603F825 RID: 260133 RVA: 0x00F5AF4C File Offset: 0x00F5914C
		public override void Write(Utf8JsonWriter writer, ERealmBetweenAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
