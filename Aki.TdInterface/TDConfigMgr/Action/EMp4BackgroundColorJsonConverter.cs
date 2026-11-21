using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002631 RID: 9777
	public class EMp4BackgroundColorJsonConverter : JsonConverter<EMp4BackgroundColor>
	{
		// Token: 0x0600D338 RID: 54072 RVA: 0x001EB260 File Offset: 0x001E9460
		public override EMp4BackgroundColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMp4BackgroundColor.Black;
			}
			return EMp4BackgroundColorExtensions.FromString(@string);
		}

		// Token: 0x0600D339 RID: 54073 RVA: 0x001EB284 File Offset: 0x001E9484
		public override void Write(Utf8JsonWriter writer, EMp4BackgroundColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
