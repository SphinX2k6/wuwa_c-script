using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002466 RID: 9318
	public class ETeleportToLatestResetPointTypeJsonConverter : JsonConverter<ETeleportToLatestResetPointType>
	{
		// Token: 0x0600CA4B RID: 51787 RVA: 0x001DC458 File Offset: 0x001DA658
		public override ETeleportToLatestResetPointType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleportToLatestResetPointType.Directly;
			}
			return ETeleportToLatestResetPointTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x001DC47C File Offset: 0x001DA67C
		public override void Write(Utf8JsonWriter writer, ETeleportToLatestResetPointType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
