using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000907 RID: 2311
	public class EBulletCreateConditionJsonConverter : JsonConverter<EBulletCreateCondition>
	{
		// Token: 0x06003452 RID: 13394 RVA: 0x00085A20 File Offset: 0x00083C20
		public override EBulletCreateCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBulletCreateCondition.OnHit;
			}
			return EBulletCreateConditionExtensions.FromString(@string);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00085A44 File Offset: 0x00083C44
		public override void Write(Utf8JsonWriter writer, EBulletCreateCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
