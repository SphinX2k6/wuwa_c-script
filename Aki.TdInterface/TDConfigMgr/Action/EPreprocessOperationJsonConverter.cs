using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E0 RID: 9184
	public class EPreprocessOperationJsonConverter : JsonConverter<EPreprocessOperation>
	{
		// Token: 0x0600C7F0 RID: 51184 RVA: 0x001D44AC File Offset: 0x001D26AC
		public override EPreprocessOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPreprocessOperation.FloatingSubtitleLanguageDiff;
			}
			return EPreprocessOperationExtensions.FromString(@string);
		}

		// Token: 0x0600C7F1 RID: 51185 RVA: 0x001D44D0 File Offset: 0x001D26D0
		public override void Write(Utf8JsonWriter writer, EPreprocessOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
