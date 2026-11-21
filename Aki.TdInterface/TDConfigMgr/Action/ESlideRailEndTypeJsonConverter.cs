using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C1 RID: 9921
	public class ESlideRailEndTypeJsonConverter : JsonConverter<ESlideRailEndType>
	{
		// Token: 0x0600D5C0 RID: 54720 RVA: 0x001F0FD4 File Offset: 0x001EF1D4
		public override ESlideRailEndType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlideRailEndType.Player;
			}
			return ESlideRailEndTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x001F0FF8 File Offset: 0x001EF1F8
		public override void Write(Utf8JsonWriter writer, ESlideRailEndType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
