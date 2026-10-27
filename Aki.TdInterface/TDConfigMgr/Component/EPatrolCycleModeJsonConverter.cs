using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C9 RID: 2505
	public class EPatrolCycleModeJsonConverter : JsonConverter<EPatrolCycleMode>
	{
		// Token: 0x060037BB RID: 14267 RVA: 0x00090CBC File Offset: 0x0008EEBC
		public override EPatrolCycleMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPatrolCycleMode.Loop;
			}
			return EPatrolCycleModeExtensions.FromString(@string);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00090CE0 File Offset: 0x0008EEE0
		public override void Write(Utf8JsonWriter writer, EPatrolCycleMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
