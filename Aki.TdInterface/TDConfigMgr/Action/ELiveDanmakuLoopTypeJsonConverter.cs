using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025ED RID: 9709
	public class ELiveDanmakuLoopTypeJsonConverter : JsonConverter<ELiveDanmakuLoopType>
	{
		// Token: 0x0600D206 RID: 53766 RVA: 0x001E88C4 File Offset: 0x001E6AC4
		public override ELiveDanmakuLoopType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveDanmakuLoopType.OrderOnce;
			}
			return ELiveDanmakuLoopTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D207 RID: 53767 RVA: 0x001E88E8 File Offset: 0x001E6AE8
		public override void Write(Utf8JsonWriter writer, ELiveDanmakuLoopType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
