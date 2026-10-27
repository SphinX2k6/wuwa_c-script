using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230E RID: 8974
	public class EDynamicEntityTypeJsonConverter : JsonConverter<EDynamicEntityType>
	{
		// Token: 0x0600C43F RID: 50239 RVA: 0x001CA630 File Offset: 0x001C8830
		public override EDynamicEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicEntityType.VisionDisplay;
			}
			return EDynamicEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C440 RID: 50240 RVA: 0x001CA654 File Offset: 0x001C8854
		public override void Write(Utf8JsonWriter writer, EDynamicEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
