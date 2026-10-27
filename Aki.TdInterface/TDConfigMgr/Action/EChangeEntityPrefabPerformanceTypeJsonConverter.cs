using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D4 RID: 8916
	public class EChangeEntityPrefabPerformanceTypeJsonConverter : JsonConverter<EChangeEntityPrefabPerformanceType>
	{
		// Token: 0x0600C33A RID: 49978 RVA: 0x001C8748 File Offset: 0x001C6948
		public override EChangeEntityPrefabPerformanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeEntityPrefabPerformanceType.Target;
			}
			return EChangeEntityPrefabPerformanceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x001C876C File Offset: 0x001C696C
		public override void Write(Utf8JsonWriter writer, EChangeEntityPrefabPerformanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
