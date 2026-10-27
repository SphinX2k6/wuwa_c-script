using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001293 RID: 4755
	public class ESpecialProcessJsonConverter : JsonConverter<ESpecialProcess>
	{
		// Token: 0x06006B3E RID: 27454 RVA: 0x00101698 File Offset: 0x000FF898
		public override ESpecialProcess Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialProcess.LowMemorySceneSwitch;
			}
			return ESpecialProcessExtensions.FromString(@string);
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x001016BC File Offset: 0x000FF8BC
		public override void Write(Utf8JsonWriter writer, ESpecialProcess value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
