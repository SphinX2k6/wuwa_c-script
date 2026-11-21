using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1E RID: 2590
	public class EIndependentSystemRewardTypeJsonConverter : JsonConverter<EIndependentSystemRewardType>
	{
		// Token: 0x0600399B RID: 14747 RVA: 0x00095228 File Offset: 0x00093428
		public override EIndependentSystemRewardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EIndependentSystemRewardType.DarkTide;
			}
			return EIndependentSystemRewardTypeExtensions.FromString(@string);
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0009524C File Offset: 0x0009344C
		public override void Write(Utf8JsonWriter writer, EIndependentSystemRewardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
