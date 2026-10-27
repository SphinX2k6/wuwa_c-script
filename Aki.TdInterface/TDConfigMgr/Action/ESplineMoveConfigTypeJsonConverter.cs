using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002426 RID: 9254
	public class ESplineMoveConfigTypeJsonConverter : JsonConverter<ESplineMoveConfigType>
	{
		// Token: 0x0600C92B RID: 51499 RVA: 0x001D74F0 File Offset: 0x001D56F0
		public override ESplineMoveConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveConfigType.Open;
			}
			return ESplineMoveConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C92C RID: 51500 RVA: 0x001D7514 File Offset: 0x001D5714
		public override void Write(Utf8JsonWriter writer, ESplineMoveConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
