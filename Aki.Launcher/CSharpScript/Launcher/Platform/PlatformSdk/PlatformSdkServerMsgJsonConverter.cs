using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A1 RID: 417
	public class PlatformSdkServerMsgJsonConverter : JsonConverter<PlatformSdkServerMsg>
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x00048CF8 File Offset: 0x00046EF8
		public override PlatformSdkServerMsg Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return PlatformSdkServerMsg.BadHttp;
			}
			return PlatformSdkServerMsgExtensions.FromString(@string);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00048D1C File Offset: 0x00046F1C
		public override void Write(Utf8JsonWriter writer, PlatformSdkServerMsg value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
