using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006B RID: 107
	[NullableContext(2)]
	[Nullable(0)]
	public static class LauncherJson
	{
		// Token: 0x060002DB RID: 731 RVA: 0x0000EE38 File Offset: 0x0000D038
		public static string Stringify<T>([Nullable(1)] T value, JsonSerializerOptions options = null)
		{
			string result;
			try
			{
				if (options == null)
				{
					options = LauncherJsonSettings.GetSerializerOptions<T>();
				}
				result = JsonSerializer.Serialize<T>(value, options);
			}
			catch (Exception error)
			{
				LauncherLog.Instance.ErrorWithStack("序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = null;
			}
			return result;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000EE88 File Offset: 0x0000D088
		public static T Parse<T>([Nullable(1)] string text, JsonSerializerOptions options = null)
		{
			T result;
			try
			{
				if (options == null)
				{
					options = LauncherJsonSettings.GetSerializerOptions<T>();
				}
				result = JsonSerializer.Deserialize<T>(text, options);
			}
			catch (Exception error)
			{
				LauncherLog.Instance.ErrorWithStack("反序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = default(T);
			}
			return result;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		public static T Parse<T>(JsonElement jsonElement, JsonSerializerOptions options = null)
		{
			T result;
			try
			{
				if (options == null)
				{
					options = LauncherJsonSettings.GetSerializerOptions<T>();
				}
				result = jsonElement.Deserialize(options);
			}
			catch (Exception error)
			{
				LauncherLog.Instance.ErrorWithStack("反序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = default(T);
			}
			return result;
		}
	}
}
