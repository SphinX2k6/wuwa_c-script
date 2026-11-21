using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD0 RID: 2768
	public class ESlashAngleTypeJsonConverter : JsonConverter<ESlashAngleType>
	{
		// Token: 0x06003CBC RID: 15548 RVA: 0x0009B998 File Offset: 0x00099B98
		public override ESlashAngleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlashAngleType.Slash45;
			}
			return ESlashAngleTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x0009B9BC File Offset: 0x00099BBC
		public override void Write(Utf8JsonWriter writer, ESlashAngleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
