using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002565 RID: 9573
	public class ECustomScreenTypeJsonConverter : JsonConverter<ECustomScreenType>
	{
		// Token: 0x0600CFA2 RID: 53154 RVA: 0x001E1850 File Offset: 0x001DFA50
		public override ECustomScreenType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECustomScreenType.Spine;
			}
			return ECustomScreenTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x001E1874 File Offset: 0x001DFA74
		public override void Write(Utf8JsonWriter writer, ECustomScreenType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
