using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E9 RID: 9705
	public class ELiveDanmakuClearTypeJsonConverter : JsonConverter<ELiveDanmakuClearType>
	{
		// Token: 0x0600D1F4 RID: 53748 RVA: 0x001E869C File Offset: 0x001E689C
		public override ELiveDanmakuClearType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveDanmakuClearType.FinishCurrent;
			}
			return ELiveDanmakuClearTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D1F5 RID: 53749 RVA: 0x001E86C0 File Offset: 0x001E68C0
		public override void Write(Utf8JsonWriter writer, ELiveDanmakuClearType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
