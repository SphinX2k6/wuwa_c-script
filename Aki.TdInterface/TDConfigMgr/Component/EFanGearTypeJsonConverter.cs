using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F4 RID: 2548
	public class EFanGearTypeJsonConverter : JsonConverter<EFanGearType>
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x000934C4 File Offset: 0x000916C4
		public override EFanGearType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFanGearType.ReboundPlateGear;
			}
			return EFanGearTypeExtensions.FromString(@string);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x000934E8 File Offset: 0x000916E8
		public override void Write(Utf8JsonWriter writer, EFanGearType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
