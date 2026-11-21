using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;

// Token: 0x020000CD RID: 205
[NullableContext(1)]
[Nullable(0)]
public class ResourceSystem : Singleton
{
	// Token: 0x06000678 RID: 1656 RVA: 0x00021356 File Offset: 0x0001F556
	public bool IsMemoryTagOpen()
	{
		return this.IsOpenMemoryTag;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00021360 File Offset: 0x0001F560
	public void Initialize()
	{
		this.IsOpenMemoryTag = !KuroApplication.IsBuildShipping();
		this.KuroResourceManager = new UKuroResourceManager();
		this.KuroResourceManager.LoadResourceDelegate.Bind(delegate(int id)
		{
			ResourceSystem.Instance.OnLoadComplete(id);
		});
		this.LoadingTaskMap.Clear();
		this.TypeCache.Clear();
		this.InternalIsAsyncLoadingThreadEnabled = KuroApplication.IsAsyncLoadingThreadEnabled();
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000213D6 File Offset: 0x0001F5D6
	public void SetCallbackTimeLimit(int millisecond)
	{
		this.TaskTimeLimit.Limit = (long)(millisecond * 1000);
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x000213EC File Offset: 0x0001F5EC
	public unsafe void UpdateDelayCallback(bool reset = true)
	{
		if (this.Updating)
		{
			return;
		}
		this.Updating = true;
		while (!this.DelayTaskQueue.Empty && !this.TaskTimeLimit.IsTimeLimitExceeded())
		{
			ResourceSystem.LoadCallbackTask loadCallbackTask = this.DelayTaskQueue.Pop();
			if (this.CancelIdSet.Remove(loadCallbackTask.Id))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Resource;
				ELogAuthor author = ELogAuthor.LCC;
				string message = "预加载回调执行失败，任务已被取消";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ResourceSystem.Instance.Instance.DelayTaskQueue.Empty", this.DelayTaskQueue.Empty);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsTimeLimitExceeded", this.TaskTimeLimit.IsTimeLimitExceeded());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				loadCallbackTask.Callback();
			}
		}
		if (reset)
		{
			this.TaskTimeLimit.ResetCost();
		}
		this.Updating = false;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x000214DC File Offset: 0x0001F6DC
	private unsafe void PreloadTypes(HashSet<string> set, [Nullable(2)] Action callback = null, string memoyTag = "js_undefined")
	{
		if (set.Count == 0)
		{
			Action callback2 = callback;
			if (callback2 != null)
			{
				callback2();
			}
		}
		long startTime = DateTime.Now.Ticks / 10000L;
		using (HashSet<string>.Enumerator enumerator = set.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				string key = enumerator.Current;
				this.LoadTypeAsync(key, delegate
				{
					set.Remove(key);
					if (set.Count == 0)
					{
						long num = DateTime.Now.Ticks / 10000L;
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Resource;
						ELogAuthor author = ELogAuthor.LCC;
						string message = "预加载类型结束 ";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("count", set.Count);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cost", num - startTime);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						Action callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3();
					}
				}, memoyTag);
			}
		}
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x000215A0 File Offset: 0x0001F7A0
	[NullableContext(2)]
	public void PreloadSimpleTypes(Action callback = null)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string text in ClassDefine.typeDefined.Keys)
		{
			if (!this.TypeCache.ContainsKey(text) && ClassDefine.typeDefined[text].Item3 == ETypeLoadKind.Preload && ClassDefine.typeDefined[text].Item1 != ClassDefine.EType.Class)
			{
				hashSet.Add(text);
			}
		}
		this.PreloadTypes(hashSet, callback, "PreloadSimpleTypes");
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00021640 File Offset: 0x0001F840
	[NullableContext(2)]
	public void PreloadOtherTypes(Action callback = null)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string text in ClassDefine.typeDefined.Keys)
		{
			if (!this.TypeCache.ContainsKey(text) && ClassDefine.typeDefined[text].Item3 == ETypeLoadKind.Preload)
			{
				hashSet.Add(text);
			}
		}
		this.PreloadTypes(hashSet, callback, "PreloadOtherTypes");
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x000216CC File Offset: 0x0001F8CC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private ValueTuple<ClassDefine.EType, string, ETypeLoadKind>? GetTypeDefined(string name)
	{
		ValueTuple<ClassDefine.EType, string, ETypeLoadKind> value;
		if (!ClassDefine.typeDefined.TryGetValue(name, out value))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "该类型没有注册";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new ValueTuple<ClassDefine.EType, string, ETypeLoadKind>?(value);
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00021720 File Offset: 0x0001F920
	[return: Nullable(2)]
	private unsafe string GetTypePath(string name, [Nullable(new byte[]
	{
		0,
		1
	})] ValueTuple<ClassDefine.EType, string, ETypeLoadKind> define)
	{
		string item = define.Item2;
		if (string.IsNullOrEmpty(item))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "加载类型路径为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", define.Item1);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return item;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0002179C File Offset: 0x0001F99C
	private unsafe void LoadType(string name)
	{
		if (this.TypeCache.ContainsKey(name))
		{
			return;
		}
		ValueTuple<ClassDefine.EType, string, ETypeLoadKind>? typeDefined = this.GetTypeDefined(name);
		if (typeDefined == null)
		{
			return;
		}
		string typePath = this.GetTypePath(name, typeDefined.Value);
		if (string.IsNullOrEmpty(typePath))
		{
			return;
		}
		ClassDefine.EType item = typeDefined.Value.Item1;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Resource;
		ELogAuthor author = ELogAuthor.LCC;
		string message = "运行时加载类型";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", item);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("path", typePath);
		instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		UObject uobject;
		switch (item)
		{
		case ClassDefine.EType.Class:
			uobject = this.Load<UBlueprintGeneratedClass>(typePath, "js_undefined");
			break;
		case ClassDefine.EType.Struct:
			uobject = this.Load<UUserDefinedStruct>(typePath, "js_undefined");
			break;
		case ClassDefine.EType.Enum:
			uobject = this.Load<UUserDefinedEnum>(typePath, "js_undefined");
			break;
		default:
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Resource;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "加载类型错误";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("type", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("path", typePath);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		}
		if (uobject == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Resource;
			ELogAuthor author3 = ELogAuthor.LCC;
			string message3 = "加载类型失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("type", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("path", typePath);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return;
		}
		this.TypeCache[name] = uobject;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00021994 File Offset: 0x0001FB94
	[return: Nullable(2)]
	public UObject GetLoadedType(string name)
	{
		UObject result;
		if (!this.TypeCache.TryGetValue(name, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "获取已加载类型失败，调用前请先加载";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return result;
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000219D8 File Offset: 0x0001FBD8
	public unsafe void LoadTypeAsync(string name, Action callback, string memoryTag = "js_undefined")
	{
		if (this.TypeCache.ContainsKey(name))
		{
			callback();
			return;
		}
		ValueTuple<ClassDefine.EType, string, ETypeLoadKind>? typeDefined = this.GetTypeDefined(name);
		if (typeDefined == null)
		{
			return;
		}
		string typePath = this.GetTypePath(name, typeDefined.Value);
		if (string.IsNullOrEmpty(typePath))
		{
			return;
		}
		ClassDefine.EType type = typeDefined.Value.Item1;
		Action<UObject, string> callback2 = delegate([Nullable(2)] UObject asset, string p)
		{
			if (asset == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Resource;
				ELogAuthor author2 = ELogAuthor.LCC;
				string message2 = "预加载类型失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("type", type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("path", p);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			else
			{
				this.TypeCache[name] = asset;
			}
			callback();
		};
		switch (type)
		{
		case ClassDefine.EType.Class:
			this.LoadAsync<UBlueprintGeneratedClass>(typePath, callback2, 100, memoryTag);
			return;
		case ClassDefine.EType.Struct:
			this.LoadAsync<UUserDefinedStruct>(typePath, callback2, 100, memoryTag);
			return;
		case ClassDefine.EType.Enum:
			this.LoadAsync<UUserDefinedEnum>(typePath, callback2, 100, memoryTag);
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "预加载类型错误";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("path", typePath);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			callback();
			return;
		}
		}
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00021B3C File Offset: 0x0001FD3C
	private void OnLoadComplete(int id)
	{
		ResourceSystem.LoadCallbackTask item;
		if (!this.LoadingTaskMap.TryGetValue(id, out item))
		{
			return;
		}
		this.LoadingTaskMap.Remove(id);
		this.DelayTaskQueue.Push(item);
		this.UpdateDelayCallback(false);
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00021B7C File Offset: 0x0001FD7C
	private bool CheckPath(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			Log.Instance.Error(ELogModule.Resource, ELogAuthor.LCC, "路径为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (!path.StartsWith("/"))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "传入资源路径不符合规范";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00021BE4 File Offset: 0x0001FDE4
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private TWeakObjectPtr<UClass>? GetClass<[Nullable(0)] T>(string path) where T : UObject, IUnrealUObject
	{
		if (!this.CheckPath(path))
		{
			return null;
		}
		UClassStackOnlyPtr ptr = IUnrealUObject.StaticClass();
		if (!ptr.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "传入类型获取到的 UE Class 无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new TWeakObjectPtr<UClass>?(ptr.ToWeakClass());
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00021C54 File Offset: 0x0001FE54
	[return: Nullable(2)]
	private T GetAsset<[Nullable(0)] T>(string path, int id) where T : UObject, IUnrealUObject
	{
		UObject asset = this.KuroResourceManager.GetAsset(id);
		this.KuroResourceManager.Release(id);
		if (!this.CheckAsset<T>(asset, path))
		{
			return default(T);
		}
		return asset as T;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00021C9C File Offset: 0x0001FE9C
	private unsafe bool CheckAsset<[Nullable(0)] T>([Nullable(2)] UObject asset, string path) where T : UObject, IUnrealUObject
	{
		if (asset == null || !asset.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "资源加载资产无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!(asset is T))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Resource;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "传入类型与资产类型不匹配";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", typeof(T).Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("asset", asset.GetClass().GetName());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		if (UKuroResourceSystemFunctionLibrary.IsAssetBlocked(path))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Resource;
			ELogAuthor author3 = ELogAuthor.LCC;
			string message3 = "标记为废弃资源被加载";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", path);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		return true;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00021DA0 File Offset: 0x0001FFA0
	[return: Nullable(2)]
	public T Load<[Nullable(0)] T>(string path, string memoryTag = "js_undefined") where T : UObject
	{
		if (memoryTag == null)
		{
			memoryTag = "js_undefined";
		}
		if (this.GetClass<T>(path) == null)
		{
			return default(T);
		}
		int num = this.HandleId + 1;
		this.HandleId = num;
		int num2 = num;
		ResourceSystem.EAsyncLoadResult easyncLoadResult;
		if (this.IsOpenMemoryTag)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(memoryTag);
			easyncLoadResult = (ResourceSystem.EAsyncLoadResult)this.KuroResourceManager.LoadWithIdAndTag(path, num2, dynamicFName.Value);
		}
		else
		{
			easyncLoadResult = (ResourceSystem.EAsyncLoadResult)this.KuroResourceManager.LoadWithId(path, num2);
		}
		if (easyncLoadResult == ResourceSystem.EAsyncLoadResult.Error)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "资源加载异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return default(T);
		}
		return this.GetAsset<T>(path, num2);
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00021E5C File Offset: 0x0002005C
	[return: Nullable(2)]
	public T GetLoadedAsset<[Nullable(0)] T>(string path) where T : UObject
	{
		TWeakObjectPtr<UClass>? @class = this.GetClass<T>(path);
		if (@class == null)
		{
			return default(T);
		}
		UClass uclass = @class.Value.Get();
		if (uclass == null || !uclass.IsValid())
		{
			return default(T);
		}
		UObject loadedAsset = this.KuroResourceManager.GetLoadedAsset(path);
		if (!this.CheckAsset<T>(loadedAsset, path))
		{
			return default(T);
		}
		return loadedAsset as T;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00021EDC File Offset: 0x000200DC
	public bool CheckAssetLoaded<[Nullable(0)] T>(string path) where T : UObject
	{
		TWeakObjectPtr<UClass>? @class = this.GetClass<T>(path);
		if (@class == null)
		{
			return false;
		}
		if (!@class.Value.IsValid(false, false))
		{
			return false;
		}
		UObject loadedAsset = this.KuroResourceManager.GetLoadedAsset(path);
		return loadedAsset != null && loadedAsset.IsValid() && loadedAsset.IsA(@class.Value.GetClass<UClass>());
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00021F46 File Offset: 0x00020146
	public int LoadAsync<[Nullable(0)] T>(string path, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<T, string> callback, ResourceSystem.EResourceLoadPriority priority, string memoryTag = "js_undefined") where T : UObject, IUnrealUObject
	{
		return this.LoadAsync<T>(path, callback, (int)priority, memoryTag);
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00021F54 File Offset: 0x00020154
	public unsafe int LoadAsync<[Nullable(0)] T>(string path, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<T, string> callback, int priority = 100, string memoryTag = "js_undefined") where T : UObject, IUnrealUObject
	{
		ResourceSystem.<>c__DisplayClass47_0<T> CS$<>8__locals1 = new ResourceSystem.<>c__DisplayClass47_0<T>();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.callback = callback;
		CS$<>8__locals1.path = path;
		if (CS$<>8__locals1.callback == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "资源加载回调方法为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", CS$<>8__locals1.path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		if (priority < 100 || priority >= 106)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Resource;
			ELogAuthor author2 = ELogAuthor.LCC;
			string message2 = "资源加载优先级错误";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", CS$<>8__locals1.path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("priority", priority);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return -1;
		}
		ResourceSystem.<>c__DisplayClass47_0<T> CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.HandleId + 1;
		this.HandleId = num;
		CS$<>8__locals2.id = num;
		CS$<>8__locals1.callbackStat = null;
		if (this.GetClass<T>(CS$<>8__locals1.path) == null)
		{
			this.DelayTaskQueue.Push(new ResourceSystem.LoadCallbackTask(CS$<>8__locals1.id, priority, null, delegate()
			{
				CS$<>8__locals1.<>4__this.TryCallback<T>(CS$<>8__locals1.callback, default(T), CS$<>8__locals1.path, CS$<>8__locals1.callbackStat);
			}));
			return -1;
		}
		ResourceSystem.EAsyncLoadResult easyncLoadResult;
		if (this.IsOpenMemoryTag)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName(memoryTag ?? "js_undefined");
			easyncLoadResult = (ResourceSystem.EAsyncLoadResult)this.KuroResourceManager.LoadAsyncWithIdAndTag(CS$<>8__locals1.path, CS$<>8__locals1.id, priority, dynamicFName.Value);
		}
		else
		{
			easyncLoadResult = (ResourceSystem.EAsyncLoadResult)this.KuroResourceManager.LoadAsyncWithId(CS$<>8__locals1.path, CS$<>8__locals1.id, priority);
		}
		switch (easyncLoadResult)
		{
		case ResourceSystem.EAsyncLoadResult.Error:
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Resource;
			ELogAuthor author3 = ELogAuthor.LCC;
			string message3 = "资源加载错误";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", CS$<>8__locals1.path);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.DelayTaskQueue.Push(new ResourceSystem.LoadCallbackTask(CS$<>8__locals1.id, priority, null, delegate()
			{
				CS$<>8__locals1.<>4__this.TryCallback<T>(CS$<>8__locals1.callback, default(T), CS$<>8__locals1.path, CS$<>8__locals1.callbackStat);
			}));
			CS$<>8__locals1.id = -1;
			break;
		}
		case ResourceSystem.EAsyncLoadResult.Loading:
		{
			TimerHandle timerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Resource;
				ELogAuthor author4 = ELogAuthor.MZJ;
				string message4 = "资源加载超时";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("path", CS$<>8__locals1.path);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}, 60000f, null, null, true, 1f);
			this.LoadingTaskMap[CS$<>8__locals1.id] = new ResourceSystem.LoadCallbackTask(CS$<>8__locals1.id, priority, timerHandle, delegate()
			{
				if (timerHandle != null && timerHandle.Valid())
				{
					TimerSystem.Instance.Remove(timerHandle);
				}
				CS$<>8__locals1.<>4__this.TryCallback<T>(CS$<>8__locals1.callback, CS$<>8__locals1.<>4__this.GetAsset<T>(CS$<>8__locals1.path, CS$<>8__locals1.id), CS$<>8__locals1.path, CS$<>8__locals1.callbackStat);
			});
			break;
		}
		case ResourceSystem.EAsyncLoadResult.Completed:
			this.DelayTaskQueue.Push(new ResourceSystem.LoadCallbackTask(CS$<>8__locals1.id, priority, null, delegate()
			{
				CS$<>8__locals1.<>4__this.TryCallback<T>(CS$<>8__locals1.callback, CS$<>8__locals1.<>4__this.GetAsset<T>(CS$<>8__locals1.path, CS$<>8__locals1.id), CS$<>8__locals1.path, CS$<>8__locals1.callbackStat);
			}));
			this.UpdateDelayCallback(false);
			break;
		}
		return CS$<>8__locals1.id;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00022214 File Offset: 0x00020414
	[NullableContext(2)]
	private unsafe void TryCallback<T>([Nullable(new byte[]
	{
		1,
		2,
		1
	})] Action<T, string> callback, T asset, [Nullable(1)] string path, Stat stat)
	{
		double microseconds = KuroTime.GetMicroseconds64();
		try
		{
			callback(asset, path);
		}
		catch (Exception ex) when (1)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.LCC;
			string message = "资源加载回调方法执行异常";
			Exception error = ex;
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		double microseconds2 = KuroTime.GetMicroseconds64();
		this.TaskTimeLimit.AddCost(microseconds2 - microseconds);
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x000222C4 File Offset: 0x000204C4
	public void CancelAsyncLoad(int id)
	{
		this.KuroResourceManager.Release(id);
		ResourceSystem.LoadCallbackTask loadCallbackTask;
		if (this.LoadingTaskMap.TryGetValue(id, out loadCallbackTask))
		{
			if (loadCallbackTask.TimeoutTimer != null && loadCallbackTask.TimeoutTimer.Valid())
			{
				TimerSystem.Instance.Remove(loadCallbackTask.TimeoutTimer);
			}
			this.LoadingTaskMap.Remove(id);
			return;
		}
		this.CancelIdSet.Add(id);
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0002232E File Offset: 0x0002052E
	public bool IsAsyncLoadingThreadEnabled()
	{
		return this.InternalIsAsyncLoadingThreadEnabled;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00022336 File Offset: 0x00020536
	public void DebugDumpLoadingAssets()
	{
		this.KuroResourceManager.DebugDumpLoadingAssets();
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000692 RID: 1682 RVA: 0x00022343 File Offset: 0x00020543
	public static ResourceSystem Instance
	{
		get
		{
			if (ResourceSystem._instance == null)
			{
				ResourceSystem._instance = new ResourceSystem();
				ResourceSystem._instance.OnInit();
			}
			return ResourceSystem._instance;
		}
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00022366 File Offset: 0x00020566
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00022368 File Offset: 0x00020568
	public static void ResetStaticDefaultValue()
	{
		ResourceSystem instance = ResourceSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ResourceSystem._instance = null;
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00022381 File Offset: 0x00020581
	static ResourceSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResourceSystem.CreateStaticDefaultValue), new Action(ResourceSystem.ResetStaticDefaultValue));
	}

	// Token: 0x04000512 RID: 1298
	public const int CHECK_STREAMING_INTERVAL = 100;

	// Token: 0x04000513 RID: 1299
	public const int CHECK_RENDERASSETS_INTERVAL = 100;

	// Token: 0x04000514 RID: 1300
	public const float STREAMING_SOURCE_RADIUS = 7000f;

	// Token: 0x04000515 RID: 1301
	public const float RENDER_ASSETS_RADIUS = 7000f;

	// Token: 0x04000516 RID: 1302
	public const int RENDER_ASSETS_TIMEOUT = 40000;

	// Token: 0x04000517 RID: 1303
	public const int WAIT_RENDER_ASSET_DURATION = 42;

	// Token: 0x04000518 RID: 1304
	public const int SYNC_LOAD_PRIORITY = 1073741823;

	// Token: 0x04000519 RID: 1305
	public const int ASYNC_LOAD_TIMEOUT_MS = 60000;

	// Token: 0x0400051A RID: 1306
	private UKuroResourceManager KuroResourceManager;

	// Token: 0x0400051B RID: 1307
	private readonly Dictionary<int, ResourceSystem.LoadCallbackTask> LoadingTaskMap = new Dictionary<int, ResourceSystem.LoadCallbackTask>();

	// Token: 0x0400051C RID: 1308
	private readonly PriorityQueue<ResourceSystem.LoadCallbackTask> DelayTaskQueue = new PriorityQueue<ResourceSystem.LoadCallbackTask>(delegate(ResourceSystem.LoadCallbackTask a, ResourceSystem.LoadCallbackTask b)
	{
		if (a.Priority != b.Priority)
		{
			return b.Priority - a.Priority;
		}
		return a.Id - b.Id;
	});

	// Token: 0x0400051D RID: 1309
	private readonly HashSet<int> CancelIdSet = new HashSet<int>();

	// Token: 0x0400051E RID: 1310
	private readonly TimeLimit TaskTimeLimit = new TimeLimit(null);

	// Token: 0x0400051F RID: 1311
	private bool Updating;

	// Token: 0x04000520 RID: 1312
	private readonly Dictionary<string, UObject> TypeCache = new Dictionary<string, UObject>();

	// Token: 0x04000521 RID: 1313
	private readonly Stat StatLoad = Stat.Create("RS.Load", "", "");

	// Token: 0x04000522 RID: 1314
	private readonly Stat StatLoadAsync = Stat.Create("RS.LoadASync", "", "");

	// Token: 0x04000523 RID: 1315
	private readonly Stat StatLoadAsyncCallback = Stat.Create("RS.LoadAsyncCallback", "", "");

	// Token: 0x04000524 RID: 1316
	private readonly Stat StatUpdateDelayCallback = Stat.Create("RS.UpdateDelayCallback", "", "");

	// Token: 0x04000525 RID: 1317
	private int HandleId;

	// Token: 0x04000526 RID: 1318
	private bool InternalIsAsyncLoadingThreadEnabled;

	// Token: 0x04000527 RID: 1319
	public const int InvalidId = -1;

	// Token: 0x04000528 RID: 1320
	private bool IsOpenMemoryTag = true;

	// Token: 0x04000529 RID: 1321
	[Nullable(2)]
	private static ResourceSystem _instance;

	// Token: 0x020001CA RID: 458
	[NullableContext(0)]
	public enum EResourceLoadPriority
	{
		// Token: 0x0400087B RID: 2171
		Default = 100,
		// Token: 0x0400087C RID: 2172
		Preload,
		// Token: 0x0400087D RID: 2173
		Ui,
		// Token: 0x0400087E RID: 2174
		BattleUi,
		// Token: 0x0400087F RID: 2175
		Catapult,
		// Token: 0x04000880 RID: 2176
		BeginSkill,
		// Token: 0x04000881 RID: 2177
		Max
	}

	// Token: 0x020001CB RID: 459
	[NullableContext(0)]
	public enum EAsyncLoadResult
	{
		// Token: 0x04000883 RID: 2179
		Error = -1,
		// Token: 0x04000884 RID: 2180
		Loading,
		// Token: 0x04000885 RID: 2181
		Completed
	}

	// Token: 0x020001CC RID: 460
	[Nullable(0)]
	public class LoadCallbackTask
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0003F3C1 File Offset: 0x0003D5C1
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x0003F3C9 File Offset: 0x0003D5C9
		public int Id { get; private set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0003F3D2 File Offset: 0x0003D5D2
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x0003F3DA File Offset: 0x0003D5DA
		public int Priority { get; private set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0003F3E3 File Offset: 0x0003D5E3
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x0003F3EB File Offset: 0x0003D5EB
		[Nullable(2)]
		public TimerHandle TimeoutTimer { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0003F3F4 File Offset: 0x0003D5F4
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x0003F3FC File Offset: 0x0003D5FC
		public Action Callback { get; private set; }

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003F405 File Offset: 0x0003D605
		public LoadCallbackTask(int id, int priority, [Nullable(2)] TimerHandle timeoutTimer, Action callback)
		{
			this.Id = id;
			this.Priority = priority;
			this.TimeoutTimer = timeoutTimer;
			this.Callback = callback;
		}
	}
}
