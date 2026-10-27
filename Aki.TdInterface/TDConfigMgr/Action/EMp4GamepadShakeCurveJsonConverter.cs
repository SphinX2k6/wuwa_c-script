using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A8 RID: 9128
	public class EMp4GamepadShakeCurveJsonConverter : JsonConverter<EMp4GamepadShakeCurve>
	{
		// Token: 0x0600C6F4 RID: 50932 RVA: 0x001D2218 File Offset: 0x001D0418
		public override EMp4GamepadShakeCurve Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMp4GamepadShakeCurve.Linear;
			}
			return EMp4GamepadShakeCurveExtensions.FromString(@string);
		}

		// Token: 0x0600C6F5 RID: 50933 RVA: 0x001D223C File Offset: 0x001D043C
		public override void Write(Utf8JsonWriter writer, EMp4GamepadShakeCurve value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
