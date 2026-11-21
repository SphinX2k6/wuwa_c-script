using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A50 RID: 2640
	public class EModelTypeJsonConverter : JsonConverter<EModelType>
	{
		// Token: 0x06003A7C RID: 14972 RVA: 0x00096F7C File Offset: 0x0009517C
		public override EModelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EModelType.LevelPrefab;
			}
			return EModelTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00096FA0 File Offset: 0x000951A0
		public override void Write(Utf8JsonWriter writer, EModelType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
