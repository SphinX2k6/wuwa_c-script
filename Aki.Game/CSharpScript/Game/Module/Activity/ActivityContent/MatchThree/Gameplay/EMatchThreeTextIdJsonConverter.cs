using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005450 RID: 21584
	public class EMatchThreeTextIdJsonConverter : JsonConverter<EMatchThreeTextId>
	{
		// Token: 0x0603590A RID: 219402 RVA: 0x00EF6268 File Offset: 0x00EF4468
		public override EMatchThreeTextId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeTextId.RemainingTurns;
			}
			return EMatchThreeTextIdExtensions.FromString(@string);
		}

		// Token: 0x0603590B RID: 219403 RVA: 0x00EF628C File Offset: 0x00EF448C
		public override void Write(Utf8JsonWriter writer, EMatchThreeTextId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
