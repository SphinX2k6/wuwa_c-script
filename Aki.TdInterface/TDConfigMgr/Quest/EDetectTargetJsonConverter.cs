using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001377 RID: 4983
	public class EDetectTargetJsonConverter : JsonConverter<EDetectTarget>
	{
		// Token: 0x06006FF3 RID: 28659 RVA: 0x0010A96C File Offset: 0x00108B6C
		public override EDetectTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectTarget.ControlledRole;
			}
			return EDetectTargetExtensions.FromString(@string);
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x0010A990 File Offset: 0x00108B90
		public override void Write(Utf8JsonWriter writer, EDetectTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
