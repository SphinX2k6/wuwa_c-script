using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A14 RID: 2580
	public class EHitBulletTypeJsonConverter : JsonConverter<EHitBulletType>
	{
		// Token: 0x0600396E RID: 14702 RVA: 0x0009463C File Offset: 0x0009283C
		public override EHitBulletType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHitBulletType.OnlyDropAttack;
			}
			return EHitBulletTypeExtensions.FromString(@string);
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00094660 File Offset: 0x00092860
		public override void Write(Utf8JsonWriter writer, EHitBulletType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
