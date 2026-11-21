using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A7A RID: 2682
	public class EPasserbyNpcLiftMoveTypeJsonConverter : JsonConverter<EPasserbyNpcLiftMoveType>
	{
		// Token: 0x06003B39 RID: 15161 RVA: 0x00098C04 File Offset: 0x00096E04
		public override EPasserbyNpcLiftMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcLiftMoveType.RideLiftLeaveOnArrival;
			}
			return EPasserbyNpcLiftMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00098C28 File Offset: 0x00096E28
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcLiftMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
