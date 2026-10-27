using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002448 RID: 9288
	public class ESyncOpenSystemBoardFinishTimingJsonConverter : JsonConverter<ESyncOpenSystemBoardFinishTiming>
	{
		// Token: 0x0600C9C4 RID: 51652 RVA: 0x001D8920 File Offset: 0x001D6B20
		public override ESyncOpenSystemBoardFinishTiming Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESyncOpenSystemBoardFinishTiming.OpenFinished;
			}
			return ESyncOpenSystemBoardFinishTimingExtensions.FromString(@string);
		}

		// Token: 0x0600C9C5 RID: 51653 RVA: 0x001D8944 File Offset: 0x001D6B44
		public override void Write(Utf8JsonWriter writer, ESyncOpenSystemBoardFinishTiming value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
