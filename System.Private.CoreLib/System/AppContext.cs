using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Loader;
using System.Runtime.Versioning;
using System.Threading;

namespace System
{
	// Token: 0x020000C5 RID: 197
	[NullableContext(1)]
	[Nullable(0)]
	public static class AppContext
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0001D245 File Offset: 0x0001B445
		public static string BaseDirectory
		{
			get
			{
				string result;
				if ((result = (AppContext.GetData("APP_CONTEXT_BASE_DIRECTORY") as string)) == null && (result = AppContext.s_defaultBaseDirectory) == null)
				{
					result = (AppContext.s_defaultBaseDirectory = AppContext.GetBaseDirectoryCore());
				}
				return result;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0001D26E File Offset: 0x0001B46E
		[Nullable(2)]
		public static string TargetFrameworkName
		{
			[NullableContext(2)]
			get
			{
				Assembly entryAssembly = Assembly.GetEntryAssembly();
				if (entryAssembly == null)
				{
					return null;
				}
				TargetFrameworkAttribute customAttribute = entryAssembly.GetCustomAttribute<TargetFrameworkAttribute>();
				if (customAttribute == null)
				{
					return null;
				}
				return customAttribute.FrameworkName;
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0001D28C File Offset: 0x0001B48C
		[return: Nullable(2)]
		public static object GetData(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (AppContext.s_dataStore == null)
			{
				return null;
			}
			Dictionary<string, object> obj = AppContext.s_dataStore;
			object result;
			lock (obj)
			{
				AppContext.s_dataStore.TryGetValue(name, out result);
			}
			return result;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001D2E8 File Offset: 0x0001B4E8
		public static void SetData(string name, [Nullable(2)] object data)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (AppContext.s_dataStore == null)
			{
				Interlocked.CompareExchange<Dictionary<string, object>>(ref AppContext.s_dataStore, new Dictionary<string, object>(), null);
			}
			Dictionary<string, object> obj = AppContext.s_dataStore;
			lock (obj)
			{
				AppContext.s_dataStore[name] = data;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000952 RID: 2386 RVA: 0x0001D350 File Offset: 0x0001B550
		// (remove) Token: 0x06000953 RID: 2387 RVA: 0x0001D384 File Offset: 0x0001B584
		[Nullable(2)]
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(UnhandledExceptionEventArgs))]
		internal static event UnhandledExceptionEventHandler UnhandledException;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000954 RID: 2388 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		// (remove) Token: 0x06000955 RID: 2389 RVA: 0x0001D3EC File Offset: 0x0001B5EC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicConstructors, typeof(FirstChanceExceptionEventArgs))]
		internal static event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

		// Token: 0x06000956 RID: 2390 RVA: 0x0001D41F File Offset: 0x0001B61F
		internal static void OnProcessExit()
		{
			AssemblyLoadContext.OnProcessExit();
			if (EventSource.IsSupported)
			{
				EventListener.DisposeOnShutdown();
			}
			AppDomain.OnProcessExit();
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001D438 File Offset: 0x0001B638
		public static bool TryGetSwitch(string switchName, out bool isEnabled)
		{
			ArgumentException.ThrowIfNullOrEmpty(switchName, "switchName");
			if (AppContext.s_switches != null)
			{
				Dictionary<string, bool> obj = AppContext.s_switches;
				lock (obj)
				{
					if (AppContext.s_switches.TryGetValue(switchName, out isEnabled))
					{
						return true;
					}
				}
			}
			string text = AppContext.GetData(switchName) as string;
			if (text != null && bool.TryParse(text, out isEnabled))
			{
				return true;
			}
			isEnabled = false;
			return false;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		public static void SetSwitch(string switchName, bool isEnabled)
		{
			ArgumentException.ThrowIfNullOrEmpty(switchName, "switchName");
			if (AppContext.s_switches == null)
			{
				Interlocked.CompareExchange<Dictionary<string, bool>>(ref AppContext.s_switches, new Dictionary<string, bool>(), null);
			}
			Dictionary<string, bool> obj = AppContext.s_switches;
			lock (obj)
			{
				AppContext.s_switches[switchName] = isEnabled;
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001D520 File Offset: 0x0001B720
		internal unsafe static void Setup(char** pNames, uint* pNameLengths, char** pValues, uint* pValueLengths, int count)
		{
			AppContext.s_dataStore = new Dictionary<string, object>(count);
			for (int i = 0; i < count; i++)
			{
				AppContext.s_dataStore.Add(new string(*(IntPtr*)(pNames + (IntPtr)i * (IntPtr)sizeof(char*) / (IntPtr)sizeof(char*)), 0, (int)pNameLengths[i]), new string(*(IntPtr*)(pValues + (IntPtr)i * (IntPtr)sizeof(char*) / (IntPtr)sizeof(char*)), 0, (int)pValueLengths[i]));
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0001D584 File Offset: 0x0001B784
		[UnconditionalSuppressMessage("SingleFile", "IL3000: Avoid accessing Assembly file path when publishing as a single file", Justification = "Single File apps should always set APP_CONTEXT_BASE_DIRECTORY therefore code handles Assembly.Location equals null")]
		private static string GetBaseDirectoryCore()
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			string text = Path.GetDirectoryName((entryAssembly != null) ? entryAssembly.Location : null);
			if (text == null)
			{
				return string.Empty;
			}
			if (!Path.EndsInDirectorySeparator(text))
			{
				text += "\\";
			}
			return text;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		internal static void LogSwitchValues(RuntimeEventSource ev)
		{
			if (AppContext.s_switches != null)
			{
				Dictionary<string, bool> obj = AppContext.s_switches;
				lock (obj)
				{
					foreach (KeyValuePair<string, bool> keyValuePair in AppContext.s_switches)
					{
						ev.LogAppContextSwitch(keyValuePair.Key, (keyValuePair.Value > false) ? 1 : 0);
					}
				}
			}
			if (AppContext.s_dataStore != null)
			{
				Dictionary<string, object> obj2 = AppContext.s_dataStore;
				lock (obj2)
				{
					if (AppContext.s_switches != null)
					{
						Dictionary<string, bool> obj = AppContext.s_switches;
						lock (obj)
						{
							AppContext.<LogSwitchValues>g__LogDataStore|20_0(ev, AppContext.s_switches);
							return;
						}
					}
					AppContext.<LogSwitchValues>g__LogDataStore|20_0(ev, null);
				}
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001D6CC File Offset: 0x0001B8CC
		[CompilerGenerated]
		internal static void <LogSwitchValues>g__LogDataStore|20_0(RuntimeEventSource ev, Dictionary<string, bool> switches)
		{
			foreach (KeyValuePair<string, object> keyValuePair in AppContext.s_dataStore)
			{
				string text = keyValuePair.Value as string;
				bool flag;
				if (text != null && bool.TryParse(text, out flag) && (switches == null || !switches.ContainsKey(keyValuePair.Key)))
				{
					ev.LogAppContextSwitch(keyValuePair.Key, (flag > false) ? 1 : 0);
				}
			}
		}

		// Token: 0x040002C5 RID: 709
		private static Dictionary<string, object> s_dataStore;

		// Token: 0x040002C6 RID: 710
		private static Dictionary<string, bool> s_switches;

		// Token: 0x040002C7 RID: 711
		private static string s_defaultBaseDirectory;
	}
}
