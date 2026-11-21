using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002591 RID: 9617
	public class EEnterOrbitalCameraTypeJsonConverter : JsonConverter<EEnterOrbitalCameraType>
	{
		// Token: 0x0600D068 RID: 53352 RVA: 0x001E3044 File Offset: 0x001E1244
		public override EEnterOrbitalCameraType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnterOrbitalCameraType.ControlByMove;
			}
			return EEnterOrbitalCameraTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x001E3068 File Offset: 0x001E1268
		public override void Write(Utf8JsonWriter writer, EEnterOrbitalCameraType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
