using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A7 RID: 9639
	public class EFadeBackgroundTypeJsonConverter : JsonConverter<EFadeBackgroundType>
	{
		// Token: 0x0600D0CB RID: 53451 RVA: 0x001E4194 File Offset: 0x001E2394
		public override EFadeBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundType.Spine;
			}
			return EFadeBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0CC RID: 53452 RVA: 0x001E41B8 File Offset: 0x001E23B8
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
