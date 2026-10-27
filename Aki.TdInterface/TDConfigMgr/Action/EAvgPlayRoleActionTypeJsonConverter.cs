using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AA RID: 8874
	public class EAvgPlayRoleActionTypeJsonConverter : JsonConverter<EAvgPlayRoleActionType>
	{
		// Token: 0x0600C27D RID: 49789 RVA: 0x001C6A0C File Offset: 0x001C4C0C
		public override EAvgPlayRoleActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgPlayRoleActionType.Enter;
			}
			return EAvgPlayRoleActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C27E RID: 49790 RVA: 0x001C6A30 File Offset: 0x001C4C30
		public override void Write(Utf8JsonWriter writer, EAvgPlayRoleActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
