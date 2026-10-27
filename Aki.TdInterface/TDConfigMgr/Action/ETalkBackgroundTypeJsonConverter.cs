using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002450 RID: 9296
	public class ETalkBackgroundTypeJsonConverter : JsonConverter<ETalkBackgroundType>
	{
		// Token: 0x0600C9E8 RID: 51688 RVA: 0x001DB0A8 File Offset: 0x001D92A8
		public override ETalkBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkBackgroundType.Clean;
			}
			return ETalkBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x001DB0CC File Offset: 0x001D92CC
		public override void Write(Utf8JsonWriter writer, ETalkBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
