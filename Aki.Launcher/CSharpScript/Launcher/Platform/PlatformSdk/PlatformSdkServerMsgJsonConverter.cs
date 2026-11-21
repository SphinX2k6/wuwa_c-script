using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A5 RID: 421
	public class PlatformSdkServerMsgJsonConverter : JsonConverter<PlatformSdkServerMsg>
	{
		// Token: 0x06000BB6 RID: 2998 RVA: 0x0004B4E8 File Offset: 0x000496E8
		public override PlatformSdkServerMsg Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return PlatformSdkServerMsg.BadHttp;
			}
			return PlatformSdkServerMsgExtensions.FromString(@string);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0004B50C File Offset: 0x0004970C
		public override void Write(Utf8JsonWriter writer, PlatformSdkServerMsg value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
