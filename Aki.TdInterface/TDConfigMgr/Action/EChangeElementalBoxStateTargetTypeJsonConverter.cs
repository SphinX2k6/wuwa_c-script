using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D2 RID: 8914
	public class EChangeElementalBoxStateTargetTypeJsonConverter : JsonConverter<EChangeElementalBoxStateTargetType>
	{
		// Token: 0x0600C331 RID: 49969 RVA: 0x001C8634 File Offset: 0x001C6834
		public override EChangeElementalBoxStateTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeElementalBoxStateTargetType.Player;
			}
			return EChangeElementalBoxStateTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C332 RID: 49970 RVA: 0x001C8658 File Offset: 0x001C6858
		public override void Write(Utf8JsonWriter writer, EChangeElementalBoxStateTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
