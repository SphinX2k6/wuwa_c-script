using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002727 RID: 10023
	public class ETransitionPopupStyleTypeJsonConverter : JsonConverter<ETransitionPopupStyleType>
	{
		// Token: 0x0600D78B RID: 55179 RVA: 0x001F7C38 File Offset: 0x001F5E38
		public override ETransitionPopupStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETransitionPopupStyleType.LeftTopTip;
			}
			return ETransitionPopupStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D78C RID: 55180 RVA: 0x001F7C5C File Offset: 0x001F5E5C
		public override void Write(Utf8JsonWriter writer, ETransitionPopupStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
