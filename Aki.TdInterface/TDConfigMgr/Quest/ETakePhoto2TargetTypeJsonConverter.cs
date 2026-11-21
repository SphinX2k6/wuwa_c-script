using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E3 RID: 5091
	public class ETakePhoto2TargetTypeJsonConverter : JsonConverter<ETakePhoto2TargetType>
	{
		// Token: 0x060071D9 RID: 29145 RVA: 0x00110184 File Offset: 0x0010E384
		public override ETakePhoto2TargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETakePhoto2TargetType.Entity;
			}
			return ETakePhoto2TargetTypeExtensions.FromString(@string);
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x001101A8 File Offset: 0x0010E3A8
		public override void Write(Utf8JsonWriter writer, ETakePhoto2TargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
