using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A78 RID: 2680
	public class EPasserbyNpcGenerateTypeJsonConverter : JsonConverter<EPasserbyNpcGenerateType>
	{
		// Token: 0x06003B30 RID: 15152 RVA: 0x00098B28 File Offset: 0x00096D28
		public override EPasserbyNpcGenerateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcGenerateType.RandomStand;
			}
			return EPasserbyNpcGenerateTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x00098B4C File Offset: 0x00096D4C
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcGenerateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
