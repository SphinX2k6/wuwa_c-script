using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E8 RID: 8936
	public class EClientSetSeasonStateTypeJsonConverter : JsonConverter<EClientSetSeasonStateType>
	{
		// Token: 0x0600C394 RID: 50068 RVA: 0x001C9260 File Offset: 0x001C7460
		public override EClientSetSeasonStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientSetSeasonStateType.SwitchSeason;
			}
			return EClientSetSeasonStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x001C9284 File Offset: 0x001C7484
		public override void Write(Utf8JsonWriter writer, EClientSetSeasonStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
