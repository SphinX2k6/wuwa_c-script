using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A8A RID: 2698
	public class EPatrolCycleModeJsonConverter : JsonConverter<EPatrolCycleMode>
	{
		// Token: 0x06003B81 RID: 15233 RVA: 0x0009938C File Offset: 0x0009758C
		public override EPatrolCycleMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPatrolCycleMode.Loop;
			}
			return EPatrolCycleModeExtensions.FromString(@string);
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x000993B0 File Offset: 0x000975B0
		public override void Write(Utf8JsonWriter writer, EPatrolCycleMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
