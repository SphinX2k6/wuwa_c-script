using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F1 RID: 9969
	public class ETalkBackgroundTypeJsonConverter : JsonConverter<ETalkBackgroundType>
	{
		// Token: 0x0600D698 RID: 54936 RVA: 0x001F5118 File Offset: 0x001F3318
		public override ETalkBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkBackgroundType.Clean;
			}
			return ETalkBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D699 RID: 54937 RVA: 0x001F513C File Offset: 0x001F333C
		public override void Write(Utf8JsonWriter writer, ETalkBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
