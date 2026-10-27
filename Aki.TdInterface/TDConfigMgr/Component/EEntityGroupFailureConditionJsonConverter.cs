using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000939 RID: 2361
	public class EEntityGroupFailureConditionJsonConverter : JsonConverter<EEntityGroupFailureCondition>
	{
		// Token: 0x06003533 RID: 13619 RVA: 0x0008ADE4 File Offset: 0x00088FE4
		public override EEntityGroupFailureCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityGroupFailureCondition.SequentialState;
			}
			return EEntityGroupFailureConditionExtensions.FromString(@string);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0008AE08 File Offset: 0x00089008
		public override void Write(Utf8JsonWriter writer, EEntityGroupFailureCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
