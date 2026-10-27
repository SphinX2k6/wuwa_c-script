using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002460 RID: 9312
	public class ETargetEntityTypeJsonConverter : JsonConverter<ETargetEntityType>
	{
		// Token: 0x0600CA30 RID: 51760 RVA: 0x001DBFE4 File Offset: 0x001DA1E4
		public override ETargetEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetEntityType.Target;
			}
			return ETargetEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA31 RID: 51761 RVA: 0x001DC008 File Offset: 0x001DA208
		public override void Write(Utf8JsonWriter writer, ETargetEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
