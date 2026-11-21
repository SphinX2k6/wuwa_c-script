using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E6 RID: 2534
	public class EEntityGroupFailureConditionJsonConverter : JsonConverter<EEntityGroupFailureCondition>
	{
		// Token: 0x0600389F RID: 14495 RVA: 0x00092964 File Offset: 0x00090B64
		public override EEntityGroupFailureCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityGroupFailureCondition.SequentialState;
			}
			return EEntityGroupFailureConditionExtensions.FromString(@string);
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00092988 File Offset: 0x00090B88
		public override void Write(Utf8JsonWriter writer, EEntityGroupFailureCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
