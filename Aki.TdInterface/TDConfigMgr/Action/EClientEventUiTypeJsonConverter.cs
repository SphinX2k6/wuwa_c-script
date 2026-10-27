using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E2 RID: 8930
	public class EClientEventUiTypeJsonConverter : JsonConverter<EClientEventUiType>
	{
		// Token: 0x0600C379 RID: 50041 RVA: 0x001C8F24 File Offset: 0x001C7124
		public override EClientEventUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventUiType.PlayPiano;
			}
			return EClientEventUiTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x001C8F48 File Offset: 0x001C7148
		public override void Write(Utf8JsonWriter writer, EClientEventUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
