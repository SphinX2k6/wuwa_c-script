using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A04 RID: 2564
	public class EGearHitAffectTypeJsonConverter : JsonConverter<EGearHitAffectType>
	{
		// Token: 0x06003926 RID: 14630 RVA: 0x00093D30 File Offset: 0x00091F30
		public override EGearHitAffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGearHitAffectType.ChangeNextState;
			}
			return EGearHitAffectTypeExtensions.FromString(@string);
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00093D54 File Offset: 0x00091F54
		public override void Write(Utf8JsonWriter writer, EGearHitAffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
