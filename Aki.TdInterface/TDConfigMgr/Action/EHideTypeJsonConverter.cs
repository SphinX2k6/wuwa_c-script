using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002354 RID: 9044
	public class EHideTypeJsonConverter : JsonConverter<EHideType>
	{
		// Token: 0x0600C57A RID: 50554 RVA: 0x001CD2A8 File Offset: 0x001CB4A8
		public override EHideType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHideType.WorldMonsterAndMonsterTreasure;
			}
			return EHideTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C57B RID: 50555 RVA: 0x001CD2CC File Offset: 0x001CB4CC
		public override void Write(Utf8JsonWriter writer, EHideType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
