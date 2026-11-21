using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200257D RID: 9597
	public class EDynamicEntityTypeJsonConverter : JsonConverter<EDynamicEntityType>
	{
		// Token: 0x0600D00E RID: 53262 RVA: 0x001E24F8 File Offset: 0x001E06F8
		public override EDynamicEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicEntityType.VisionDisplay;
			}
			return EDynamicEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x001E251C File Offset: 0x001E071C
		public override void Write(Utf8JsonWriter writer, EDynamicEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
