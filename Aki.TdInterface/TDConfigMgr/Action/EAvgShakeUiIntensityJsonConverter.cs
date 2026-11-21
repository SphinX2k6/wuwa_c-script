using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200251F RID: 9503
	public class EAvgShakeUiIntensityJsonConverter : JsonConverter<EAvgShakeUiIntensity>
	{
		// Token: 0x0600CE67 RID: 52839 RVA: 0x001DED58 File Offset: 0x001DCF58
		public override EAvgShakeUiIntensity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgShakeUiIntensity.Weak;
			}
			return EAvgShakeUiIntensityExtensions.FromString(@string);
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x001DED7C File Offset: 0x001DCF7C
		public override void Write(Utf8JsonWriter writer, EAvgShakeUiIntensity value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
