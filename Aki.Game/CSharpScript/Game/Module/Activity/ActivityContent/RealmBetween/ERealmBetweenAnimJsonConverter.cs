using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200521B RID: 21019
	public class ERealmBetweenAnimJsonConverter : JsonConverter<ERealmBetweenAnim>
	{
		// Token: 0x060344E5 RID: 214245 RVA: 0x00EA1E84 File Offset: 0x00EA0084
		public override ERealmBetweenAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERealmBetweenAnim.AniOpen;
			}
			return ERealmBetweenAnimExtensions.FromString(@string);
		}

		// Token: 0x060344E6 RID: 214246 RVA: 0x00EA1EA8 File Offset: 0x00EA00A8
		public override void Write(Utf8JsonWriter writer, ERealmBetweenAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
