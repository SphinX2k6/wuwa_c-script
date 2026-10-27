using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Core.Common
{
	// Token: 0x0200016C RID: 364
	[NullableContext(2)]
	[Nullable(0)]
	public static class Json
	{
		// Token: 0x06000C91 RID: 3217 RVA: 0x0003AE8C File Offset: 0x0003908C
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

		// Token: 0x06000C92 RID: 3218 RVA: 0x0003AEE0 File Offset: 0x000390E0
		public static string Stringify<T>([Nullable(1)] T value, JsonSerializerOptions options = null)
		{
			string result;
			try
			{
				if (options == null)
				{
					options = JsonSettings.EncodeOptions;
				}
				result = JsonSerializer.Serialize<T>(value, options);
			}
			catch (Exception error)
			{
				Log.Instance.ErrorWithStack(ELogModule.Json, ELogAuthor.LCC, "序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = null;
			}
			return result;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0003AF34 File Offset: 0x00039134
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

		// Token: 0x06000C94 RID: 3220 RVA: 0x0003AF90 File Offset: 0x00039190
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

		// Token: 0x06000C95 RID: 3221 RVA: 0x0003AFEC File Offset: 0x000391EC
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
