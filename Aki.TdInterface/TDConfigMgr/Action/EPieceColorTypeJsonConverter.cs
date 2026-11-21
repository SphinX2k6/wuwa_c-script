using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002661 RID: 9825
	public class EPieceColorTypeJsonConverter : JsonConverter<EPieceColorType>
	{
		// Token: 0x0600D410 RID: 54288 RVA: 0x001ECE9C File Offset: 0x001EB09C
		public override EPieceColorType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPieceColorType.White;
			}
			return EPieceColorTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D411 RID: 54289 RVA: 0x001ECEC0 File Offset: 0x001EB0C0
		public override void Write(Utf8JsonWriter writer, EPieceColorType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
