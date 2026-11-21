using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B96 RID: 15254
	public class ESkinSpineAnimationJsonConverter : JsonConverter<ESkinSpineAnimation>
	{
		// Token: 0x0602716D RID: 160109 RVA: 0x00AEFC18 File Offset: 0x00AEDE18
		public override ESkinSpineAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkinSpineAnimation.Idle;
			}
			return ESkinSpineAnimationExtensions.FromString(@string);
		}

		// Token: 0x0602716E RID: 160110 RVA: 0x00AEFC3C File Offset: 0x00AEDE3C
		public override void Write(Utf8JsonWriter writer, ESkinSpineAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
