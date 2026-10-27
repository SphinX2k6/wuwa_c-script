using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240E RID: 9230
	public class ESetSpineAnimationJsonConverter : JsonConverter<ESetSpineAnimation>
	{
		// Token: 0x0600C8BF RID: 51391 RVA: 0x001D5F4C File Offset: 0x001D414C
		public override ESetSpineAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetSpineAnimation.Play;
			}
			return ESetSpineAnimationExtensions.FromString(@string);
		}

		// Token: 0x0600C8C0 RID: 51392 RVA: 0x001D5F70 File Offset: 0x001D4170
		public override void Write(Utf8JsonWriter writer, ESetSpineAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
