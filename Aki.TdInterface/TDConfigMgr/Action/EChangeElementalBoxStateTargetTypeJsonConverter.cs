using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002541 RID: 9537
	public class EChangeElementalBoxStateTargetTypeJsonConverter : JsonConverter<EChangeElementalBoxStateTargetType>
	{
		// Token: 0x0600CF00 RID: 52992 RVA: 0x001E043C File Offset: 0x001DE63C
		public override EChangeElementalBoxStateTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeElementalBoxStateTargetType.Player;
			}
			return EChangeElementalBoxStateTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF01 RID: 52993 RVA: 0x001E0460 File Offset: 0x001DE660
		public override void Write(Utf8JsonWriter writer, EChangeElementalBoxStateTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
