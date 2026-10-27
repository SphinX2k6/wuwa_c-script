using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000945 RID: 2373
	public class EFanGearTypeJsonConverter : JsonConverter<EFanGearType>
	{
		// Token: 0x06003569 RID: 13673 RVA: 0x0008B80C File Offset: 0x00089A0C
		public override EFanGearType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFanGearType.ReboundPlateGear;
			}
			return EFanGearTypeExtensions.FromString(@string);
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x0008B830 File Offset: 0x00089A30
		public override void Write(Utf8JsonWriter writer, EFanGearType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
