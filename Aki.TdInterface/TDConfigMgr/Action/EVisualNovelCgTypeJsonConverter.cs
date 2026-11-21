using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200274B RID: 10059
	public class EVisualNovelCgTypeJsonConverter : JsonConverter<EVisualNovelCgType>
	{
		// Token: 0x0600D82D RID: 55341 RVA: 0x001F94A8 File Offset: 0x001F76A8
		public override EVisualNovelCgType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelCgType.LoadPrefab;
			}
			return EVisualNovelCgTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D82E RID: 55342 RVA: 0x001F94CC File Offset: 0x001F76CC
		public override void Write(Utf8JsonWriter writer, EVisualNovelCgType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
