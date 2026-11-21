using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AA RID: 2474
	public class EBeamLayoutTypeJsonConverter : JsonConverter<EBeamLayoutType>
	{
		// Token: 0x06003791 RID: 14225 RVA: 0x0008CEA4 File Offset: 0x0008B0A4
		public override EBeamLayoutType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBeamLayoutType.BeamWall;
			}
			return EBeamLayoutTypeExtensions.FromString(@string);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		public override void Write(Utf8JsonWriter writer, EBeamLayoutType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
