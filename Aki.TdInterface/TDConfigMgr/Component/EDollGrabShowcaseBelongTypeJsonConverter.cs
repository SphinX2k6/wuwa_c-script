using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000925 RID: 2341
	public class EDollGrabShowcaseBelongTypeJsonConverter : JsonConverter<EDollGrabShowcaseBelongType>
	{
		// Token: 0x060034D9 RID: 13529 RVA: 0x0008A2C8 File Offset: 0x000884C8
		public override EDollGrabShowcaseBelongType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDollGrabShowcaseBelongType.LandOfXuanfang;
			}
			return EDollGrabShowcaseBelongTypeExtensions.FromString(@string);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x0008A2EC File Offset: 0x000884EC
		public override void Write(Utf8JsonWriter writer, EDollGrabShowcaseBelongType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
