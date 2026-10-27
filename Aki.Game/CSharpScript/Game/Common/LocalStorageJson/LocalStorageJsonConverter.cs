using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x0200728D RID: 29325
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LocalStorageJsonConverter<[Nullable(2)] T> : JsonConverter<T>
	{
		// Token: 0x17009E95 RID: 40597
		// (get) Token: 0x06047DEE RID: 294382 RVA: 0x012640F3 File Offset: 0x012622F3
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06047DEF RID: 294383 RVA: 0x012640F6 File Offset: 0x012622F6
		[return: Nullable(2)]
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return LocalStorageJsonDecoder.Decode<T>(ref reader, options);
		}

		// Token: 0x06047DF0 RID: 294384 RVA: 0x012640FF File Offset: 0x012622FF
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			LocalStorageJsonEncoder.Encode<T>(writer, value, options);
		}
	}
}
