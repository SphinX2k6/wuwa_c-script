using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Platform
{
	// Token: 0x0200012E RID: 302
	public class ECloudGamePlatformJsonConverter : JsonConverter<ECloudGamePlatform>
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x00045770 File Offset: 0x00043970
		public override ECloudGamePlatform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECloudGamePlatform.Android;
			}
			return ECloudGamePlatformExtensions.FromString(@string);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00045794 File Offset: 0x00043994
		public override void Write(Utf8JsonWriter writer, ECloudGamePlatform value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
