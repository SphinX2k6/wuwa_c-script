using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B04 RID: 2820
	public class ETrackControlModeJsonConverter : JsonConverter<ETrackControlMode>
	{
		// Token: 0x06003DA6 RID: 15782 RVA: 0x0009DAB4 File Offset: 0x0009BCB4
		public override ETrackControlMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackControlMode.Sequence;
			}
			return ETrackControlModeExtensions.FromString(@string);
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		public override void Write(Utf8JsonWriter writer, ETrackControlMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
