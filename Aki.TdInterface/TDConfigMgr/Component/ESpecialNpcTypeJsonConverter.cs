using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE0 RID: 2784
	public class ESpecialNpcTypeJsonConverter : JsonConverter<ESpecialNpcType>
	{
		// Token: 0x06003D04 RID: 15620 RVA: 0x0009C2A8 File Offset: 0x0009A4A8
		public override ESpecialNpcType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialNpcType.BaseRoleNpc;
			}
			return ESpecialNpcTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x0009C2CC File Offset: 0x0009A4CC
		public override void Write(Utf8JsonWriter writer, ESpecialNpcType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
