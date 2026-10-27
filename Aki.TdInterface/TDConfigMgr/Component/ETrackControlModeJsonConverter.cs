using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3F RID: 2623
	public class ETrackControlModeJsonConverter : JsonConverter<ETrackControlMode>
	{
		// Token: 0x060039CE RID: 14798 RVA: 0x00095180 File Offset: 0x00093380
		public override ETrackControlMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackControlMode.Sequence;
			}
			return ETrackControlModeExtensions.FromString(@string);
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x000951A4 File Offset: 0x000933A4
		public override void Write(Utf8JsonWriter writer, ETrackControlMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
