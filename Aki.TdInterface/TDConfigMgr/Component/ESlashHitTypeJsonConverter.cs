using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0F RID: 2575
	public class ESlashHitTypeJsonConverter : JsonConverter<ESlashHitType>
	{
		// Token: 0x060038F6 RID: 14582 RVA: 0x00093414 File Offset: 0x00091614
		public override ESlashHitType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlashHitType.HeavySlash;
			}
			return ESlashHitTypeExtensions.FromString(@string);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x00093438 File Offset: 0x00091638
		public override void Write(Utf8JsonWriter writer, ESlashHitType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
