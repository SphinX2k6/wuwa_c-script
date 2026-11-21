using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D4 RID: 2516
	public class EDragHintTypeJsonConverter : JsonConverter<EDragHintType>
	{
		// Token: 0x0600384E RID: 14414 RVA: 0x00091FA0 File Offset: 0x000901A0
		public override EDragHintType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDragHintType.Horizontal;
			}
			return EDragHintTypeExtensions.FromString(@string);
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00091FC4 File Offset: 0x000901C4
		public override void Write(Utf8JsonWriter writer, EDragHintType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
