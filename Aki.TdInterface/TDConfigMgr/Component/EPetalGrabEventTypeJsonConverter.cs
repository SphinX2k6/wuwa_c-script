using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CB RID: 2507
	public class EPetalGrabEventTypeJsonConverter : JsonConverter<EPetalGrabEventType>
	{
		// Token: 0x060037C4 RID: 14276 RVA: 0x00090DD0 File Offset: 0x0008EFD0
		public override EPetalGrabEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPetalGrabEventType.Grabbed;
			}
			return EPetalGrabEventTypeExtensions.FromString(@string);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00090DF4 File Offset: 0x0008EFF4
		public override void Write(Utf8JsonWriter writer, EPetalGrabEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
