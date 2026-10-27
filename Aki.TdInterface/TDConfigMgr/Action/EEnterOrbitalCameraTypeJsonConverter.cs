using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002322 RID: 8994
	public class EEnterOrbitalCameraTypeJsonConverter : JsonConverter<EEnterOrbitalCameraType>
	{
		// Token: 0x0600C499 RID: 50329 RVA: 0x001CB17C File Offset: 0x001C937C
		public override EEnterOrbitalCameraType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnterOrbitalCameraType.ControlByMove;
			}
			return EEnterOrbitalCameraTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x001CB1A0 File Offset: 0x001C93A0
		public override void Write(Utf8JsonWriter writer, EEnterOrbitalCameraType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
