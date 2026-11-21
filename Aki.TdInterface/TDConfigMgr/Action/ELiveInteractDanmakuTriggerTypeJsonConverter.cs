using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F3 RID: 9715
	public class ELiveInteractDanmakuTriggerTypeJsonConverter : JsonConverter<ELiveInteractDanmakuTriggerType>
	{
		// Token: 0x0600D221 RID: 53793 RVA: 0x001E8CB8 File Offset: 0x001E6EB8
		public override ELiveInteractDanmakuTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveInteractDanmakuTriggerType.SkillGenre;
			}
			return ELiveInteractDanmakuTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D222 RID: 53794 RVA: 0x001E8CDC File Offset: 0x001E6EDC
		public override void Write(Utf8JsonWriter writer, ELiveInteractDanmakuTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
