using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000171 RID: 369
	[NullableContext(2)]
	[Nullable(0)]
	public static class Json
	{
		// Token: 0x06000CEC RID: 3308 RVA: 0x0003BB50 File Offset: 0x00039D50
		public static string Encode([Nullable(1)] object value, JsonSerializerOptions options = null)
		{
			string result;
			try
			{
				if (options == null)
				{
					options = JsonSettings.EncodeOptions;
				}
				result = JsonSerializer.Serialize<object>(value, options);
			}
			catch (Exception error)
			{
				Log.Instance.ErrorWithStack(ELogModule.Json, ELogAuthor.LCC, "序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = null;
			}
			return result;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0003BBA4 File Offset: 0x00039DA4
		public static string Stringify(object value, JsonSerializerOptions options = null)
		{
			string result;
			try
			{
				if (options == null)
				{
					options = JsonSettings.EncodeOptions;
				}
				result = JsonSerializer.Serialize<object>(value, options);
			}
			catch (Exception error)
			{
				Log.Instance.ErrorWithStack(ELogModule.Json, ELogAuthor.LCC, "序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = null;
			}
			return result;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0003BBF8 File Offset: 0x00039DF8
		public static T Parse<T>([Nullable(1)] string text, JsonSerializerOptions options = null)
		{
			T result;
			try
			{
				if (options == null)
				{
					options = JsonSettings.DecodeOptions;
				}
				result = JsonSerializer.Deserialize<T>(text, options);
			}
			catch (Exception error)
			{
				Log.Instance.ErrorWithStack(ELogModule.Json, ELogAuthor.LCC, "反序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = default(T);
			}
			return result;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0003BC54 File Offset: 0x00039E54
		public static T Parse<T>([Nullable(0)] ReadOnlySpan<byte> utf8Json, JsonSerializerOptions options = null)
		{
			T result;
			try
			{
				if (options == null)
				{
					options = JsonSettings.DecodeOptions;
				}
				result = JsonSerializer.Deserialize<T>(utf8Json, options);
			}
			catch (Exception error)
			{
				Log.Instance.ErrorWithStack(ELogModule.Json, ELogAuthor.LCC, "反序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = default(T);
			}
			return result;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003BCB0 File Offset: 0x00039EB0
		public static T Decode<T>([Nullable(1)] string text, JsonSerializerOptions options = null)
		{
			T result;
			try
			{
				if (options == null)
				{
					options = JsonSettings.DecodeOptions;
				}
				result = JsonSerializer.Deserialize<T>(text, options);
			}
			catch (Exception error)
			{
				Log.Instance.ErrorWithStack(ELogModule.Json, ELogAuthor.LCC, "反序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = default(T);
			}
			return result;
		}
	}
}
