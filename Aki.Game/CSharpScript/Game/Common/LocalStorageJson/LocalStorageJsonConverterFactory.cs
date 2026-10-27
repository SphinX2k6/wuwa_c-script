using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x0200728E RID: 29326
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorageJsonConverterFactory : JsonConverterFactory
	{
		// Token: 0x06047DF2 RID: 294386 RVA: 0x01264111 File Offset: 0x01262311
		public override bool CanConvert(Type typeToConvert)
		{
			return true;
		}

		// Token: 0x06047DF3 RID: 294387 RVA: 0x01264114 File Offset: 0x01262314
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			return (JsonConverter)Activator.CreateInstance(typeof(LocalStorageJsonConverter<>).MakeGenericType(new Type[]
			{
				typeToConvert
			}));
		}
	}
}
