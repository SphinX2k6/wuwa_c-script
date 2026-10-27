using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A3 RID: 2467
	public class EMotorAutoEjectTypeJsonConverter : JsonConverter<EMotorAutoEjectType>
	{
		// Token: 0x06003710 RID: 14096 RVA: 0x0008F344 File Offset: 0x0008D544
		public override EMotorAutoEjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorAutoEjectType.NextHook;
			}
			return EMotorAutoEjectTypeExtensions.FromString(@string);
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x0008F368 File Offset: 0x0008D568
		public override void Write(Utf8JsonWriter writer, EMotorAutoEjectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
