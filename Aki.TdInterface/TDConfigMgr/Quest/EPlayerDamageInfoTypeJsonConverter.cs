using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A5 RID: 5029
	public class EPlayerDamageInfoTypeJsonConverter : JsonConverter<EPlayerDamageInfoType>
	{
		// Token: 0x060070C2 RID: 28866 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		public override EPlayerDamageInfoType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayerDamageInfoType.DamagePoint;
			}
			return EPlayerDamageInfoTypeExtensions.FromString(@string);
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x0010CD50 File Offset: 0x0010AF50
		public override void Write(Utf8JsonWriter writer, EPlayerDamageInfoType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
