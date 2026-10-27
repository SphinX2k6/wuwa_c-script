using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FB5 RID: 4021
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemManager
{
	// Token: 0x06006705 RID: 26373 RVA: 0x00145E34 File Offset: 0x00144034
	[NullableContext(2)]
	public ISceneSlotItemInfo GetSceneSlotItemInfo(int slotEntityId)
	{
		ISceneSlotItemInfo result;
		if (!this.SceneSlotItemInfoMap.TryGetValue(slotEntityId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06006706 RID: 26374 RVA: 0x00145E54 File Offset: 0x00144054
	public ISceneSlotItemInfo GetOrCreateSceneSlotItemInfo(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo == null)
		{
			sceneSlotItemInfo = new SceneSlotItemInfo
			{
				SlotEntityId = slotEntityId,
				RootFurnitureSceneItem = null,
				SubFurnitureSceneItemMap = new Dictionary<int, FurnitureSceneItemBase>()
			};
			this.SceneSlotItemInfoMap[slotEntityId] = sceneSlotItemInfo;
		}
		return sceneSlotItemInfo;
	}

	// Token: 0x06006707 RID: 26375 RVA: 0x00145E99 File Offset: 0x00144099
	public Dictionary<int, ISceneSlotItemInfo> GetSceneSlotItemInfoMap()
	{
		return this.SceneSlotItemInfoMap;
	}

	// Token: 0x06006708 RID: 26376 RVA: 0x00145EA4 File Offset: 0x001440A4
	private FurnitureSceneItemBase CreateFurnitureSceneItem(int furnitureConfigId)
	{
		switch (FurnitureModel.Instance.GetFurnitureSceneItemType(furnitureConfigId))
		{
		case EFurnitureSceneItemType.SingleLevel:
			return new FurnitureSingleLevelItem(furnitureConfigId);
		case EFurnitureSceneItemType.SingleEntity:
			return new FurnitureSingleEntityItem(furnitureConfigId);
		case EFurnitureSceneItemType.GroupEntity:
			return new FurnitureGroupEntityItem(furnitureConfigId);
		default:
			return new FurnitureSingleLevelItem(furnitureConfigId);
		}
	}

	// Token: 0x06006709 RID: 26377 RVA: 0x00145EEC File Offset: 0x001440EC
	public bool HasRootFurnitureSceneItem(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		return ((sceneSlotItemInfo != null) ? sceneSlotItemInfo.RootFurnitureSceneItem : null) != null;
	}

	// Token: 0x0600670A RID: 26378 RVA: 0x00145F04 File Offset: 0x00144104
	public bool HasSubFurnitureSceneItem(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		return sceneSlotItemInfo != null && sceneSlotItemInfo.SubFurnitureSceneItemMap.ContainsKey(slotIndex);
	}

	// Token: 0x0600670B RID: 26379 RVA: 0x00145F20 File Offset: 0x00144120
	[NullableContext(0)]
	public UniTask<bool> LoadRootFurnitureSceneItemAsync(int slotEntityId, int furnitureConfigId, [Nullable(1)] Transform transform, bool bShow)
	{
		FurnitureSceneItemManager.<LoadRootFurnitureSceneItemAsync>d__8 <LoadRootFurnitureSceneItemAsync>d__;
		<LoadRootFurnitureSceneItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadRootFurnitureSceneItemAsync>d__.<>4__this = this;
		<LoadRootFurnitureSceneItemAsync>d__.slotEntityId = slotEntityId;
		<LoadRootFurnitureSceneItemAsync>d__.furnitureConfigId = furnitureConfigId;
		<LoadRootFurnitureSceneItemAsync>d__.transform = transform;
		<LoadRootFurnitureSceneItemAsync>d__.bShow = bShow;
		<LoadRootFurnitureSceneItemAsync>d__.<>1__state = -1;
		<LoadRootFurnitureSceneItemAsync>d__.<>t__builder.Start<FurnitureSceneItemManager.<LoadRootFurnitureSceneItemAsync>d__8>(ref <LoadRootFurnitureSceneItemAsync>d__);
		return <LoadRootFurnitureSceneItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600670C RID: 26380 RVA: 0x00145F84 File Offset: 0x00144184
	public void UnloadRootFurnitureSceneItem(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo != null)
		{
			this.UnloadRootFurnitureSceneItemInternal(sceneSlotItemInfo);
		}
	}

	// Token: 0x0600670D RID: 26381 RVA: 0x00145FA4 File Offset: 0x001441A4
	private void UnloadRootFurnitureSceneItemInternal(ISceneSlotItemInfo sceneSlotItemInfo)
	{
		FurnitureSceneItemBase rootFurnitureSceneItem = sceneSlotItemInfo.RootFurnitureSceneItem;
		if (rootFurnitureSceneItem != null)
		{
			rootFurnitureSceneItem.Unload();
			sceneSlotItemInfo.RootFurnitureSceneItem = null;
		}
	}

	// Token: 0x0600670E RID: 26382 RVA: 0x00145FC8 File Offset: 0x001441C8
	[NullableContext(0)]
	public UniTask<bool> LoadSubFurnitureSceneItemAsync(int slotEntityId, int furnitureConfigId, int slotIndex, [Nullable(1)] Transform transform, bool bShow)
	{
		FurnitureSceneItemManager.<LoadSubFurnitureSceneItemAsync>d__11 <LoadSubFurnitureSceneItemAsync>d__;
		<LoadSubFurnitureSceneItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadSubFurnitureSceneItemAsync>d__.<>4__this = this;
		<LoadSubFurnitureSceneItemAsync>d__.slotEntityId = slotEntityId;
		<LoadSubFurnitureSceneItemAsync>d__.furnitureConfigId = furnitureConfigId;
		<LoadSubFurnitureSceneItemAsync>d__.slotIndex = slotIndex;
		<LoadSubFurnitureSceneItemAsync>d__.transform = transform;
		<LoadSubFurnitureSceneItemAsync>d__.bShow = bShow;
		<LoadSubFurnitureSceneItemAsync>d__.<>1__state = -1;
		<LoadSubFurnitureSceneItemAsync>d__.<>t__builder.Start<FurnitureSceneItemManager.<LoadSubFurnitureSceneItemAsync>d__11>(ref <LoadSubFurnitureSceneItemAsync>d__);
		return <LoadSubFurnitureSceneItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600670F RID: 26383 RVA: 0x00146038 File Offset: 0x00144238
	public void ShowRootFurnitureSceneItem(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo != null)
		{
			FurnitureSceneItemBase rootFurnitureSceneItem = sceneSlotItemInfo.RootFurnitureSceneItem;
			if (rootFurnitureSceneItem == null)
			{
				return;
			}
			rootFurnitureSceneItem.Show();
		}
	}

	// Token: 0x06006710 RID: 26384 RVA: 0x00146064 File Offset: 0x00144264
	public void ShowSubFurnitureSceneItem(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		FurnitureSceneItemBase furnitureSceneItemBase;
		if (sceneSlotItemInfo != null && sceneSlotItemInfo.SubFurnitureSceneItemMap.TryGetValue(slotIndex, out furnitureSceneItemBase))
		{
			furnitureSceneItemBase.Show();
		}
	}

	// Token: 0x06006711 RID: 26385 RVA: 0x00146094 File Offset: 0x00144294
	public void UnloadSubFurnitureSceneItem(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo != null)
		{
			this.UnloadSubFurnitureSceneItemInternal(sceneSlotItemInfo, slotIndex);
		}
	}

	// Token: 0x06006712 RID: 26386 RVA: 0x001460B4 File Offset: 0x001442B4
	private void UnloadSubFurnitureSceneItemInternal(ISceneSlotItemInfo sceneSlotItemInfo, int slotIndex)
	{
		Dictionary<int, FurnitureSceneItemBase> subFurnitureSceneItemMap = sceneSlotItemInfo.SubFurnitureSceneItemMap;
		if (subFurnitureSceneItemMap.ContainsKey(slotIndex))
		{
			FurnitureSceneItemBase furnitureSceneItemBase;
			if (subFurnitureSceneItemMap.TryGetValue(slotIndex, out furnitureSceneItemBase))
			{
				furnitureSceneItemBase.Unload();
			}
			subFurnitureSceneItemMap.Remove(slotIndex);
		}
	}

	// Token: 0x06006713 RID: 26387 RVA: 0x001460EC File Offset: 0x001442EC
	public void UnloadAllSubFurnitureSceneItem(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo == null)
		{
			return;
		}
		Dictionary<int, FurnitureSceneItemBase> subFurnitureSceneItemMap = sceneSlotItemInfo.SubFurnitureSceneItemMap;
		foreach (FurnitureSceneItemBase furnitureSceneItemBase in subFurnitureSceneItemMap.Values)
		{
			furnitureSceneItemBase.Unload();
		}
		subFurnitureSceneItemMap.Clear();
	}

	// Token: 0x06006714 RID: 26388 RVA: 0x00146158 File Offset: 0x00144358
	public void UnloadAllFurnitureSceneItem()
	{
		if (this.SceneSlotItemInfoMap.Count == 0)
		{
			return;
		}
		foreach (ISceneSlotItemInfo sceneSlotItemInfo in this.SceneSlotItemInfoMap.Values)
		{
			FurnitureSceneItemBase rootFurnitureSceneItem = sceneSlotItemInfo.RootFurnitureSceneItem;
			if (rootFurnitureSceneItem != null)
			{
				rootFurnitureSceneItem.Unload();
			}
			foreach (FurnitureSceneItemBase furnitureSceneItemBase in sceneSlotItemInfo.SubFurnitureSceneItemMap.Values)
			{
				furnitureSceneItemBase.Unload();
			}
		}
		this.DoUnloadNeedUnloadedSceneItem();
		this.SceneSlotItemInfoMap.Clear();
		this.NeedUnloadedSceneItem.Clear();
	}

	// Token: 0x06006715 RID: 26389 RVA: 0x00146228 File Offset: 0x00144428
	public void MarkFurnitureSceneItemAsNeedUnload(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo orCreateSceneSlotItemInfo = this.GetOrCreateSceneSlotItemInfo(slotEntityId);
		FurnitureSceneItemBase sceneItem;
		if (slotIndex == -1)
		{
			if (orCreateSceneSlotItemInfo.RootFurnitureSceneItem != null)
			{
				this.MarkSceneItemAsNeedUnloadInternal(orCreateSceneSlotItemInfo.RootFurnitureSceneItem);
				orCreateSceneSlotItemInfo.RootFurnitureSceneItem = null;
				return;
			}
		}
		else if (orCreateSceneSlotItemInfo.SubFurnitureSceneItemMap.TryGetValue(slotIndex, out sceneItem))
		{
			this.MarkSceneItemAsNeedUnloadInternal(sceneItem);
			orCreateSceneSlotItemInfo.SubFurnitureSceneItemMap.Remove(slotIndex);
		}
	}

	// Token: 0x06006716 RID: 26390 RVA: 0x00146281 File Offset: 0x00144481
	private void MarkSceneItemAsNeedUnloadInternal(FurnitureSceneItemBase sceneItem)
	{
		if (sceneItem != null && !this.NeedUnloadedSceneItem.Contains(sceneItem))
		{
			sceneItem.MarkAsNeedUnload();
			this.NeedUnloadedSceneItem.Add(sceneItem);
		}
	}

	// Token: 0x06006717 RID: 26391 RVA: 0x001462A8 File Offset: 0x001444A8
	public void DoUnloadNeedUnloadedSceneItem()
	{
		if (this.NeedUnloadedSceneItem.Count == 0)
		{
			return;
		}
		foreach (FurnitureSceneItemBase furnitureSceneItemBase in this.NeedUnloadedSceneItem)
		{
			furnitureSceneItemBase.Unload();
		}
		this.NeedUnloadedSceneItem.Clear();
	}

	// Token: 0x04002EB1 RID: 11953
	private readonly Dictionary<int, ISceneSlotItemInfo> SceneSlotItemInfoMap = new Dictionary<int, ISceneSlotItemInfo>();

	// Token: 0x04002EB2 RID: 11954
	private readonly List<FurnitureSceneItemBase> NeedUnloadedSceneItem = new List<FurnitureSceneItemBase>();
}
