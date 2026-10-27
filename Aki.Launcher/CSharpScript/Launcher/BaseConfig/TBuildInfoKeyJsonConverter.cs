using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000275 RID: 629
	public class TBuildInfoKeyJsonConverter : JsonConverter<TBuildInfoKey>
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x00059440 File Offset: 0x00057640
		public override TBuildInfoKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TBuildInfoKey.BuildId;
			}
			return TBuildInfoKeyExtensions.FromString(@string);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00059464 File Offset: 0x00057664
		public override void Write(Utf8JsonWriter writer, TBuildInfoKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
