using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002717 RID: 10007
	public class ETimeStampTypeJsonConverter : JsonConverter<ETimeStampType>
	{
		// Token: 0x0600D743 RID: 55107 RVA: 0x001F72E8 File Offset: 0x001F54E8
		public override ETimeStampType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeStampType.DungeonBegin;
			}
			return ETimeStampTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D744 RID: 55108 RVA: 0x001F730C File Offset: 0x001F550C
		public override void Write(Utf8JsonWriter writer, ETimeStampType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
