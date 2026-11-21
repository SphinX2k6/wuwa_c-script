using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ABC RID: 2748
	public class ERewardDropTypeJsonConverter : JsonConverter<ERewardDropType>
	{
		// Token: 0x06003C62 RID: 15458 RVA: 0x0009AFB0 File Offset: 0x000991B0
		public override ERewardDropType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERewardDropType.Death;
			}
			return ERewardDropTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x0009AFD4 File Offset: 0x000991D4
		public override void Write(Utf8JsonWriter writer, ERewardDropType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
