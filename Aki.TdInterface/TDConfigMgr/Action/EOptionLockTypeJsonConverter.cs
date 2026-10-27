using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BA RID: 9146
	public class EOptionLockTypeJsonConverter : JsonConverter<EOptionLockType>
	{
		// Token: 0x0600C745 RID: 51013 RVA: 0x001D2C50 File Offset: 0x001D0E50
		public override EOptionLockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOptionLockType.OnMotor;
			}
			return EOptionLockTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C746 RID: 51014 RVA: 0x001D2C74 File Offset: 0x001D0E74
		public override void Write(Utf8JsonWriter writer, EOptionLockType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
