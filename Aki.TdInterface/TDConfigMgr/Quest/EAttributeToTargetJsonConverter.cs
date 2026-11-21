using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001363 RID: 4963
	public class EAttributeToTargetJsonConverter : JsonConverter<EAttributeToTarget>
	{
		// Token: 0x06006F99 RID: 28569 RVA: 0x00108900 File Offset: 0x00106B00
		public override EAttributeToTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttributeToTarget.Health;
			}
			return EAttributeToTargetExtensions.FromString(@string);
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x00108924 File Offset: 0x00106B24
		public override void Write(Utf8JsonWriter writer, EAttributeToTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
