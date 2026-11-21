using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D2 RID: 2514
	public class EDollGrabShowcaseBelongTypeJsonConverter : JsonConverter<EDollGrabShowcaseBelongType>
	{
		// Token: 0x06003845 RID: 14405 RVA: 0x00091E48 File Offset: 0x00090048
		public override EDollGrabShowcaseBelongType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDollGrabShowcaseBelongType.LandOfXuanfang;
			}
			return EDollGrabShowcaseBelongTypeExtensions.FromString(@string);
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00091E6C File Offset: 0x0009006C
		public override void Write(Utf8JsonWriter writer, EDollGrabShowcaseBelongType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
