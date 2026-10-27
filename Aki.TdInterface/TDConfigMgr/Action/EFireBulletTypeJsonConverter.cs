using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233C RID: 9020
	public class EFireBulletTypeJsonConverter : JsonConverter<EFireBulletType>
	{
		// Token: 0x0600C50E RID: 50446 RVA: 0x001CC424 File Offset: 0x001CA624
		public override EFireBulletType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFireBulletType.TrackTarget;
			}
			return EFireBulletTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C50F RID: 50447 RVA: 0x001CC448 File Offset: 0x001CA648
		public override void Write(Utf8JsonWriter writer, EFireBulletType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
