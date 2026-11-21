using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FE RID: 2558
	public class EFollowShooterMontageTypeJsonConverter : JsonConverter<EFollowShooterMontageType>
	{
		// Token: 0x0600390B RID: 14603 RVA: 0x000939B8 File Offset: 0x00091BB8
		public override EFollowShooterMontageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFollowShooterMontageType.Born;
			}
			return EFollowShooterMontageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x000939DC File Offset: 0x00091BDC
		public override void Write(Utf8JsonWriter writer, EFollowShooterMontageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
