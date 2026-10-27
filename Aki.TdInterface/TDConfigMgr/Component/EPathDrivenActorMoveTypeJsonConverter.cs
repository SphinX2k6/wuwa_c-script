using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C5 RID: 2501
	public class EPathDrivenActorMoveTypeJsonConverter : JsonConverter<EPathDrivenActorMoveType>
	{
		// Token: 0x060037A9 RID: 14249 RVA: 0x00090ACC File Offset: 0x0008ECCC
		public override EPathDrivenActorMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPathDrivenActorMoveType.Spline;
			}
			return EPathDrivenActorMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00090AF0 File Offset: 0x0008ECF0
		public override void Write(Utf8JsonWriter writer, EPathDrivenActorMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
