using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x0200640D RID: 25613
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorageJsonConverterFactory : JsonConverterFactory
	{
		// Token: 0x0603E1B2 RID: 254386 RVA: 0x01204B21 File Offset: 0x01202D21
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		// Token: 0x0603E1B3 RID: 254387 RVA: 0x01204B24 File Offset: 0x01202D24
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			return (JsonConverter)Activator.CreateInstance(typeof(LocalStorageJsonConverter<>).MakeGenericType(new Type[]
			{
				typeToConvert
			}));
		}
	}
}
