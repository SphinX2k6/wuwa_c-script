using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229A RID: 8858
	public class EAfterTeleportScreenColorJsonConverter : JsonConverter<EAfterTeleportScreenColor>
	{
		// Token: 0x0600C235 RID: 49717 RVA: 0x001C60B0 File Offset: 0x001C42B0
		public override EAfterTeleportScreenColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAfterTeleportScreenColor.Black;
			}
			return EAfterTeleportScreenColorExtensions.FromString(@string);
		}

		// Token: 0x0600C236 RID: 49718 RVA: 0x001C60D4 File Offset: 0x001C42D4
		public override void Write(Utf8JsonWriter writer, EAfterTeleportScreenColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
