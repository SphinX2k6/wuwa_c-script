using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200257B RID: 9595
	public class EDynamicEntityRewardTypeJsonConverter : JsonConverter<EDynamicEntityRewardType>
	{
		// Token: 0x0600D005 RID: 53253 RVA: 0x001E241C File Offset: 0x001E061C
		public override EDynamicEntityRewardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicEntityRewardType.Traffic;
			}
			return EDynamicEntityRewardTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x001E2440 File Offset: 0x001E0640
		public override void Write(Utf8JsonWriter writer, EDynamicEntityRewardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
