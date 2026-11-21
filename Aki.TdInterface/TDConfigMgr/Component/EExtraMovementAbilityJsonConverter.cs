using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F0 RID: 2544
	public class EExtraMovementAbilityJsonConverter : JsonConverter<EExtraMovementAbility>
	{
		// Token: 0x060038CC RID: 14540 RVA: 0x000932D4 File Offset: 0x000914D4
		public override EExtraMovementAbility Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExtraMovementAbility.Diving;
			}
			return EExtraMovementAbilityExtensions.FromString(@string);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x000932F8 File Offset: 0x000914F8
		public override void Write(Utf8JsonWriter writer, EExtraMovementAbility value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
