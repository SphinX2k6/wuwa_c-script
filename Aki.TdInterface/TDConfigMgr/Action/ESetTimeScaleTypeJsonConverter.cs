using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002412 RID: 9234
	public class ESetTimeScaleTypeJsonConverter : JsonConverter<ESetTimeScaleType>
	{
		// Token: 0x0600C8D1 RID: 51409 RVA: 0x001D6174 File Offset: 0x001D4374
		public override ESetTimeScaleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetTimeScaleType.Open;
			}
			return ESetTimeScaleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x001D6198 File Offset: 0x001D4398
		public override void Write(Utf8JsonWriter writer, ESetTimeScaleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
