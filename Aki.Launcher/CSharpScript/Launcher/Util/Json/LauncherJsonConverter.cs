using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Util.Json
{
	// Token: 0x02000081 RID: 129
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LauncherJsonConverter<[Nullable(2)] T> : JsonConverter<T>
	{
		// Token: 0x0600035D RID: 861 RVA: 0x00012762 File Offset: 0x00010962
		[return: Nullable(2)]
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return LauncherJsonReader.Read<T>(ref reader, options);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001276B File Offset: 0x0001096B
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			LauncherJsonWriter.Write<T>(writer, value, options);
		}
	}
}
