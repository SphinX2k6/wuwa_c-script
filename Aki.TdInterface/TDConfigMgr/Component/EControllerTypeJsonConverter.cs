using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000915 RID: 2325
	public class EControllerTypeJsonConverter : JsonConverter<EControllerType>
	{
		// Token: 0x06003491 RID: 13457 RVA: 0x00089ACC File Offset: 0x00087CCC
		public override EControllerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EControllerType.FreeAngle;
			}
			return EControllerTypeExtensions.FromString(@string);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00089AF0 File Offset: 0x00087CF0
		public override void Write(Utf8JsonWriter writer, EControllerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
