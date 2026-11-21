using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x02002890 RID: 10384
[NullableContext(1)]
[Nullable(0)]
public class PlotAssetManager
{
	// Token: 0x0601A503 RID: 107779 RVA: 0x0082514E File Offset: 0x0082334E
	public void Init()
	{
		this.HoldPreloadObject = new UHoldPreloadObject(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
	}

	// Token: 0x0601A504 RID: 107780 RVA: 0x00825162 File Offset: 0x00823362
	public bool CheckCanLoad(string id, int priority)
	{
		return priority > 100 || this.LoadStateMap.Count == 0;
	}

	// Token: 0x0601A505 RID: 107781 RVA: 0x0082517C File Offset: 0x0082337C
	public void AddPending(string id, int priority)
	{
		if (this.IdAssetElementMap.ContainsKey(id))
		{
			return;
		}
		if (this.IdPendingMap.ContainsKey(id))
		{
			IPreloadPlot preloadPlot = this.IdPendingMap[id];
			((PreloadPlot)preloadPlot).Priority = priority;
			this.PendingList.Update(preloadPlot);
			return;
		}
		PreloadPlot preloadPlot2 = new PreloadPlot
		{
			Id = id,
			Priority = priority
		};
		this.IdPendingMap[id] = preloadPlot2;
		this.PendingList.Push(preloadPlot2);
	}

	// Token: 0x0601A506 RID: 107782 RVA: 0x008251FA File Offset: 0x008233FA
	public void RemovePending(string id)
	{
		if (!this.IdPendingMap.ContainsKey(id))
		{
			return;
		}
		this.PendingList.Remove(this.IdPendingMap[id]);
		this.IdPendingMap.Remove(id);
	}

	// Token: 0x0601A507 RID: 107783 RVA: 0x00825230 File Offset: 0x00823430
	[NullableContext(2)]
	public IPreloadPlot CheckAndGetPendingPreload()
	{
		if (this.PendingList.Size == 0)
		{
			return null;
		}
		IPreloadPlot top = this.PendingList.Top;
		if (top != null && this.CheckCanLoad(top.Id, top.Priority))
		{
			this.IdPendingMap.Remove(top.Id);
			return this.PendingList.Pop();
		}
		return null;
	}

	// Token: 0x0601A508 RID: 107784 RVA: 0x00825290 File Offset: 0x00823490
	[return: Nullable(2)]
	public AssetElement AddPlotAssetElement(string id)
	{
		if (this.IdAssetElementMap.ContainsKey(id))
		{
			return null;
		}
		AssetElement assetElement = new AssetElement(null);
		assetElement.AddObjectCallback = new Action<UObject, string>(this.OnObjectCallback);
		this.IdAssetElementMap[id] = assetElement;
		return assetElement;
	}

	// Token: 0x0601A509 RID: 107785 RVA: 0x008252D4 File Offset: 0x008234D4
	public bool RemovePlotAssetElement(string id)
	{
		if (!this.IdAssetElementMap.ContainsKey(id))
		{
			return false;
		}
		AssetElement assetElement = this.IdAssetElementMap[id];
		foreach (string key in assetElement.LoadingSet)
		{
			this.PathKeyMap.Remove(key);
		}
		foreach (string text in assetElement.LoadedSet)
		{
			int entityId;
			if (!this.PathKeyMap.TryGetValue(text, out entityId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Preload;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[预加载][Plot] 卸载资源时Key已丢失，跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", text);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.HoldPreloadObject.RemoveEntityAssets(entityId);
				this.PathKeyMap.Remove(text);
			}
		}
		this.IdAssetElementMap.Remove(id);
		PlotAssetExtra valueOrDefault = this.ExtraAssetMap.GetValueOrDefault(id);
		this.ExtraAssetMap.Remove(id);
		if (!string.IsNullOrEmpty((valueOrDefault != null) ? valueOrDefault.VideoPath : null))
		{
			this.VideoPathSet.Remove(valueOrDefault.VideoPath);
		}
		bool flag = true;
		using (Dictionary<string, PlotAssetExtra>.ValueCollection.Enumerator enumerator2 = this.ExtraAssetMap.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (!string.IsNullOrEmpty(enumerator2.Current.VideoPath))
				{
					flag = false;
					break;
				}
			}
		}
		if (flag && this.VideoViewActor != null)
		{
			UiActorPool.Instance.RecycleAsync(this.VideoViewActor, this.VideoViewActor.Path);
			this.VideoViewActor = null;
		}
		if (((valueOrDefault != null) ? valueOrDefault.QteIds : null) != null)
		{
			foreach (int item in valueOrDefault.QteIds)
			{
				this.QteIdSet.Remove(item);
			}
		}
		CommonQteController.Instance.ClearPreloadQteRes();
		return true;
	}

	// Token: 0x0601A50A RID: 107786 RVA: 0x00825510 File Offset: 0x00823710
	public void AddPath(AssetElement assetElement, string path)
	{
		if (assetElement.AddOther(path))
		{
			int assetKey = this.AssetKey;
			this.AssetKey = assetKey + 1;
			int value = assetKey;
			this.PathKeyMap[path] = value;
		}
	}

	// Token: 0x0601A50B RID: 107787 RVA: 0x00825548 File Offset: 0x00823748
	private void OnObjectCallback(UObject @object, string path)
	{
		if (!this.PathKeyMap.ContainsKey(path))
		{
			return;
		}
		int entityId = this.PathKeyMap[path];
		this.HoldPreloadObject.AddEntityAsset(entityId, @object);
	}

	// Token: 0x0601A50C RID: 107788 RVA: 0x00825580 File Offset: 0x00823780
	public void RemoveAllPreload()
	{
		this.ExtraAssetMap.Clear();
		this.QteIdSet.Clear();
		CommonQteController.Instance.ClearPreloadQteRes();
		this.VideoPathSet.Clear();
		UiPoolActor videoViewActor = this.VideoViewActor;
		if (videoViewActor != null)
		{
			videoViewActor.Clear();
		}
		this.VideoViewActor = null;
		this.PendingList.Clear();
		this.IdPendingMap.Clear();
		this.IdAssetElementMap.Clear();
		this.PathKeyMap.Clear();
		if (this.HoldPreloadObject != null)
		{
			this.HoldPreloadObject.Clear();
		}
	}

	// Token: 0x0601A50D RID: 107789 RVA: 0x0082560F File Offset: 0x0082380F
	public void Clear()
	{
		this.RemoveAllPreload();
		this.HoldPreloadObject = null;
	}

	// Token: 0x0601A50E RID: 107790 RVA: 0x00825620 File Offset: 0x00823820
	public int GetAsset<[Nullable(0)] T>(string path, [Nullable(new byte[]
	{
		1,
		2,
		1
	})] Action<T, string> callback) where T : UObject
	{
		T assetInternal = this.GetAssetInternal<T>(path);
		if (assetInternal != null)
		{
			callback(assetInternal, path);
			return -1;
		}
		return ResourceSystem.Instance.LoadAsync<T>(path, callback, 100, "js_undefined");
	}

	// Token: 0x0601A50F RID: 107791 RVA: 0x0082565C File Offset: 0x0082385C
	[return: Nullable(2)]
	private T GetAssetInternal<[Nullable(0)] T>(string path) where T : UObject
	{
		if (this.PathKeyMap.ContainsKey(path))
		{
			int key = this.PathKeyMap[path];
			FPreloadObjectCollection fpreloadObjectCollection;
			if (this.HoldPreloadObject.EntityAssetMap.TryGetValue(key, out fpreloadObjectCollection) && fpreloadObjectCollection != null && fpreloadObjectCollection.Assets.Num() > 0)
			{
				return (T)((object)fpreloadObjectCollection.Assets.Get(0));
			}
		}
		return default(T);
	}

	// Token: 0x0601A510 RID: 107792 RVA: 0x008256CC File Offset: 0x008238CC
	public List<UObject> GetAllLoadedAssets(string id)
	{
		List<UObject> list = new List<UObject>();
		AssetElement valueOrDefault = this.IdAssetElementMap.GetValueOrDefault(id);
		if (valueOrDefault == null)
		{
			return list;
		}
		foreach (string key in valueOrDefault.LoadedSet)
		{
			int key2;
			FPreloadObjectCollection fpreloadObjectCollection;
			if (this.PathKeyMap.TryGetValue(key, out key2) && this.HoldPreloadObject != null && this.HoldPreloadObject.EntityAssetMap.TryGetValue(key2, out fpreloadObjectCollection) && fpreloadObjectCollection != null && fpreloadObjectCollection.Assets.Num() > 0)
			{
				list.Add(fpreloadObjectCollection.Assets.Get(0));
			}
		}
		return list;
	}

	// Token: 0x0601A511 RID: 107793 RVA: 0x0082578C File Offset: 0x0082398C
	[NullableContext(0)]
	public UniTask<bool> LoadExtraAsset([Nullable(1)] PlotAssetExtra extraData)
	{
		PlotAssetManager.<LoadExtraAsset>d__25 <LoadExtraAsset>d__;
		<LoadExtraAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadExtraAsset>d__.<>4__this = this;
		<LoadExtraAsset>d__.extraData = extraData;
		<LoadExtraAsset>d__.<>1__state = -1;
		<LoadExtraAsset>d__.<>t__builder.Start<PlotAssetManager.<LoadExtraAsset>d__25>(ref <LoadExtraAsset>d__);
		return <LoadExtraAsset>d__.<>t__builder.Task;
	}

	// Token: 0x0601A512 RID: 107794 RVA: 0x008257D8 File Offset: 0x008239D8
	[return: Nullable(2)]
	private static T TryGetComponentByIndex<[Nullable(0)] T>([Nullable(2)] AActor actor, int index) where T : UActorComponent, IUnrealUObject
	{
		if (actor == null)
		{
			return default(T);
		}
		AUIBaseActor auibaseActor = (AUIBaseActor)actor;
		ULGUIComponentsRegistry componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(auibaseActor);
		if (componentsRegistry == null)
		{
			AUIBaseActor childActorByHierarchyIndex = LguiUtil.Instance.GetChildActorByHierarchyIndex(auibaseActor, 0);
			if (childActorByHierarchyIndex != null)
			{
				componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(childActorByHierarchyIndex);
				if (componentsRegistry == null)
				{
					childActorByHierarchyIndex = LguiUtil.Instance.GetChildActorByHierarchyIndex(childActorByHierarchyIndex, 0);
					if (childActorByHierarchyIndex != null)
					{
						componentsRegistry = LguiUtil.Instance.GetComponentsRegistry(childActorByHierarchyIndex);
					}
				}
			}
		}
		if (componentsRegistry == null)
		{
			return default(T);
		}
		AActor aactor = componentsRegistry.Components.Get(index);
		return ((aactor != null) ? aactor.GetComponentByClass(IUnrealUObject.StaticClass()) : null) as T;
	}

	// Token: 0x0601A513 RID: 107795 RVA: 0x00825884 File Offset: 0x00823A84
	[NullableContext(0)]
	public UniTask<bool> LoadVideoViewAsync([Nullable(1)] string videoPath)
	{
		PlotAssetManager.<LoadVideoViewAsync>d__27 <LoadVideoViewAsync>d__;
		<LoadVideoViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadVideoViewAsync>d__.<>4__this = this;
		<LoadVideoViewAsync>d__.videoPath = videoPath;
		<LoadVideoViewAsync>d__.<>1__state = -1;
		<LoadVideoViewAsync>d__.<>t__builder.Start<PlotAssetManager.<LoadVideoViewAsync>d__27>(ref <LoadVideoViewAsync>d__);
		return <LoadVideoViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601A514 RID: 107796 RVA: 0x008258D0 File Offset: 0x00823AD0
	[NullableContext(0)]
	public UniTask<int?> OpenVideoViewAsync([Nullable(2)] object param)
	{
		PlotAssetManager.<OpenVideoViewAsync>d__28 <OpenVideoViewAsync>d__;
		<OpenVideoViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
		<OpenVideoViewAsync>d__.<>4__this = this;
		<OpenVideoViewAsync>d__.param = param;
		<OpenVideoViewAsync>d__.<>1__state = -1;
		<OpenVideoViewAsync>d__.<>t__builder.Start<PlotAssetManager.<OpenVideoViewAsync>d__28>(ref <OpenVideoViewAsync>d__);
		return <OpenVideoViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601A515 RID: 107797 RVA: 0x0082591B File Offset: 0x00823B1B
	public bool HasPreloadVideo(string cgPath)
	{
		return this.VideoPathSet.Contains(cgPath);
	}

	// Token: 0x0601A516 RID: 107798 RVA: 0x0082592C File Offset: 0x00823B2C
	public bool HasPreloadQte(List<int> qteIds)
	{
		foreach (int item in qteIds)
		{
			if (!this.QteIdSet.Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601A517 RID: 107799 RVA: 0x00825988 File Offset: 0x00823B88
	public void DebugLog()
	{
	}

	// Token: 0x0400E725 RID: 59173
	public readonly Dictionary<string, ELoadResultType> LoadStateMap = new Dictionary<string, ELoadResultType>();

	// Token: 0x0400E726 RID: 59174
	private readonly Dictionary<string, AssetElement> IdAssetElementMap = new Dictionary<string, AssetElement>();

	// Token: 0x0400E727 RID: 59175
	private readonly Dictionary<string, int> PathKeyMap = new Dictionary<string, int>();

	// Token: 0x0400E728 RID: 59176
	private int AssetKey = 1;

	// Token: 0x0400E729 RID: 59177
	[Nullable(2)]
	private UHoldPreloadObject HoldPreloadObject;

	// Token: 0x0400E72A RID: 59178
	public Dictionary<string, IPreloadPlot> IdPendingMap = new Dictionary<string, IPreloadPlot>();

	// Token: 0x0400E72B RID: 59179
	public readonly PriorityQueue<IPreloadPlot> PendingList = new PriorityQueue<IPreloadPlot>((IPreloadPlot a, IPreloadPlot b) => b.Priority - a.Priority);

	// Token: 0x0400E72C RID: 59180
	private readonly Dictionary<string, PlotAssetExtra> ExtraAssetMap = new Dictionary<string, PlotAssetExtra>();

	// Token: 0x0400E72D RID: 59181
	private readonly HashSet<string> VideoPathSet = new HashSet<string>();

	// Token: 0x0400E72E RID: 59182
	[Nullable(2)]
	public UiPoolActor VideoViewActor;

	// Token: 0x0400E72F RID: 59183
	private HashSet<int> QteIdSet = new HashSet<int>();
}
