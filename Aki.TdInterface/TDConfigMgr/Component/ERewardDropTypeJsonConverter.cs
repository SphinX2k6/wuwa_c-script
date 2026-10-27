using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F7 RID: 2551
	public class ERewardDropTypeJsonConverter : JsonConverter<ERewardDropType>
	{
		// Token: 0x0600388A RID: 14474 RVA: 0x000926C0 File Offset: 0x000908C0
		public override ERewardDropType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERewardDropType.Death;
			}
			return ERewardDropTypeExtensions.FromString(@string);
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x000926E4 File Offset: 0x000908E4
		public override void Write(Utf8JsonWriter writer, ERewardDropType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
