using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230C RID: 8972
	public class EDynamicEntityRewardTypeJsonConverter : JsonConverter<EDynamicEntityRewardType>
	{
		// Token: 0x0600C436 RID: 50230 RVA: 0x001CA554 File Offset: 0x001C8754
		public override EDynamicEntityRewardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicEntityRewardType.Traffic;
			}
			return EDynamicEntityRewardTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x001CA578 File Offset: 0x001C8778
		public override void Write(Utf8JsonWriter writer, EDynamicEntityRewardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
