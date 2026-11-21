using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200252F RID: 9519
	public class EBlendAnimTargetJsonConverter : JsonConverter<EBlendAnimTarget>
	{
		// Token: 0x0600CEAF RID: 52911 RVA: 0x001DF74C File Offset: 0x001DD94C
		public override EBlendAnimTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlendAnimTarget.Player;
			}
			return EBlendAnimTargetExtensions.FromString(@string);
		}

		// Token: 0x0600CEB0 RID: 52912 RVA: 0x001DF770 File Offset: 0x001DD970
		public override void Write(Utf8JsonWriter writer, EBlendAnimTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
