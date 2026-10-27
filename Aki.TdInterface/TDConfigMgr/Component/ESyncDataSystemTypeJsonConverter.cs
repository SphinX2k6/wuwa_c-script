using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A29 RID: 2601
	public class ESyncDataSystemTypeJsonConverter : JsonConverter<ESyncDataSystemType>
	{
		// Token: 0x0600396B RID: 14699 RVA: 0x000944AC File Offset: 0x000926AC
		public override ESyncDataSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESyncDataSystemType.MotorRacing;
			}
			return ESyncDataSystemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x000944D0 File Offset: 0x000926D0
		public override void Write(Utf8JsonWriter writer, ESyncDataSystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
