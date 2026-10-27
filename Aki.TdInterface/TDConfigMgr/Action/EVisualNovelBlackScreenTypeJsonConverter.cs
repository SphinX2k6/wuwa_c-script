using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A6 RID: 9382
	public class EVisualNovelBlackScreenTypeJsonConverter : JsonConverter<EVisualNovelBlackScreenType>
	{
		// Token: 0x0600CB6B RID: 52075 RVA: 0x001DF188 File Offset: 0x001DD388
		public override EVisualNovelBlackScreenType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelBlackScreenType.Black;
			}
			return EVisualNovelBlackScreenTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x001DF1AC File Offset: 0x001DD3AC
		public override void Write(Utf8JsonWriter writer, EVisualNovelBlackScreenType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
