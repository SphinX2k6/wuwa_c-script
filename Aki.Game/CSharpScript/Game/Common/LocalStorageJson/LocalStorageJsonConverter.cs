using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x0200640C RID: 25612
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LocalStorageJsonConverter<[Nullable(2)] T> : JsonConverter<T>
	{
		// Token: 0x170075EE RID: 30190
		// (get) Token: 0x0603E1AE RID: 254382 RVA: 0x01204B03 File Offset: 0x01202D03
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603E1AF RID: 254383 RVA: 0x01204B06 File Offset: 0x01202D06
		[return: Nullable(2)]
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return LocalStorageJsonDecoder.Decode<T>(ref reader, options);
		}

		// Token: 0x0603E1B0 RID: 254384 RVA: 0x01204B0F File Offset: 0x01202D0F
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			LocalStorageJsonEncoder.Encode<T>(writer, value, options);
		}
	}
}
