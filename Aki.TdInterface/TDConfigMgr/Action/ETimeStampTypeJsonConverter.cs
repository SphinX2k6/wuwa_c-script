using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002476 RID: 9334
	public class ETimeStampTypeJsonConverter : JsonConverter<ETimeStampType>
	{
		// Token: 0x0600CA93 RID: 51859 RVA: 0x001DD234 File Offset: 0x001DB434
		public override ETimeStampType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeStampType.DungeonBegin;
			}
			return ETimeStampTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x001DD258 File Offset: 0x001DB458
		public override void Write(Utf8JsonWriter writer, ETimeStampType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
