using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242C RID: 9260
	public class ESplineMoveTargetTypeJsonConverter : JsonConverter<ESplineMoveTargetType>
	{
		// Token: 0x0600C946 RID: 51526 RVA: 0x001D78FC File Offset: 0x001D5AFC
		public override ESplineMoveTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineMoveTargetType.Entity;
			}
			return ESplineMoveTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x001D7920 File Offset: 0x001D5B20
		public override void Write(Utf8JsonWriter writer, ESplineMoveTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
