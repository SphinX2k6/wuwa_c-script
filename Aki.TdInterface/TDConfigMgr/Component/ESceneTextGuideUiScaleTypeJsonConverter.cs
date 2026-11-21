using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ACA RID: 2762
	public class ESceneTextGuideUiScaleTypeJsonConverter : JsonConverter<ESceneTextGuideUiScaleType>
	{
		// Token: 0x06003CA1 RID: 15521 RVA: 0x0009B65C File Offset: 0x0009985C
		public override ESceneTextGuideUiScaleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneTextGuideUiScaleType.FarBigNearSmall;
			}
			return ESceneTextGuideUiScaleTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x0009B680 File Offset: 0x00099880
		public override void Write(Utf8JsonWriter writer, ESceneTextGuideUiScaleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
