using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228A RID: 8842
	public class EActionTypeJsonConverter : JsonConverter<EActionType>
	{
		// Token: 0x0600C1ED RID: 49645 RVA: 0x001C50EC File Offset: 0x001C32EC
		public override EActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActionType.Entity;
			}
			return EActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x001C5110 File Offset: 0x001C3310
		public override void Write(Utf8JsonWriter writer, EActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
