using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000951 RID: 2385
	public class EGearHitAffectTypeJsonConverter : JsonConverter<EGearHitAffectType>
	{
		// Token: 0x0600359F RID: 13727 RVA: 0x0008BDDC File Offset: 0x00089FDC
		public override EGearHitAffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGearHitAffectType.ChangeNextState;
			}
			return EGearHitAffectTypeExtensions.FromString(@string);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0008BE00 File Offset: 0x0008A000
		public override void Write(Utf8JsonWriter writer, EGearHitAffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
