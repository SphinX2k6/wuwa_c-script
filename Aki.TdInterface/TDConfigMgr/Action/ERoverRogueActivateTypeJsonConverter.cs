using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FA RID: 9210
	public class ERoverRogueActivateTypeJsonConverter : JsonConverter<ERoverRogueActivateType>
	{
		// Token: 0x0600C865 RID: 51301 RVA: 0x001D5460 File Offset: 0x001D3660
		public override ERoverRogueActivateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoverRogueActivateType.Shop;
			}
			return ERoverRogueActivateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C866 RID: 51302 RVA: 0x001D5484 File Offset: 0x001D3684
		public override void Write(Utf8JsonWriter writer, ERoverRogueActivateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
