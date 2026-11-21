using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002543 RID: 9539
	public class EChangeEntityPrefabPerformanceTypeJsonConverter : JsonConverter<EChangeEntityPrefabPerformanceType>
	{
		// Token: 0x0600CF09 RID: 53001 RVA: 0x001E0550 File Offset: 0x001DE750
		public override EChangeEntityPrefabPerformanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeEntityPrefabPerformanceType.Target;
			}
			return EChangeEntityPrefabPerformanceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF0A RID: 53002 RVA: 0x001E0574 File Offset: 0x001DE774
		public override void Write(Utf8JsonWriter writer, EChangeEntityPrefabPerformanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
