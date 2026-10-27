using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099D RID: 2461
	public class EModelTypeJsonConverter : JsonConverter<EModelType>
	{
		// Token: 0x060036F5 RID: 14069 RVA: 0x0008EFCC File Offset: 0x0008D1CC
		public override EModelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EModelType.LevelPrefab;
			}
			return EModelTypeExtensions.FromString(@string);
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x0008EFF0 File Offset: 0x0008D1F0
		public override void Write(Utf8JsonWriter writer, EModelType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
