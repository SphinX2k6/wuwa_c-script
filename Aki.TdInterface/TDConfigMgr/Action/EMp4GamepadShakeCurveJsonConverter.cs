using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002633 RID: 9779
	public class EMp4GamepadShakeCurveJsonConverter : JsonConverter<EMp4GamepadShakeCurve>
	{
		// Token: 0x0600D341 RID: 54081 RVA: 0x001EB3B8 File Offset: 0x001E95B8
		public override EMp4GamepadShakeCurve Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMp4GamepadShakeCurve.Linear;
			}
			return EMp4GamepadShakeCurveExtensions.FromString(@string);
		}

		// Token: 0x0600D342 RID: 54082 RVA: 0x001EB3DC File Offset: 0x001E95DC
		public override void Write(Utf8JsonWriter writer, EMp4GamepadShakeCurve value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
