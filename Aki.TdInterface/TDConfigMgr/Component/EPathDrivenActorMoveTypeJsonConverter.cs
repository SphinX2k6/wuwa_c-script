using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A86 RID: 2694
	public class EPathDrivenActorMoveTypeJsonConverter : JsonConverter<EPathDrivenActorMoveType>
	{
		// Token: 0x06003B6F RID: 15215 RVA: 0x0009919C File Offset: 0x0009739C
		public override EPathDrivenActorMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPathDrivenActorMoveType.Spline;
			}
			return EPathDrivenActorMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x000991C0 File Offset: 0x000973C0
		public override void Write(Utf8JsonWriter writer, EPathDrivenActorMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
