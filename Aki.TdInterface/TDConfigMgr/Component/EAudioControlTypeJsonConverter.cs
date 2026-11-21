using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A4 RID: 2468
	public class EAudioControlTypeJsonConverter : JsonConverter<EAudioControlType>
	{
		// Token: 0x06003776 RID: 14198 RVA: 0x0008CB5C File Offset: 0x0008AD5C
		public override EAudioControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioControlType.Gramophone;
			}
			return EAudioControlTypeExtensions.FromString(@string);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x0008CB80 File Offset: 0x0008AD80
		public override void Write(Utf8JsonWriter writer, EAudioControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
