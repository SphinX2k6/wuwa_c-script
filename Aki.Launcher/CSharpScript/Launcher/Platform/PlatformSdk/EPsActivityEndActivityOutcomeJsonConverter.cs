using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A3 RID: 419
	public class EPsActivityEndActivityOutcomeJsonConverter : JsonConverter<EPsActivityEndActivityOutcome>
	{
		// Token: 0x06000B88 RID: 2952 RVA: 0x00048E50 File Offset: 0x00047050
		public override EPsActivityEndActivityOutcome Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPsActivityEndActivityOutcome.Completed;
			}
			return EPsActivityEndActivityOutcomeExtensions.FromString(@string);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00048E74 File Offset: 0x00047074
		public override void Write(Utf8JsonWriter writer, EPsActivityEndActivityOutcome value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
