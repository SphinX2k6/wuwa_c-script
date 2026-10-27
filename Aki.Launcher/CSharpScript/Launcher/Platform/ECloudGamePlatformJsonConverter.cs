using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x0200012A RID: 298
	public class ECloudGamePlatformJsonConverter : JsonConverter<ECloudGamePlatform>
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x0004335C File Offset: 0x0004155C
		public override ECloudGamePlatform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECloudGamePlatform.Android;
			}
			return ECloudGamePlatformExtensions.FromString(@string);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00043380 File Offset: 0x00041580
		public override void Write(Utf8JsonWriter writer, ECloudGamePlatform value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
