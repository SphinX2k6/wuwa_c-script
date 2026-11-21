using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002677 RID: 9847
	public class EPreprocessOperationJsonConverter : JsonConverter<EPreprocessOperation>
	{
		// Token: 0x0600D473 RID: 54387 RVA: 0x001EDC58 File Offset: 0x001EBE58
		public override EPreprocessOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPreprocessOperation.FloatingSubtitleLanguageDiff;
			}
			return EPreprocessOperationExtensions.FromString(@string);
		}

		// Token: 0x0600D474 RID: 54388 RVA: 0x001EDC7C File Offset: 0x001EBE7C
		public override void Write(Utf8JsonWriter writer, EPreprocessOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
