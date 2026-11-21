using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002507 RID: 9479
	public class EAfterTeleportScreenColorJsonConverter : JsonConverter<EAfterTeleportScreenColor>
	{
		// Token: 0x0600CDFB RID: 52731 RVA: 0x001DDDA4 File Offset: 0x001DBFA4
		public override EAfterTeleportScreenColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAfterTeleportScreenColor.Black;
			}
			return EAfterTeleportScreenColorExtensions.FromString(@string);
		}

		// Token: 0x0600CDFC RID: 52732 RVA: 0x001DDDC8 File Offset: 0x001DBFC8
		public override void Write(Utf8JsonWriter writer, EAfterTeleportScreenColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
