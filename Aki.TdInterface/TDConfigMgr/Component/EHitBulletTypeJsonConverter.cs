using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000961 RID: 2401
	public class EHitBulletTypeJsonConverter : JsonConverter<EHitBulletType>
	{
		// Token: 0x060035E7 RID: 13799 RVA: 0x0008C6E8 File Offset: 0x0008A8E8
		public override EHitBulletType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHitBulletType.OnlyDropAttack;
			}
			return EHitBulletTypeExtensions.FromString(@string);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0008C70C File Offset: 0x0008A90C
		public override void Write(Utf8JsonWriter writer, EHitBulletType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
