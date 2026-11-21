using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A8E RID: 2702
	public class EPatrolPositionRefreshTypeJsonConverter : JsonConverter<EPatrolPositionRefreshType>
	{
		// Token: 0x06003B93 RID: 15251 RVA: 0x0009957C File Offset: 0x0009777C
		public override EPatrolPositionRefreshType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPatrolPositionRefreshType.NearestSplinePointToPlayer;
			}
			return EPatrolPositionRefreshTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x000995A0 File Offset: 0x000977A0
		public override void Write(Utf8JsonWriter writer, EPatrolPositionRefreshType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
