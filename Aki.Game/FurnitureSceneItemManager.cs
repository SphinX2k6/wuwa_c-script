using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200046A RID: 1130
[NullableContext(1)]
[Nullable(0)]
public class FurnitureSceneItemManager
{
	// Token: 0x06003A9D RID: 15005 RVA: 0x0014E6F8 File Offset: 0x0014C8F8
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

	// Token: 0x06003A9E RID: 15006 RVA: 0x0014E718 File Offset: 0x0014C918
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

	// Token: 0x06003A9F RID: 15007 RVA: 0x0014E75D File Offset: 0x0014C95D
	public Dictionary<int, ISceneSlotItemInfo> GetSceneSlotItemInfoMap()
	{
		return this.SceneSlotItemInfoMap;
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x0014E768 File Offset: 0x0014C968
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

	// Token: 0x06003AA1 RID: 15009 RVA: 0x0014E7B0 File Offset: 0x0014C9B0
	public bool HasRootFurnitureSceneItem(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		return ((sceneSlotItemInfo != null) ? sceneSlotItemInfo.RootFurnitureSceneItem : null) != null;
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x0014E7C8 File Offset: 0x0014C9C8
	public bool HasSubFurnitureSceneItem(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		return sceneSlotItemInfo != null && sceneSlotItemInfo.SubFurnitureSceneItemMap.ContainsKey(slotIndex);
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x0014E7E4 File Offset: 0x0014C9E4
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

	// Token: 0x06003AA4 RID: 15012 RVA: 0x0014E848 File Offset: 0x0014CA48
	public void UnloadRootFurnitureSceneItem(int slotEntityId)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo != null)
		{
			this.UnloadRootFurnitureSceneItemInternal(sceneSlotItemInfo);
		}
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x0014E868 File Offset: 0x0014CA68
	private void UnloadRootFurnitureSceneItemInternal(ISceneSlotItemInfo sceneSlotItemInfo)
	{
		FurnitureSceneItemBase rootFurnitureSceneItem = sceneSlotItemInfo.RootFurnitureSceneItem;
		if (rootFurnitureSceneItem != null)
		{
			rootFurnitureSceneItem.Unload();
			sceneSlotItemInfo.RootFurnitureSceneItem = null;
		}
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x0014E88C File Offset: 0x0014CA8C
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

	// Token: 0x06003AA7 RID: 15015 RVA: 0x0014E8FC File Offset: 0x0014CAFC
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

	// Token: 0x06003AA8 RID: 15016 RVA: 0x0014E928 File Offset: 0x0014CB28
	public void ShowSubFurnitureSceneItem(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		FurnitureSceneItemBase furnitureSceneItemBase;
		if (sceneSlotItemInfo != null && sceneSlotItemInfo.SubFurnitureSceneItemMap.TryGetValue(slotIndex, out furnitureSceneItemBase))
		{
			furnitureSceneItemBase.Show();
		}
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x0014E958 File Offset: 0x0014CB58
	public void UnloadSubFurnitureSceneItem(int slotEntityId, int slotIndex)
	{
		ISceneSlotItemInfo sceneSlotItemInfo = this.GetSceneSlotItemInfo(slotEntityId);
		if (sceneSlotItemInfo != null)
		{
			this.UnloadSubFurnitureSceneItemInternal(sceneSlotItemInfo, slotIndex);
		}
	}

	// Token: 0x06003AAA RID: 15018 RVA: 0x0014E978 File Offset: 0x0014CB78
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

	// Token: 0x06003AAB RID: 15019 RVA: 0x0014E9B0 File Offset: 0x0014CBB0
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

	// Token: 0x06003AAC RID: 15020 RVA: 0x0014EA1C File Offset: 0x0014CC1C
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

	// Token: 0x06003AAD RID: 15021 RVA: 0x0014EAEC File Offset: 0x0014CCEC
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

	// Token: 0x06003AAE RID: 15022 RVA: 0x0014EB45 File Offset: 0x0014CD45
	private void MarkSceneItemAsNeedUnloadInternal(FurnitureSceneItemBase sceneItem)
	{
		if (sceneItem != null && !this.NeedUnloadedSceneItem.Contains(sceneItem))
		{
			sceneItem.MarkAsNeedUnload();
			this.NeedUnloadedSceneItem.Add(sceneItem);
		}
	}

	// Token: 0x06003AAF RID: 15023 RVA: 0x0014EB6C File Offset: 0x0014CD6C
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

	// Token: 0x04002F4A RID: 12106
	private readonly Dictionary<int, ISceneSlotItemInfo> SceneSlotItemInfoMap = new Dictionary<int, ISceneSlotItemInfo>();

	// Token: 0x04002F4B RID: 12107
	private readonly List<FurnitureSceneItemBase> NeedUnloadedSceneItem = new List<FurnitureSceneItemBase>();
}
