using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024E RID: 590
	public class EResFileJsonConverter : JsonConverter<EResFile>
	{
		// Token: 0x06000EFB RID: 3835 RVA: 0x000593EC File Offset: 0x000575EC
		public override EResFile Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResFile.PAK;
			}
			return EResFileExtensions.FromString(@string);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00059410 File Offset: 0x00057610
		public override void Write(Utf8JsonWriter writer, EResFile value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
