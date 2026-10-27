using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002428 RID: 9256
	public class ESplineMoveDriveModeJsonConverter : JsonConverter<ESplineMoveDriveMode>
	{
		// Token: 0x0600C934 RID: 51508 RVA: 0x001D7604 File Offset: 0x001D5804
		public override ESplineMoveDriveMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveDriveMode.InputDriven;
			}
			return ESplineMoveDriveModeExtensions.FromString(@string);
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x001D7628 File Offset: 0x001D5828
		public override void Write(Utf8JsonWriter writer, ESplineMoveDriveMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
