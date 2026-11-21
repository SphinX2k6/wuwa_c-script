using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000208 RID: 520
	public class EDownloadStateJsonConverter : JsonConverter<EDownloadState>
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x00052DC4 File Offset: 0x00050FC4
		public override EDownloadState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDownloadState.None;
			}
			return EDownloadStateExtensions.FromString(@string);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00052DE8 File Offset: 0x00050FE8
		public override void Write(Utf8JsonWriter writer, EDownloadState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
