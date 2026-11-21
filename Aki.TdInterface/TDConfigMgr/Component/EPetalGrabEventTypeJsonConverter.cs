using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A90 RID: 2704
	public class EPetalGrabEventTypeJsonConverter : JsonConverter<EPetalGrabEventType>
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x00099690 File Offset: 0x00097890
		public override EPetalGrabEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPetalGrabEventType.Grabbed;
			}
			return EPetalGrabEventTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x000996B4 File Offset: 0x000978B4
		public override void Write(Utf8JsonWriter writer, EPetalGrabEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
