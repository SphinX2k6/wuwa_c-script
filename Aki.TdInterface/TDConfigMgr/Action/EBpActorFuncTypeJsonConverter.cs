using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002533 RID: 9523
	public class EBpActorFuncTypeJsonConverter : JsonConverter<EBpActorFuncType>
	{
		// Token: 0x0600CEC1 RID: 52929 RVA: 0x001DF974 File Offset: 0x001DDB74
		public override EBpActorFuncType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBpActorFuncType.CarPaintChange;
			}
			return EBpActorFuncTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CEC2 RID: 52930 RVA: 0x001DF998 File Offset: 0x001DDB98
		public override void Write(Utf8JsonWriter writer, EBpActorFuncType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
