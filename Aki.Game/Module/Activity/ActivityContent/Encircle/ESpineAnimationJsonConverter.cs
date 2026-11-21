using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003018 RID: 12312
	public class ESpineAnimationJsonConverter : JsonConverter<ESpineAnimation>
	{
		// Token: 0x0601D377 RID: 119671 RVA: 0x008EB1A8 File Offset: 0x008E93A8
		public override ESpineAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpineAnimation.Die;
			}
			return ESpineAnimationExtensions.FromString(@string);
		}

		// Token: 0x0601D378 RID: 119672 RVA: 0x008EB1CC File Offset: 0x008E93CC
		public override void Write(Utf8JsonWriter writer, ESpineAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
