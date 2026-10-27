using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096B RID: 2411
	public class EIndependentSystemRewardTypeJsonConverter : JsonConverter<EIndependentSystemRewardType>
	{
		// Token: 0x06003614 RID: 13844 RVA: 0x0008D2BC File Offset: 0x0008B4BC
		public override EIndependentSystemRewardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EIndependentSystemRewardType.DarkTide;
			}
			return EIndependentSystemRewardTypeExtensions.FromString(@string);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
		public override void Write(Utf8JsonWriter writer, EIndependentSystemRewardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
