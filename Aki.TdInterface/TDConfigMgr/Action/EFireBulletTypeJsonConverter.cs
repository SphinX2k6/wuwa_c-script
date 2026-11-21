using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025AD RID: 9645
	public class EFireBulletTypeJsonConverter : JsonConverter<EFireBulletType>
	{
		// Token: 0x0600D0E6 RID: 53478 RVA: 0x001E44DC File Offset: 0x001E26DC
		public override EFireBulletType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFireBulletType.TrackTarget;
			}
			return EFireBulletTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x001E4500 File Offset: 0x001E2700
		public override void Write(Utf8JsonWriter writer, EFireBulletType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
