using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000947 RID: 2375
	public class EFanInteractTypeJsonConverter : JsonConverter<EFanInteractType>
	{
		// Token: 0x06003572 RID: 13682 RVA: 0x0008B920 File Offset: 0x00089B20
		public override EFanInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFanInteractType.Hit;
			}
			return EFanInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0008B944 File Offset: 0x00089B44
		public override void Write(Utf8JsonWriter writer, EFanInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
