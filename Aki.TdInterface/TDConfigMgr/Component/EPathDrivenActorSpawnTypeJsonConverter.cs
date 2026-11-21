using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A88 RID: 2696
	public class EPathDrivenActorSpawnTypeJsonConverter : JsonConverter<EPathDrivenActorSpawnType>
	{
		// Token: 0x06003B78 RID: 15224 RVA: 0x00099278 File Offset: 0x00097478
		public override EPathDrivenActorSpawnType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPathDrivenActorSpawnType.IntervalSplineSpawn;
			}
			return EPathDrivenActorSpawnTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x0009929C File Offset: 0x0009749C
		public override void Write(Utf8JsonWriter writer, EPathDrivenActorSpawnType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
