using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD4 RID: 2772
	public class ESlashHitTypeJsonConverter : JsonConverter<ESlashHitType>
	{
		// Token: 0x06003CCE RID: 15566 RVA: 0x0009BD04 File Offset: 0x00099F04
		public override ESlashHitType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlashHitType.HeavySlash;
			}
			return ESlashHitTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x0009BD28 File Offset: 0x00099F28
		public override void Write(Utf8JsonWriter writer, ESlashHitType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
