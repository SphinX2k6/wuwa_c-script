using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Interface;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006F RID: 111
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherResourceLib : Singleton
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x0000F790 File Offset: 0x0000D990
		public FName GetDynamicFName(string key)
		{
			FName fname;
			if (!this.CacheNameMap.TryGetValue(key, out fname))
			{
				fname = new FName(key);
				this.CacheNameMap[key] = fname;
			}
			return fname;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		public void Initialize()
		{
			if (this.IsInit)
			{
				return;
			}
			this.IsInit = true;
			this.IsOpenMemoryTag = !KuroApplication.IsBuildShipping();
			this.CallbackMap = new Dictionary<int, Action>();
			this.ResourceManager = new UKuroResourceManager();
			this.ResourceManager.LoadResourceDelegate.Bind(new Action<int>(this.OnLoadComplete));
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000F824 File Offset: 0x0000DA24
		[return: Nullable(2)]
		public T Load<[Nullable(0)] T>(string path, int priority = 0, string memoryTag = "js_call_launch") where T : UObject, IUnrealUObject
		{
			T result = default(T);
			if (this.ResourceManager == null || !this.ResourceManager.IsValid())
			{
				LauncherLog.Instance.Error("LauncherResourceLib尚未初始化，就使用了Load接口！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return result;
			}
			if (!this.CheckPath(path))
			{
				return result;
			}
			int globalId = this.GlobalId;
			this.GlobalId = globalId + 1;
			int num = globalId;
			int num2;
			if (this.IsOpenMemoryTag)
			{
				FName dynamicFName = this.GetDynamicFName(memoryTag);
				num2 = this.ResourceManager.LoadAsyncWithIdAndTag(path, num, priority, dynamicFName);
			}
			else
			{
				num2 = this.ResourceManager.LoadAsyncWithId(path, num, priority);
			}
			if (num2 == -1)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "LauncherResourceLib.Load()传入的handleId重复！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handleId", num);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return result;
			}
			UClassStackOnlyPtr uclassStackOnlyPtr = IUnrealUObject.StaticClass();
			if (!uclassStackOnlyPtr.IsValid())
			{
				LauncherLog.Instance.Error("LauncherResourceLib.Load()传入的目标类型为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return result;
			}
			if (!uclassStackOnlyPtr.IsValid())
			{
				LauncherLog.Instance.Error("LauncherResourceLib.Load()传入的目标类型无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return result;
			}
			if (num2 == 1)
			{
				return this.GetAsset<T>(path, num);
			}
			if (!this.ResourceManager.WaitComplete(num, 0f))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "LauncherResourceLib.Load()加载资源失败！";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", path);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return result;
			}
			return this.GetAsset<T>(path, num);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000F990 File Offset: 0x0000DB90
		public int LoadAsync<[Nullable(0)] T>([Nullable(2)] string path, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<T, string> callback, int priority = 0, string memoryTag = "js_call_launch") where T : UObject, IUnrealUObject
		{
			LauncherResourceLib.<>c__DisplayClass9_0<T> CS$<>8__locals1 = new LauncherResourceLib.<>c__DisplayClass9_0<T>();
			CS$<>8__locals1.callback = callback;
			CS$<>8__locals1.path = path;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.id = -1;
			if (this.ResourceManager == null || !this.ResourceManager.IsValid())
			{
				LauncherLog.Instance.Error("LauncherResourceLib尚未初始化，就使用了Load接口！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return CS$<>8__locals1.id;
			}
			if (!this.CheckPath(CS$<>8__locals1.path))
			{
				return CS$<>8__locals1.id;
			}
			LauncherResourceLib.<>c__DisplayClass9_0<T> CS$<>8__locals2 = CS$<>8__locals1;
			int globalId = this.GlobalId;
			this.GlobalId = globalId + 1;
			CS$<>8__locals2.id = globalId;
			int num;
			if (this.IsOpenMemoryTag)
			{
				FName dynamicFName = this.GetDynamicFName(memoryTag);
				num = this.ResourceManager.LoadAsyncWithIdAndTag(CS$<>8__locals1.path, CS$<>8__locals1.id, priority, dynamicFName);
			}
			else
			{
				num = this.ResourceManager.LoadAsyncWithId(CS$<>8__locals1.path, CS$<>8__locals1.id, priority);
			}
			if (num == 1)
			{
				CS$<>8__locals1.<LoadAsync>g__Cb|1();
			}
			else
			{
				this.CallbackMap[CS$<>8__locals1.id] = new Action(CS$<>8__locals1.<LoadAsync>g__Cb|1);
			}
			return CS$<>8__locals1.id;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[return: Nullable(2)]
		private unsafe T GetAsset<[Nullable(0)] T>(string path, int handleId) where T : UObject, IUnrealUObject
		{
			UObject asset = this.ResourceManager.GetAsset(handleId);
			this.ResourceManager.Release(handleId);
			UClassStackOnlyPtr uclassStackOnlyPtr = IUnrealUObject.StaticClass();
			if (!uclassStackOnlyPtr.IsValid())
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "LauncherResourceLib.Load()加载的asset的type无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return default(T);
			}
			if (asset == null)
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "LauncherResourceLib.Load()加载到的资源为空";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", path);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return default(T);
			}
			if (!asset.IsValid())
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "LauncherResourceLib.Load()加载到的资源无效";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("path", path);
				instance3.Error(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return default(T);
			}
			if (!(asset is T))
			{
				LauncherLog instance4 = LauncherLog.Instance;
				string message4 = "LauncherResourceLib.Load()加载到的资源与传入类型不匹配";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("assetType", asset.GetClass().GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("desireType", uclassStackOnlyPtr.GetName());
				instance4.Error(message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return default(T);
			}
			return asset as T;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000FC04 File Offset: 0x0000DE04
		[NullableContext(2)]
		private bool CheckPath(string path)
		{
			if (path == null)
			{
				LauncherLog.Instance.Error("路径为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (path.Length == 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "路径长度为零";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("路径", path);
				instance.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (!path.StartsWith("/"))
			{
				LauncherLog instance2 = LauncherLog.Instance;
				string message2 = "传入资源路径不符合规范";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("路径", path);
				instance2.Error(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			return true;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000FC90 File Offset: 0x0000DE90
		private void OnLoadComplete(int handleId)
		{
			Action action;
			if (this.CallbackMap != null && this.CallbackMap.TryGetValue(handleId, out action))
			{
				this.CallbackMap.Remove(handleId);
				action();
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		public static LauncherResourceLib Instance
		{
			get
			{
				if (LauncherResourceLib._instance == null)
				{
					LauncherResourceLib._instance = new LauncherResourceLib();
					LauncherResourceLib._instance.OnInit();
				}
				return LauncherResourceLib._instance;
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000FCEB File Offset: 0x0000DEEB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000FCED File Offset: 0x0000DEED
		public static void ResetStaticDefaultValue()
		{
			LauncherResourceLib instance = LauncherResourceLib._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherResourceLib._instance = null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000FD06 File Offset: 0x0000DF06
		static LauncherResourceLib()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherResourceLib.CreateStaticDefaultValue), new Action(LauncherResourceLib.ResetStaticDefaultValue));
		}

		// Token: 0x040001ED RID: 493
		private int GlobalId;

		// Token: 0x040001EE RID: 494
		[Nullable(2)]
		private UKuroResourceManager ResourceManager;

		// Token: 0x040001EF RID: 495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, Action> CallbackMap;

		// Token: 0x040001F0 RID: 496
		private bool IsInit;

		// Token: 0x040001F1 RID: 497
		private bool IsOpenMemoryTag = true;

		// Token: 0x040001F2 RID: 498
		private readonly Dictionary<string, FName> CacheNameMap = new Dictionary<string, FName>();

		// Token: 0x040001F3 RID: 499
		[Nullable(2)]
		private static LauncherResourceLib _instance;
	}
}
