using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x0200007E RID: 126
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LauncherJsonConverter<[Nullable(2)] T> : JsonConverter<T>
	{
		// Token: 0x0600034D RID: 845 RVA: 0x000118DE File Offset: 0x0000FADE
		[return: Nullable(2)]
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return LauncherJsonReader.Read<T>(ref reader, options);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000118E7 File Offset: 0x0000FAE7
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			LauncherJsonWriter.Write<T>(writer, value, options);
		}
	}
}
