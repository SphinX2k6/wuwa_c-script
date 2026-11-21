using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F8 RID: 2552
	public class EFightMusicsSwitchTypeJsonConverter : JsonConverter<EFightMusicsSwitchType>
	{
		// Token: 0x060038F0 RID: 14576 RVA: 0x000936B4 File Offset: 0x000918B4
		public override EFightMusicsSwitchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFightMusicsSwitchType.SwitchByTag;
			}
			return EFightMusicsSwitchTypeExtensions.FromString(@string);
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x000936D8 File Offset: 0x000918D8
		public override void Write(Utf8JsonWriter writer, EFightMusicsSwitchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
