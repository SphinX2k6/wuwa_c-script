using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1F RID: 2591
	public class ESplineTypeJsonConverter : JsonConverter<ESplineType>
	{
		// Token: 0x0600393E RID: 14654 RVA: 0x00093F3C File Offset: 0x0009213C
		public override ESplineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineType.Common;
			}
			return ESplineTypeExtensions.FromString(@string);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00093F60 File Offset: 0x00092160
		public override void Write(Utf8JsonWriter writer, ESplineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
