using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E9 RID: 9961
	public class ESyncOpenSystemBoardFinishTimingJsonConverter : JsonConverter<ESyncOpenSystemBoardFinishTiming>
	{
		// Token: 0x0600D674 RID: 54900 RVA: 0x001F27E8 File Offset: 0x001F09E8
		public override ESyncOpenSystemBoardFinishTiming Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESyncOpenSystemBoardFinishTiming.OpenFinished;
			}
			return ESyncOpenSystemBoardFinishTimingExtensions.FromString(@string);
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x001F280C File Offset: 0x001F0A0C
		public override void Write(Utf8JsonWriter writer, ESyncOpenSystemBoardFinishTiming value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
