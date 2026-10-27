using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D6 RID: 9174
	public class EPlayLevelSequenceTypeJsonConverter : JsonConverter<EPlayLevelSequenceType>
	{
		// Token: 0x0600C7C3 RID: 51139 RVA: 0x001D3ED8 File Offset: 0x001D20D8
		public override EPlayLevelSequenceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPlayLevelSequenceType.Direct;
			}
			return EPlayLevelSequenceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C7C4 RID: 51140 RVA: 0x001D3EFC File Offset: 0x001D20FC
		public override void Write(Utf8JsonWriter writer, EPlayLevelSequenceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
