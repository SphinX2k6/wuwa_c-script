using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200137F RID: 4991
	public class EFastReturnPosTypeJsonConverter : JsonConverter<EFastReturnPosType>
	{
		// Token: 0x06007017 RID: 28695 RVA: 0x0010B360 File Offset: 0x00109560
		public override EFastReturnPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFastReturnPosType.EntityPos;
			}
			return EFastReturnPosTypeExtensions.FromString(@string);
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x0010B384 File Offset: 0x00109584
		public override void Write(Utf8JsonWriter writer, EFastReturnPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
