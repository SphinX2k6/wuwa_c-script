using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C7 RID: 2503
	public class EPathDrivenActorSpawnTypeJsonConverter : JsonConverter<EPathDrivenActorSpawnType>
	{
		// Token: 0x060037B2 RID: 14258 RVA: 0x00090BA8 File Offset: 0x0008EDA8
		public override EPathDrivenActorSpawnType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPathDrivenActorSpawnType.IntervalSplineSpawn;
			}
			return EPathDrivenActorSpawnTypeExtensions.FromString(@string);
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x00090BCC File Offset: 0x0008EDCC
		public override void Write(Utf8JsonWriter writer, EPathDrivenActorSpawnType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
