using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B6 RID: 9398
	public class EVisualNovelShakeIntensityJsonConverter : JsonConverter<EVisualNovelShakeIntensity>
	{
		// Token: 0x0600CBB3 RID: 52147 RVA: 0x001DFEFC File Offset: 0x001DE0FC
		public override EVisualNovelShakeIntensity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelShakeIntensity.Weak;
			}
			return EVisualNovelShakeIntensityExtensions.FromString(@string);
		}

		// Token: 0x0600CBB4 RID: 52148 RVA: 0x001DFF20 File Offset: 0x001DE120
		public override void Write(Utf8JsonWriter writer, EVisualNovelShakeIntensity value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
