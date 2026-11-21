using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A98 RID: 2712
	public class EPilotThrowAutoThrowTypeJsonConverter : JsonConverter<EPilotThrowAutoThrowType>
	{
		// Token: 0x06003BC0 RID: 15296 RVA: 0x00099B30 File Offset: 0x00097D30
		public override EPilotThrowAutoThrowType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPilotThrowAutoThrowType.LowAngle;
			}
			return EPilotThrowAutoThrowTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00099B54 File Offset: 0x00097D54
		public override void Write(Utf8JsonWriter writer, EPilotThrowAutoThrowType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
