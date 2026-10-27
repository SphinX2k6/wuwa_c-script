using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200667B RID: 26235
	public class ESpineAnimationJsonConverter : JsonConverter<ESpineAnimation>
	{
		// Token: 0x06041BDC RID: 269276 RVA: 0x00FF2740 File Offset: 0x00FF0940
		public override ESpineAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpineAnimation.Die;
			}
			return ESpineAnimationExtensions.FromString(@string);
		}

		// Token: 0x06041BDD RID: 269277 RVA: 0x00FF2764 File Offset: 0x00FF0964
		public override void Write(Utf8JsonWriter writer, ESpineAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
