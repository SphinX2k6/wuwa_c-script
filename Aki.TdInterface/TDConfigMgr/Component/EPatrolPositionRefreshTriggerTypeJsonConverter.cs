using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A8C RID: 2700
	public class EPatrolPositionRefreshTriggerTypeJsonConverter : JsonConverter<EPatrolPositionRefreshTriggerType>
	{
		// Token: 0x06003B8A RID: 15242 RVA: 0x000994A0 File Offset: 0x000976A0
		public override EPatrolPositionRefreshTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPatrolPositionRefreshTriggerType.EntityAwake;
			}
			return EPatrolPositionRefreshTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x000994C4 File Offset: 0x000976C4
		public override void Write(Utf8JsonWriter writer, EPatrolPositionRefreshTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
