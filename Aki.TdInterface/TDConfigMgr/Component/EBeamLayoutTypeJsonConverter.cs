using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000901 RID: 2305
	public class EBeamLayoutTypeJsonConverter : JsonConverter<EBeamLayoutType>
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x00085634 File Offset: 0x00083834
		public override EBeamLayoutType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBeamLayoutType.BeamWall;
			}
			return EBeamLayoutTypeExtensions.FromString(@string);
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00085658 File Offset: 0x00083858
		public override void Write(Utf8JsonWriter writer, EBeamLayoutType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
