using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002701 RID: 9985
	public class ETargetEntityTypeJsonConverter : JsonConverter<ETargetEntityType>
	{
		// Token: 0x0600D6E0 RID: 55008 RVA: 0x001F6098 File Offset: 0x001F4298
		public override ETargetEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetEntityType.Target;
			}
			return ETargetEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x001F60BC File Offset: 0x001F42BC
		public override void Write(Utf8JsonWriter writer, ETargetEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
