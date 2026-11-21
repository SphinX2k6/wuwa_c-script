using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002691 RID: 9873
	public class ERoverRogueActivateTypeJsonConverter : JsonConverter<ERoverRogueActivateType>
	{
		// Token: 0x0600D4E8 RID: 54504 RVA: 0x001EEC0C File Offset: 0x001ECE0C
		public override ERoverRogueActivateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoverRogueActivateType.Shop;
			}
			return ERoverRogueActivateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4E9 RID: 54505 RVA: 0x001EEC30 File Offset: 0x001ECE30
		public override void Write(Utf8JsonWriter writer, ERoverRogueActivateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
