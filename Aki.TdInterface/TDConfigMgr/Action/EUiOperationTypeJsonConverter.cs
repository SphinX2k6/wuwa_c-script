using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002492 RID: 9362
	public class EUiOperationTypeJsonConverter : JsonConverter<EUiOperationType>
	{
		// Token: 0x0600CB11 RID: 51985 RVA: 0x001DE5CC File Offset: 0x001DC7CC
		public override EUiOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUiOperationType.Enable;
			}
			return EUiOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x001DE5F0 File Offset: 0x001DC7F0
		public override void Write(Utf8JsonWriter writer, EUiOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
