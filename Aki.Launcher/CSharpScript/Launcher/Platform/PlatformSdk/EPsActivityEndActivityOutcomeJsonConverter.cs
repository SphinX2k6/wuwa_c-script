using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A7 RID: 423
	public class EPsActivityEndActivityOutcomeJsonConverter : JsonConverter<EPsActivityEndActivityOutcome>
	{
		// Token: 0x06000BBF RID: 3007 RVA: 0x0004B640 File Offset: 0x00049840
		public override EPsActivityEndActivityOutcome Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPsActivityEndActivityOutcome.Completed;
			}
			return EPsActivityEndActivityOutcomeExtensions.FromString(@string);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0004B664 File Offset: 0x00049864
		public override void Write(Utf8JsonWriter writer, EPsActivityEndActivityOutcome value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
