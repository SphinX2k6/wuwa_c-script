using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002551 RID: 9553
	public class EClientEventUiTypeJsonConverter : JsonConverter<EClientEventUiType>
	{
		// Token: 0x0600CF48 RID: 53064 RVA: 0x001E0D2C File Offset: 0x001DEF2C
		public override EClientEventUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventUiType.PlayPiano;
			}
			return EClientEventUiTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x001E0D50 File Offset: 0x001DEF50
		public override void Write(Utf8JsonWriter writer, EClientEventUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
