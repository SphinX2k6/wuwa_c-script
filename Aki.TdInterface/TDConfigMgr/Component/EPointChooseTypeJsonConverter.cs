using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D7 RID: 2519
	public class EPointChooseTypeJsonConverter : JsonConverter<EPointChooseType>
	{
		// Token: 0x060037FA RID: 14330 RVA: 0x000914A4 File Offset: 0x0008F6A4
		public override EPointChooseType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPointChooseType.SpawnMonsterPoint;
			}
			return EPointChooseTypeExtensions.FromString(@string);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000914C8 File Offset: 0x0008F6C8
		public override void Write(Utf8JsonWriter writer, EPointChooseType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
