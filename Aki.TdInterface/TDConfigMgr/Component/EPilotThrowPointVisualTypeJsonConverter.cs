using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A9A RID: 2714
	public class EPilotThrowPointVisualTypeJsonConverter : JsonConverter<EPilotThrowPointVisualType>
	{
		// Token: 0x06003BC9 RID: 15305 RVA: 0x00099C88 File Offset: 0x00097E88
		public override EPilotThrowPointVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPilotThrowPointVisualType.Normal;
			}
			return EPilotThrowPointVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x00099CAC File Offset: 0x00097EAC
		public override void Write(Utf8JsonWriter writer, EPilotThrowPointVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
