using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D6 RID: 2518
	public class EDynamicPortalCreateTypeJsonConverter : JsonConverter<EDynamicPortalCreateType>
	{
		// Token: 0x06003857 RID: 14423 RVA: 0x0009207C File Offset: 0x0009027C
		public override EDynamicPortalCreateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicPortalCreateType.Bullet;
			}
			return EDynamicPortalCreateTypeExtensions.FromString(@string);
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x000920A0 File Offset: 0x000902A0
		public override void Write(Utf8JsonWriter writer, EDynamicPortalCreateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
