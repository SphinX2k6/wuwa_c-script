using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002418 RID: 9240
	public class ESimpleGameplayTypeJsonConverter : JsonConverter<ESimpleGameplayType>
	{
		// Token: 0x0600C8EC RID: 51436 RVA: 0x001D6D84 File Offset: 0x001D4F84
		public override ESimpleGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESimpleGameplayType.Cipher;
			}
			return ESimpleGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x001D6DA8 File Offset: 0x001D4FA8
		public override void Write(Utf8JsonWriter writer, ESimpleGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
