using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A05 RID: 2565
	public class ESceneTextGuideUiScaleTypeJsonConverter : JsonConverter<ESceneTextGuideUiScaleType>
	{
		// Token: 0x060038C9 RID: 14537 RVA: 0x00092D6C File Offset: 0x00090F6C
		public override ESceneTextGuideUiScaleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneTextGuideUiScaleType.FarBigNearSmall;
			}
			return ESceneTextGuideUiScaleTypeExtensions.FromString(@string);
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x00092D90 File Offset: 0x00090F90
		public override void Write(Utf8JsonWriter writer, ESceneTextGuideUiScaleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
