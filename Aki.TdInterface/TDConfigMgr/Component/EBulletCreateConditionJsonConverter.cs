using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B0 RID: 2480
	public class EBulletCreateConditionJsonConverter : JsonConverter<EBulletCreateCondition>
	{
		// Token: 0x060037AC RID: 14252 RVA: 0x0008D290 File Offset: 0x0008B490
		public override EBulletCreateCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBulletCreateCondition.OnHit;
			}
			return EBulletCreateConditionExtensions.FromString(@string);
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0008D2B4 File Offset: 0x0008B4B4
		public override void Write(Utf8JsonWriter writer, EBulletCreateCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
