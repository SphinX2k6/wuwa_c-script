using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006D RID: 109
	[NullableContext(2)]
	[Nullable(0)]
	public static class LauncherJson
	{
		// Token: 0x060002DF RID: 735 RVA: 0x0000F360 File Offset: 0x0000D560
		public static string Stringify(object value, JsonSerializerOptions options = null)
		{
			string result;
			try
			{
				if (options == null)
				{
					options = LauncherJsonSettings.GetSerializerOptions<object>();
				}
				result = JsonSerializer.Serialize<object>(value, options);
			}
			catch (Exception error)
			{
				LauncherLog.Instance.ErrorWithStack("序列化异常", error, default(ReadOnlySpan<ValueTuple<string, object>>));
				result = null;
			}
			return result;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
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

		// Token: 0x060002E1 RID: 737 RVA: 0x0000F408 File Offset: 0x0000D608
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
