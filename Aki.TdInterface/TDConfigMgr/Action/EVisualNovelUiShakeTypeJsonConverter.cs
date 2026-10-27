using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BC RID: 9404
	public class EVisualNovelUiShakeTypeJsonConverter : JsonConverter<EVisualNovelUiShakeType>
	{
		// Token: 0x0600CBCE RID: 52174 RVA: 0x001E0244 File Offset: 0x001DE444
		public override EVisualNovelUiShakeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelUiShakeType.Random;
			}
			return EVisualNovelUiShakeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBCF RID: 52175 RVA: 0x001E0268 File Offset: 0x001DE468
		public override void Write(Utf8JsonWriter writer, EVisualNovelUiShakeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
