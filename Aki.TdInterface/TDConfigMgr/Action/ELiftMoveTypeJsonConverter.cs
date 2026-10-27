using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002370 RID: 9072
	public class ELiftMoveTypeJsonConverter : JsonConverter<ELiftMoveType>
	{
		// Token: 0x0600C5F8 RID: 50680 RVA: 0x001D0044 File Offset: 0x001CE244
		public override ELiftMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiftMoveType.Default;
			}
			return ELiftMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x001D0068 File Offset: 0x001CE268
		public override void Write(Utf8JsonWriter writer, ELiftMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
