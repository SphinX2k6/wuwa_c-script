using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;

// Token: 0x020000CB RID: 203
[NullableContext(1)]
[Nullable(0)]
public class ResourceSystem : Singleton
{
	// Token: 0x06000637 RID: 1591 RVA: 0x00020E80 File Offset: 0x0001F080
	public bool IsMemoryTagOpen()
	{
		return this.IsOpenMemoryTag;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00020E88 File Offset: 0x0001F088
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

	// Token: 0x06000639 RID: 1593 RVA: 0x00020EFE File Offset: 0x0001F0FE
	public void SetCallbackTimeLimit(int millisecond)
	{
		this.TaskTimeLimit.Limit = (long)(millisecond * 1000);
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00020F14 File Offset: 0x0001F114
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

	// Token: 0x0600063B RID: 1595 RVA: 0x00021004 File Offset: 0x0001F204
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

	// Token: 0x0600063C RID: 1596 RVA: 0x000210C8 File Offset: 0x0001F2C8
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

	// Token: 0x0600063D RID: 1597 RVA: 0x00021168 File Offset: 0x0001F368
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

	// Token: 0x0600063E RID: 1598 RVA: 0x000211F4 File Offset: 0x0001F3F4
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

	// Token: 0x0600063F RID: 1599 RVA: 0x00021248 File Offset: 0x0001F448
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

	// Token: 0x06000640 RID: 1600 RVA: 0x000212C4 File Offset: 0x0001F4C4
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

	// Token: 0x06000641 RID: 1601 RVA: 0x000214BC File Offset: 0x0001F6BC
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

	// Token: 0x06000642 RID: 1602 RVA: 0x00021500 File Offset: 0x0001F700
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

	// Token: 0x06000643 RID: 1603 RVA: 0x00021664 File Offset: 0x0001F864
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

	// Token: 0x06000644 RID: 1604 RVA: 0x000216A4 File Offset: 0x0001F8A4
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

	// Token: 0x06000645 RID: 1605 RVA: 0x0002170C File Offset: 0x0001F90C
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

	// Token: 0x06000646 RID: 1606 RVA: 0x0002177C File Offset: 0x0001F97C
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

	// Token: 0x06000647 RID: 1607 RVA: 0x000217C4 File Offset: 0x0001F9C4
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

	// Token: 0x06000648 RID: 1608 RVA: 0x000218C8 File Offset: 0x0001FAC8
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

	// Token: 0x06000649 RID: 1609 RVA: 0x00021984 File Offset: 0x0001FB84
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

	// Token: 0x0600064A RID: 1610 RVA: 0x00021A04 File Offset: 0x0001FC04
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

	// Token: 0x0600064B RID: 1611 RVA: 0x00021A6E File Offset: 0x0001FC6E
	public int LoadAsync<[Nullable(0)] T>(string path, [Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<T, string> callback, ResourceSystem.EResourceLoadPriority priority, string memoryTag = "js_undefined") where T : UObject, IUnrealUObject
	{
		return this.LoadAsync<T>(path, callback, (int)priority, memoryTag);
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00021A7C File Offset: 0x0001FC7C
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

	// Token: 0x0600064D RID: 1613 RVA: 0x00021D3C File Offset: 0x0001FF3C
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

	// Token: 0x0600064E RID: 1614 RVA: 0x00021DEC File Offset: 0x0001FFEC
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

	// Token: 0x0600064F RID: 1615 RVA: 0x00021E56 File Offset: 0x00020056
	public bool IsAsyncLoadingThreadEnabled()
	{
		return this.InternalIsAsyncLoadingThreadEnabled;
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00021E5E File Offset: 0x0002005E
	public void DebugDumpLoadingAssets()
	{
		this.KuroResourceManager.DebugDumpLoadingAssets();
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000651 RID: 1617 RVA: 0x00021E6B File Offset: 0x0002006B
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

	// Token: 0x06000652 RID: 1618 RVA: 0x00021E8E File Offset: 0x0002008E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00021E90 File Offset: 0x00020090
	public static void ResetStaticDefaultValue()
	{
		ResourceSystem instance = ResourceSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ResourceSystem._instance = null;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00021EA9 File Offset: 0x000200A9
	static ResourceSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ResourceSystem.CreateStaticDefaultValue), new Action(ResourceSystem.ResetStaticDefaultValue));
	}

	// Token: 0x04000504 RID: 1284
	public const int CHECK_STREAMING_INTERVAL = 100;

	// Token: 0x04000505 RID: 1285
	public const int CHECK_RENDERASSETS_INTERVAL = 100;

	// Token: 0x04000506 RID: 1286
	public const float STREAMING_SOURCE_RADIUS = 7000f;

	// Token: 0x04000507 RID: 1287
	public const float RENDER_ASSETS_RADIUS = 7000f;

	// Token: 0x04000508 RID: 1288
	public const int RENDER_ASSETS_TIMEOUT = 40000;

	// Token: 0x04000509 RID: 1289
	public const int WAIT_RENDER_ASSET_DURATION = 42;

	// Token: 0x0400050A RID: 1290
	public const int SYNC_LOAD_PRIORITY = 1073741823;

	// Token: 0x0400050B RID: 1291
	public const int ASYNC_LOAD_TIMEOUT_MS = 60000;

	// Token: 0x0400050C RID: 1292
	private UKuroResourceManager KuroResourceManager;

	// Token: 0x0400050D RID: 1293
	private readonly Dictionary<int, ResourceSystem.LoadCallbackTask> LoadingTaskMap = new Dictionary<int, ResourceSystem.LoadCallbackTask>();

	// Token: 0x0400050E RID: 1294
	private readonly PriorityQueue<ResourceSystem.LoadCallbackTask> DelayTaskQueue = new PriorityQueue<ResourceSystem.LoadCallbackTask>(delegate(ResourceSystem.LoadCallbackTask a, ResourceSystem.LoadCallbackTask b)
	{
		if (a.Priority != b.Priority)
		{
			return b.Priority - a.Priority;
		}
		return a.Id - b.Id;
	});

	// Token: 0x0400050F RID: 1295
	private readonly HashSet<int> CancelIdSet = new HashSet<int>();

	// Token: 0x04000510 RID: 1296
	private readonly TimeLimit TaskTimeLimit = new TimeLimit(null);

	// Token: 0x04000511 RID: 1297
	private bool Updating;

	// Token: 0x04000512 RID: 1298
	private readonly Dictionary<string, UObject> TypeCache = new Dictionary<string, UObject>();

	// Token: 0x04000513 RID: 1299
	private readonly Stat StatLoad = Stat.Create("RS.Load", "", "");

	// Token: 0x04000514 RID: 1300
	private readonly Stat StatLoadAsync = Stat.Create("RS.LoadASync", "", "");

	// Token: 0x04000515 RID: 1301
	private readonly Stat StatLoadAsyncCallback = Stat.Create("RS.LoadAsyncCallback", "", "");

	// Token: 0x04000516 RID: 1302
	private readonly Stat StatUpdateDelayCallback = Stat.Create("RS.UpdateDelayCallback", "", "");

	// Token: 0x04000517 RID: 1303
	private int HandleId;

	// Token: 0x04000518 RID: 1304
	private bool InternalIsAsyncLoadingThreadEnabled;

	// Token: 0x04000519 RID: 1305
	public const int InvalidId = -1;

	// Token: 0x0400051A RID: 1306
	private bool IsOpenMemoryTag = true;

	// Token: 0x0400051B RID: 1307
	[Nullable(2)]
	private static ResourceSystem _instance;

	// Token: 0x020001C5 RID: 453
	[NullableContext(0)]
	public enum EResourceLoadPriority
	{
		// Token: 0x04000859 RID: 2137
		Default = 100,
		// Token: 0x0400085A RID: 2138
		Preload,
		// Token: 0x0400085B RID: 2139
		Ui,
		// Token: 0x0400085C RID: 2140
		BattleUi,
		// Token: 0x0400085D RID: 2141
		Catapult,
		// Token: 0x0400085E RID: 2142
		BeginSkill,
		// Token: 0x0400085F RID: 2143
		Max
	}

	// Token: 0x020001C6 RID: 454
	[NullableContext(0)]
	public enum EAsyncLoadResult
	{
		// Token: 0x04000861 RID: 2145
		Error = -1,
		// Token: 0x04000862 RID: 2146
		Loading,
		// Token: 0x04000863 RID: 2147
		Completed
	}

	// Token: 0x020001C7 RID: 455
	[Nullable(0)]
	public class LoadCallbackTask
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0003E52A File Offset: 0x0003C72A
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0003E532 File Offset: 0x0003C732
		public int Id { get; private set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0003E53B File Offset: 0x0003C73B
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0003E543 File Offset: 0x0003C743
		public int Priority { get; private set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0003E54C File Offset: 0x0003C74C
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0003E554 File Offset: 0x0003C754
		[Nullable(2)]
		public TimerHandle TimeoutTimer { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0003E55D File Offset: 0x0003C75D
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x0003E565 File Offset: 0x0003C765
		public Action Callback { get; private set; }

		// Token: 0x06000D54 RID: 3412 RVA: 0x0003E56E File Offset: 0x0003C76E
		public LoadCallbackTask(int id, int priority, [Nullable(2)] TimerHandle timeoutTimer, Action callback)
		{
			this.Id = id;
			this.Priority = priority;
			this.TimeoutTimer = timeoutTimer;
			this.Callback = callback;
		}
	}
}
