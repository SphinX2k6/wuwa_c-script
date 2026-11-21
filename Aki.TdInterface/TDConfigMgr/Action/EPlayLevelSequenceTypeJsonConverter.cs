using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200266D RID: 9837
	public class EPlayLevelSequenceTypeJsonConverter : JsonConverter<EPlayLevelSequenceType>
	{
		// Token: 0x0600D446 RID: 54342 RVA: 0x001ED684 File Offset: 0x001EB884
		public override EPlayLevelSequenceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayLevelSequenceType.Direct;
			}
			return EPlayLevelSequenceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D447 RID: 54343 RVA: 0x001ED6A8 File Offset: 0x001EB8A8
		public override void Write(Utf8JsonWriter writer, EPlayLevelSequenceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
