using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AE RID: 9390
	public class EVisualNovelOptionGroupTypeJsonConverter : JsonConverter<EVisualNovelOptionGroupType>
	{
		// Token: 0x0600CB8F RID: 52111 RVA: 0x001DF628 File Offset: 0x001DD828
		public override EVisualNovelOptionGroupType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelOptionGroupType.SolarSchoolExam;
			}
			return EVisualNovelOptionGroupTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB90 RID: 52112 RVA: 0x001DF64C File Offset: 0x001DD84C
		public override void Write(Utf8JsonWriter writer, EVisualNovelOptionGroupType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
