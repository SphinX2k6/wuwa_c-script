using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x0200331E RID: 13086
[NullableContext(1)]
[Nullable(0)]
public class PlotAssetManager
{
	// Token: 0x0601C80A RID: 116746 RVA: 0x007FEBE2 File Offset: 0x007FCDE2
	public void Init()
	{
		this.HoldPreloadObject = new UHoldPreloadObject(GlobalData.GameInstance, null, EObjectFlags.RF_NoFlags);
	}

	// Token: 0x0601C80B RID: 116747 RVA: 0x007FEBF6 File Offset: 0x007FCDF6
	public bool CheckCanLoad(string id, int priority)
	{
		return priority > 100 || this.LoadStateMap.Count == 0;
	}

	// Token: 0x0601C80C RID: 116748 RVA: 0x007FEC10 File Offset: 0x007FCE10
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

	// Token: 0x0601C80D RID: 116749 RVA: 0x007FEC8E File Offset: 0x007FCE8E
	public void RemovePending(string id)
	{
		if (!this.IdPendingMap.ContainsKey(id))
		{
			return;
		}
		this.PendingList.Remove(this.IdPendingMap[id]);
		this.IdPendingMap.Remove(id);
	}

	// Token: 0x0601C80E RID: 116750 RVA: 0x007FECC4 File Offset: 0x007FCEC4
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

	// Token: 0x0601C80F RID: 116751 RVA: 0x007FED24 File Offset: 0x007FCF24
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

	// Token: 0x0601C810 RID: 116752 RVA: 0x007FED68 File Offset: 0x007FCF68
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

	// Token: 0x0601C811 RID: 116753 RVA: 0x007FEFA4 File Offset: 0x007FD1A4
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

	// Token: 0x0601C812 RID: 116754 RVA: 0x007FEFDC File Offset: 0x007FD1DC
	private void OnObjectCallback(UObject @object, string path)
	{
		if (!this.PathKeyMap.ContainsKey(path))
		{
			return;
		}
		int entityId = this.PathKeyMap[path];
		this.HoldPreloadObject.AddEntityAsset(entityId, @object);
	}

	// Token: 0x0601C813 RID: 116755 RVA: 0x007FF014 File Offset: 0x007FD214
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

	// Token: 0x0601C814 RID: 116756 RVA: 0x007FF0A3 File Offset: 0x007FD2A3
	public void Clear()
	{
		this.RemoveAllPreload();
		this.HoldPreloadObject = null;
	}

	// Token: 0x0601C815 RID: 116757 RVA: 0x007FF0B4 File Offset: 0x007FD2B4
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

	// Token: 0x0601C816 RID: 116758 RVA: 0x007FF0F0 File Offset: 0x007FD2F0
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

	// Token: 0x0601C817 RID: 116759 RVA: 0x007FF160 File Offset: 0x007FD360
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

	// Token: 0x0601C818 RID: 116760 RVA: 0x007FF220 File Offset: 0x007FD420
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

	// Token: 0x0601C819 RID: 116761 RVA: 0x007FF26C File Offset: 0x007FD46C
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

	// Token: 0x0601C81A RID: 116762 RVA: 0x007FF318 File Offset: 0x007FD518
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

	// Token: 0x0601C81B RID: 116763 RVA: 0x007FF364 File Offset: 0x007FD564
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

	// Token: 0x0601C81C RID: 116764 RVA: 0x007FF3AF File Offset: 0x007FD5AF
	public bool HasPreloadVideo(string cgPath)
	{
		return this.VideoPathSet.Contains(cgPath);
	}

	// Token: 0x0601C81D RID: 116765 RVA: 0x007FF3C0 File Offset: 0x007FD5C0
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

	// Token: 0x0601C81E RID: 116766 RVA: 0x007FF41C File Offset: 0x007FD61C
	public void DebugLog()
	{
	}

	// Token: 0x0400E274 RID: 57972
	public readonly Dictionary<string, ELoadResultType> LoadStateMap = new Dictionary<string, ELoadResultType>();

	// Token: 0x0400E275 RID: 57973
	private readonly Dictionary<string, AssetElement> IdAssetElementMap = new Dictionary<string, AssetElement>();

	// Token: 0x0400E276 RID: 57974
	private readonly Dictionary<string, int> PathKeyMap = new Dictionary<string, int>();

	// Token: 0x0400E277 RID: 57975
	private int AssetKey = 1;

	// Token: 0x0400E278 RID: 57976
	[Nullable(2)]
	private UHoldPreloadObject HoldPreloadObject;

	// Token: 0x0400E279 RID: 57977
	public Dictionary<string, IPreloadPlot> IdPendingMap = new Dictionary<string, IPreloadPlot>();

	// Token: 0x0400E27A RID: 57978
	public readonly PriorityQueue<IPreloadPlot> PendingList = new PriorityQueue<IPreloadPlot>((IPreloadPlot a, IPreloadPlot b) => b.Priority - a.Priority);

	// Token: 0x0400E27B RID: 57979
	private readonly Dictionary<string, PlotAssetExtra> ExtraAssetMap = new Dictionary<string, PlotAssetExtra>();

	// Token: 0x0400E27C RID: 57980
	private readonly HashSet<string> VideoPathSet = new HashSet<string>();

	// Token: 0x0400E27D RID: 57981
	[Nullable(2)]
	public UiPoolActor VideoViewActor;

	// Token: 0x0400E27E RID: 57982
	private HashSet<int> QteIdSet = new HashSet<int>();
}
