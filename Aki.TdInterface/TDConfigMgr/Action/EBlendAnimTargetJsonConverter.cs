using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C0 RID: 8896
	public class EBlendAnimTargetJsonConverter : JsonConverter<EBlendAnimTarget>
	{
		// Token: 0x0600C2E0 RID: 49888 RVA: 0x001C7944 File Offset: 0x001C5B44
		public override EBlendAnimTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBlendAnimTarget.Player;
			}
			return EBlendAnimTargetExtensions.FromString(@string);
		}

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x001C7968 File Offset: 0x001C5B68
		public override void Write(Utf8JsonWriter writer, EBlendAnimTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
