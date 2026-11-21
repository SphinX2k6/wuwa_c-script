using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002521 RID: 9505
	public class EAvgTalkItemSubTypeJsonConverter : JsonConverter<EAvgTalkItemSubType>
	{
		// Token: 0x0600CE70 RID: 52848 RVA: 0x001DEF3C File Offset: 0x001DD13C
		public override EAvgTalkItemSubType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgTalkItemSubType.Dialog;
			}
			return EAvgTalkItemSubTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE71 RID: 52849 RVA: 0x001DEF60 File Offset: 0x001DD160
		public override void Write(Utf8JsonWriter writer, EAvgTalkItemSubType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
