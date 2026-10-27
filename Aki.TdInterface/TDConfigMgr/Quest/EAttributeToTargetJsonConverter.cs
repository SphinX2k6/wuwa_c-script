using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001227 RID: 4647
	public class EAttributeToTargetJsonConverter : JsonConverter<EAttributeToTarget>
	{
		// Token: 0x06006958 RID: 26968 RVA: 0x000FAFF4 File Offset: 0x000F91F4
		public override EAttributeToTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttributeToTarget.Health;
			}
			return EAttributeToTargetExtensions.FromString(@string);
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x000FB018 File Offset: 0x000F9218
		public override void Write(Utf8JsonWriter writer, EAttributeToTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
