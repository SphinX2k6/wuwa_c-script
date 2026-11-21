using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002519 RID: 9497
	public class EAvgPlayRoleActionTypeJsonConverter : JsonConverter<EAvgPlayRoleActionType>
	{
		// Token: 0x0600CE4C RID: 52812 RVA: 0x001DE814 File Offset: 0x001DCA14
		public override EAvgPlayRoleActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgPlayRoleActionType.Enter;
			}
			return EAvgPlayRoleActionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE4D RID: 52813 RVA: 0x001DE838 File Offset: 0x001DCA38
		public override void Write(Utf8JsonWriter writer, EAvgPlayRoleActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
