using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AFA RID: 2810
	public class ETeleportActionTypeJsonConverter : JsonConverter<ETeleportActionType>
	{
		// Token: 0x06003D79 RID: 15737 RVA: 0x0009D554 File Offset: 0x0009B754
		public override ETeleportActionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleportActionType.Dodge;
			}
			return ETeleportActionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x0009D578 File Offset: 0x0009B778
		public override void Write(Utf8JsonWriter writer, ETeleportActionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
