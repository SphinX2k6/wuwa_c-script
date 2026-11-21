using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD2 RID: 2770
	public class ESlashDirTypeJsonConverter : JsonConverter<ESlashDirType>
	{
		// Token: 0x06003CC5 RID: 15557 RVA: 0x0009BB7C File Offset: 0x00099D7C
		public override ESlashDirType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlashDirType.Horizontal;
			}
			return ESlashDirTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x0009BBA0 File Offset: 0x00099DA0
		public override void Write(Utf8JsonWriter writer, ESlashDirType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
