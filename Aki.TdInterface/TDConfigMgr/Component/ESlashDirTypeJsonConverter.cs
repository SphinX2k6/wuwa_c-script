using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0D RID: 2573
	public class ESlashDirTypeJsonConverter : JsonConverter<ESlashDirType>
	{
		// Token: 0x060038ED RID: 14573 RVA: 0x0009328C File Offset: 0x0009148C
		public override ESlashDirType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlashDirType.Horizontal;
			}
			return ESlashDirTypeExtensions.FromString(@string);
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x000932B0 File Offset: 0x000914B0
		public override void Write(Utf8JsonWriter writer, ESlashDirType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
