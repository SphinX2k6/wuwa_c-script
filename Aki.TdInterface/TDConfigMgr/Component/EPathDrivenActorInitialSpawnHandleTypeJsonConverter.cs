using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C3 RID: 2499
	public class EPathDrivenActorInitialSpawnHandleTypeJsonConverter : JsonConverter<EPathDrivenActorInitialSpawnHandleType>
	{
		// Token: 0x060037A0 RID: 14240 RVA: 0x000909F0 File Offset: 0x0008EBF0
		public override EPathDrivenActorInitialSpawnHandleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
			}
			return EPathDrivenActorInitialSpawnHandleTypeExtensions.FromString(@string);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00090A14 File Offset: 0x0008EC14
		public override void Write(Utf8JsonWriter writer, EPathDrivenActorInitialSpawnHandleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
