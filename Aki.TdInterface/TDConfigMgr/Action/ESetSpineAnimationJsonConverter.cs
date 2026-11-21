using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026AD RID: 9901
	public class ESetSpineAnimationJsonConverter : JsonConverter<ESetSpineAnimation>
	{
		// Token: 0x0600D566 RID: 54630 RVA: 0x001EFB48 File Offset: 0x001EDD48
		public override ESetSpineAnimation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetSpineAnimation.Play;
			}
			return ESetSpineAnimationExtensions.FromString(@string);
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x001EFB6C File Offset: 0x001EDD6C
		public override void Write(Utf8JsonWriter writer, ESetSpineAnimation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
