using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A74 RID: 2676
	public class EPasserbyNpcExitOrderTypeJsonConverter : JsonConverter<EPasserbyNpcExitOrderType>
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x00098970 File Offset: 0x00096B70
		public override EPasserbyNpcExitOrderType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcExitOrderType.NearSplineStartFirst;
			}
			return EPasserbyNpcExitOrderTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00098994 File Offset: 0x00096B94
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcExitOrderType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
