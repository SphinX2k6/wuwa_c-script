using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A8 RID: 9384
	public class EVisualNovelCgTypeJsonConverter : JsonConverter<EVisualNovelCgType>
	{
		// Token: 0x0600CB74 RID: 52084 RVA: 0x001DF2E0 File Offset: 0x001DD4E0
		public override EVisualNovelCgType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelCgType.LoadSpine;
			}
			return EVisualNovelCgTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB75 RID: 52085 RVA: 0x001DF304 File Offset: 0x001DD504
		public override void Write(Utf8JsonWriter writer, EVisualNovelCgType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
