using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E5 RID: 9701
	public class ELiftMoveTypeJsonConverter : JsonConverter<ELiftMoveType>
	{
		// Token: 0x0600D1E2 RID: 53730 RVA: 0x001E8324 File Offset: 0x001E6524
		public override ELiftMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiftMoveType.Default;
			}
			return ELiftMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x001E8348 File Offset: 0x001E6548
		public override void Write(Utf8JsonWriter writer, ELiftMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
