using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A84 RID: 2692
	public class EPathDrivenActorInitialSpawnHandleTypeJsonConverter : JsonConverter<EPathDrivenActorInitialSpawnHandleType>
	{
		// Token: 0x06003B66 RID: 15206 RVA: 0x000990C0 File Offset: 0x000972C0
		public override EPathDrivenActorInitialSpawnHandleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
			}
			return EPathDrivenActorInitialSpawnHandleTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000990E4 File Offset: 0x000972E4
		public override void Write(Utf8JsonWriter writer, EPathDrivenActorInitialSpawnHandleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
