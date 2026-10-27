using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0B RID: 2571
	public class ESlashAngleTypeJsonConverter : JsonConverter<ESlashAngleType>
	{
		// Token: 0x060038E4 RID: 14564 RVA: 0x000930A8 File Offset: 0x000912A8
		public override ESlashAngleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlashAngleType.Slash45;
			}
			return ESlashAngleTypeExtensions.FromString(@string);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x000930CC File Offset: 0x000912CC
		public override void Write(Utf8JsonWriter writer, ESlashAngleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
