using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000203 RID: 515
	public class EDownloadStateJsonConverter : JsonConverter<EDownloadState>
	{
		// Token: 0x06000D3C RID: 3388 RVA: 0x000502D8 File Offset: 0x0004E4D8
		public override EDownloadState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDownloadState.None;
			}
			return EDownloadStateExtensions.FromString(@string);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000502FC File Offset: 0x0004E4FC
		public override void Write(Utf8JsonWriter writer, EDownloadState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
