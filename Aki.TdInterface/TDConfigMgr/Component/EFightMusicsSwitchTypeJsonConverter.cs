using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000949 RID: 2377
	public class EFightMusicsSwitchTypeJsonConverter : JsonConverter<EFightMusicsSwitchType>
	{
		// Token: 0x0600357B RID: 13691 RVA: 0x0008B9FC File Offset: 0x00089BFC
		public override EFightMusicsSwitchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFightMusicsSwitchType.SwitchByTag;
			}
			return EFightMusicsSwitchTypeExtensions.FromString(@string);
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0008BA20 File Offset: 0x00089C20
		public override void Write(Utf8JsonWriter writer, EFightMusicsSwitchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
