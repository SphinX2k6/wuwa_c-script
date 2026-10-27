using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123F RID: 4671
	public class EFastReturnPosTypeJsonConverter : JsonConverter<EFastReturnPosType>
	{
		// Token: 0x060069C4 RID: 27076 RVA: 0x000FD734 File Offset: 0x000FB934
		public override EFastReturnPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFastReturnPosType.EntityPos;
			}
			return EFastReturnPosTypeExtensions.FromString(@string);
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x000FD758 File Offset: 0x000FB958
		public override void Write(Utf8JsonWriter writer, EFastReturnPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
