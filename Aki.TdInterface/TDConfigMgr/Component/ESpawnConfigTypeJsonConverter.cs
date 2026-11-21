using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD6 RID: 2774
	public class ESpawnConfigTypeJsonConverter : JsonConverter<ESpawnConfigType>
	{
		// Token: 0x06003CD7 RID: 15575 RVA: 0x0009BDE0 File Offset: 0x00099FE0
		public override ESpawnConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpawnConfigType.TemplateMatrix;
			}
			return ESpawnConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x0009BE04 File Offset: 0x0009A004
		public override void Write(Utf8JsonWriter writer, ESpawnConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
