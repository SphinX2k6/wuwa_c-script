using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200264B RID: 9803
	public class EOptionLockTypeJsonConverter : JsonConverter<EOptionLockType>
	{
		// Token: 0x0600D3AD RID: 54189 RVA: 0x001EC084 File Offset: 0x001EA284
		public override EOptionLockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOptionLockType.OnMotor;
			}
			return EOptionLockTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3AE RID: 54190 RVA: 0x001EC0A8 File Offset: 0x001EA2A8
		public override void Write(Utf8JsonWriter writer, EOptionLockType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
