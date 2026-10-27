using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000929 RID: 2345
	public class EDynamicPortalCreateTypeJsonConverter : JsonConverter<EDynamicPortalCreateType>
	{
		// Token: 0x060034EB RID: 13547 RVA: 0x0008A4FC File Offset: 0x000886FC
		public override EDynamicPortalCreateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicPortalCreateType.Bullet;
			}
			return EDynamicPortalCreateTypeExtensions.FromString(@string);
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x0008A520 File Offset: 0x00088720
		public override void Write(Utf8JsonWriter writer, EDynamicPortalCreateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
