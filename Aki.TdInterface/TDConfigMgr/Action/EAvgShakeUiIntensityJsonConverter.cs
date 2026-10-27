using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B0 RID: 8880
	public class EAvgShakeUiIntensityJsonConverter : JsonConverter<EAvgShakeUiIntensity>
	{
		// Token: 0x0600C298 RID: 49816 RVA: 0x001C6F50 File Offset: 0x001C5150
		public override EAvgShakeUiIntensity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgShakeUiIntensity.Weak;
			}
			return EAvgShakeUiIntensityExtensions.FromString(@string);
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x001C6F74 File Offset: 0x001C5174
		public override void Write(Utf8JsonWriter writer, EAvgShakeUiIntensity value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
