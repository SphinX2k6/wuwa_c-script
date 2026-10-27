using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A11 RID: 2577
	public class ESpawnConfigTypeJsonConverter : JsonConverter<ESpawnConfigType>
	{
		// Token: 0x060038FF RID: 14591 RVA: 0x000934F0 File Offset: 0x000916F0
		public override ESpawnConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpawnConfigType.TemplateMatrix;
			}
			return ESpawnConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00093514 File Offset: 0x00091714
		public override void Write(Utf8JsonWriter writer, ESpawnConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
