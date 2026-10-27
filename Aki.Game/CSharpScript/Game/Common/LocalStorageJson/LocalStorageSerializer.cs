using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x02007291 RID: 29329
	[NullableContext(2)]
	[Nullable(0)]
	public static class LocalStorageSerializer
	{
		// Token: 0x06047E1B RID: 294427 RVA: 0x01265280 File Offset: 0x01263480
		public unsafe static string Encode<T>([Nullable(1)] T value)
		{
			string result;
			try
			{
				JsonSerializerOptions serializerOptions = LocalStorageJsonContext.GetSerializerOptions<T>();
				result = JsonSerializer.Serialize<T>(value, serializerOptions);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "序列化异常";
				Exception error = ex;
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("type", typeof(T).Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("key", LocalStorageJsonContext.GetCurrentProcessKey());
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				result = null;
			}
			return result;
		}

		// Token: 0x06047E1C RID: 294428 RVA: 0x0126535C File Offset: 0x0126355C
		public unsafe static T Decode<T>([Nullable(1)] string text)
		{
			T result;
			try
			{
				JsonSerializerOptions serializerOptions = LocalStorageJsonContext.GetSerializerOptions<T>();
				result = JsonSerializer.Deserialize<T>(text, serializerOptions);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LocalStorage;
				ELogAuthor author = ELogAuthor.MZJ;
				string message = "反序列化异常";
				Exception error = ex;
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("text", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("type", typeof(T).Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("key", LocalStorageJsonContext.GetCurrentProcessKey());
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				result = default(T);
			}
			return result;
		}
	}
}
