using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200047E RID: 1150
[NullableContext(1)]
[Nullable(0)]
public class FurnitureDesignView : UiViewBase
{
	// Token: 0x06003B23 RID: 15139 RVA: 0x00150414 File Offset: 0x0014E614
	public FurnitureDesignView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003B24 RID: 15140 RVA: 0x00150488 File Offset: 0x0014E688
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIArtText)),
			new ValueTuple<int, Type>(19, typeof(UUIArtText)),
			new ValueTuple<int, Type>(20, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(21, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(22, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(23, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(24, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickRightBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeftBtn)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickSaveBtn)),
			new ValueTuple<int, Delegate>(20, new Action(this.OnClickPresetBtn)),
			new ValueTuple<int, Delegate>(23, new Action(this.OnClickMaskButton)),
			new ValueTuple<int, Delegate>(24, new Action(this.OnClickSaveAndTeleportBtn))
		};
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x0015078C File Offset: 0x0014E98C
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureDesignView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureDesignView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x001507D0 File Offset: 0x0014E9D0
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		FurnitureDesignView.<OnBeforeShowAsyncImplementImplement>d__33 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<FurnitureDesignView.<OnBeforeShowAsyncImplementImplement>d__33>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x00150813 File Offset: 0x0014EA13
	protected override void OnBeforeHide()
	{
		this.ResumeTimeDilation();
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x0015081C File Offset: 0x0014EA1C
	protected override void OnBeforeDestroy()
	{
		FurnitureEntityVisibleManager furnitureEntityVisibleManager = FurnitureModel.Instance.FurnitureEntityVisibleManager;
		furnitureEntityVisibleManager.UnlockFurnitureEntity();
		furnitureEntityVisibleManager.EnabledAllEntities();
		FurnitureController instance = FurnitureController.Instance;
		instance.DoUnloadNeedUnloadedSceneItem();
		instance.UnloadAllServerFurnitureSceneItem();
		instance.EndEditArea();
		CameraController.Instance.MainModel.SceneCamera.PlayerComponent.ExitFixSceneSubCamera(null, true);
		this.AtmosphereTween.Destroy();
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x0015087A File Offset: 0x0014EA7A
	protected virtual void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("FurnitureDesignView");
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x0015088B File Offset: 0x0014EA8B
	protected virtual void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("FurnitureDesignView");
	}

	// Token: 0x06003B2B RID: 15147 RVA: 0x0015089C File Offset: 0x0014EA9C
	private bool SetSlotSelectedState(int index)
	{
		if (index < 0 || index >= this.SlotDataList.Count)
		{
			return false;
		}
		if (this.SelectedSlotIndex == index)
		{
			return false;
		}
		if (this.SelectedSlotIndex != -1)
		{
			FurnitureSlotScrollItemData furnitureSlotScrollItemData = this.SlotDataList[this.SelectedSlotIndex];
			if (furnitureSlotScrollItemData != null)
			{
				furnitureSlotScrollItemData.IsSelected = false;
			}
		}
		this.SelectedSlotIndex = index;
		FurnitureSlotScrollItemData furnitureSlotScrollItemData2 = this.SlotDataList[index];
		if (furnitureSlotScrollItemData2 != null)
		{
			furnitureSlotScrollItemData2.IsSelected = true;
			this.SelectedSceneSlotEntityId = furnitureSlotScrollItemData2.SceneSlotEntityId;
			this.SelectedSubSlotIndex = furnitureSlotScrollItemData2.SubSlotIndex;
			this.SelectedSlotType = furnitureSlotScrollItemData2.SlotType;
			this.SelectedFurnitureConfigId = furnitureSlotScrollItemData2.PlacedFurnitureId;
		}
		return true;
	}

	// Token: 0x06003B2C RID: 15148 RVA: 0x0015093C File Offset: 0x0014EB3C
	private bool SetFurnitureSelectedState(int index)
	{
		if (index >= this.FurnitureScrollItemDataList.Count)
		{
			return false;
		}
		if (this.SelectedFurnitureIndex == index)
		{
			return false;
		}
		if (this.SelectedFurnitureIndex != -1)
		{
			FurnitureScrollItemData furnitureScrollItemData = this.FurnitureScrollItemDataList[this.SelectedFurnitureIndex];
			if (furnitureScrollItemData != null)
			{
				furnitureScrollItemData.IsSelected = false;
			}
		}
		this.SelectedFurnitureIndex = index;
		if (index == -1)
		{
			this.SelectedFurnitureConfigId = 0;
			return true;
		}
		FurnitureScrollItemData furnitureScrollItemData2 = this.FurnitureScrollItemDataList[index];
		if (furnitureScrollItemData2 != null)
		{
			furnitureScrollItemData2.IsSelected = true;
			this.SelectedFurnitureConfigId = furnitureScrollItemData2.FurnitureConfig.Id;
		}
		return true;
	}

	// Token: 0x06003B2D RID: 15149 RVA: 0x001509CC File Offset: 0x0014EBCC
	private void UpdateSlotDataList()
	{
		this.SlotDataList.Clear();
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId);
		if (furnitureAreaConfig == null)
		{
			return;
		}
		FurnitureAreaData curEditAreaData = this.CurEditAreaData;
		if (curEditAreaData == null)
		{
			return;
		}
		foreach (int slotEntityId in furnitureAreaConfig.Value.SlotEntityIdsIter())
		{
			this.AddSceneSlotData(slotEntityId, curEditAreaData);
			this.AddSubSlotData(slotEntityId, curEditAreaData);
		}
		this.SortSlotDataList();
		this.UpdateSlotTagIndex();
		this.UpdateSlotSelectedState();
		this.UpdateSlotLineState();
	}

	// Token: 0x06003B2E RID: 15150 RVA: 0x00150A78 File Offset: 0x0014EC78
	private void UpdateFurnitureScrollItemDataList()
	{
		if (this.CurEditAreaData == null)
		{
			return;
		}
		this.FurnitureScrollItemDataList.Clear();
		FurnitureSlotScrollItemData furnitureSlotScrollItemData = (this.SlotDataList.Count > this.SelectedSlotIndex && this.SelectedSlotIndex >= 0) ? this.SlotDataList[this.SelectedSlotIndex] : null;
		if (furnitureSlotScrollItemData == null)
		{
			return;
		}
		this.UpdateOriginalPlacedFurnitureId();
		foreach (Furniture furnitureConfig in (FurnitureModel.Instance.GetFurnitureConfigListBySlotInfo(this.CurEditAreaData, furnitureSlotScrollItemData.SceneSlotEntityId, furnitureSlotScrollItemData.SubSlotIndex) ?? new List<Furniture>()))
		{
			this.FurnitureScrollItemDataList.Add(this.CreateFurnitureScrollItemData(furnitureConfig));
		}
		this.SortFurnitureScrollItemDataList();
		this.SelectedFurnitureIndex = this.FurnitureScrollItemDataList.FindIndex((FurnitureScrollItemData item) => item.FurnitureConfig.Id == this.SelectedFurnitureConfigId);
	}

	// Token: 0x06003B2F RID: 15151 RVA: 0x00150B64 File Offset: 0x0014ED64
	private void UpdateAreaPointDataList()
	{
		this.AreaPointDataList.Clear();
		foreach (int num in this.AreaList)
		{
			this.AreaPointDataList.Add(num == this.SelectedAreaId);
		}
	}

	// Token: 0x06003B30 RID: 15152 RVA: 0x00150BD0 File Offset: 0x0014EDD0
	private void SortFurnitureScrollItemDataList()
	{
		this.FurnitureScrollItemDataList.Sort(delegate(FurnitureScrollItemData a, FurnitureScrollItemData b)
		{
			if (a.IsSelected != b.IsSelected)
			{
				if (!a.IsSelected)
				{
					return 1;
				}
				return -1;
			}
			else if (a.IsLock != b.IsLock)
			{
				if (!a.IsLock)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				bool flag = a.FurnitureConfig.LimitCount > 0;
				bool flag2 = b.FurnitureConfig.LimitCount > 0;
				if (flag != flag2)
				{
					if (flag && a.LeftCount == 0)
					{
						return 1;
					}
					if (flag2 && b.LeftCount == 0)
					{
						return -1;
					}
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (flag && a.LeftCount != b.LeftCount)
					{
						return b.LeftCount - a.LeftCount;
					}
					int num = b.FurnitureConfig.QualityId - a.FurnitureConfig.QualityId;
					if (num != 0)
					{
						return num;
					}
					return b.FurnitureConfig.Id - a.FurnitureConfig.Id;
				}
			}
		});
	}

	// Token: 0x06003B31 RID: 15153 RVA: 0x00150BFC File Offset: 0x0014EDFC
	private FurnitureScrollItemData CreateFurnitureScrollItemData(Furniture furnitureConfig)
	{
		FurnitureModel instance = FurnitureModel.Instance;
		int id = furnitureConfig.Id;
		FurnitureScrollItemData furnitureScrollItemData = new FurnitureScrollItemData
		{
			FurnitureConfig = furnitureConfig,
			RedDotShowState = FurnitureModel.Instance.CheckFurnitureDesignItemRedDotByConfig(furnitureConfig),
			IsSelected = (id == this.SelectedFurnitureConfigId),
			LeftCount = 0,
			IsLock = !instance.GetIsFurnitureUnlockById(id),
			IsCheck = (id == this.OriginalPlacedFurnitureId)
		};
		this.UpdateFurnitureScrollItemDataLeftCount(furnitureScrollItemData);
		return furnitureScrollItemData;
	}

	// Token: 0x06003B32 RID: 15154 RVA: 0x00150C74 File Offset: 0x0014EE74
	private void UpdateFurnitureScrollItemDataLeftCount(FurnitureScrollItemData data)
	{
		int limitCount = data.FurnitureConfig.LimitCount;
		int id = data.FurnitureConfig.Id;
		int leftCount = 0;
		if (limitCount > 0)
		{
			int num = 0;
			foreach (FurnitureAreaData furnitureAreaData in this.EditorAreaDataMap.Values)
			{
				num += furnitureAreaData.GetFurnitureUseCount(id);
			}
			leftCount = limitCount - num;
		}
		data.LeftCount = leftCount;
	}

	// Token: 0x06003B33 RID: 15155 RVA: 0x00150D08 File Offset: 0x0014EF08
	private void UpdateOriginalPlacedFurnitureId()
	{
		FurnitureAreaData areaData = FurnitureModel.Instance.GetAreaData(this.SelectedAreaId);
		if (areaData == null)
		{
			return;
		}
		FurnitureSlotDataBase slotData = areaData.GetSlotData(this.SelectedSceneSlotEntityId, this.SelectedSubSlotIndex);
		if (slotData == null)
		{
			return;
		}
		this.OriginalPlacedFurnitureId = slotData.GetPlacedFurnitureConfigId();
	}

	// Token: 0x06003B34 RID: 15156 RVA: 0x00150D50 File Offset: 0x0014EF50
	private void UpdateSlotTagIndex()
	{
		this.TagCounterMap.Clear();
		foreach (FurnitureSlotScrollItemData furnitureSlotScrollItemData in this.SlotDataList)
		{
			int andIncrementTagIndex = this.GetAndIncrementTagIndex(furnitureSlotScrollItemData.TagId);
			furnitureSlotScrollItemData.TagIndex = andIncrementTagIndex;
			furnitureSlotScrollItemData.ShowTagIndex = (andIncrementTagIndex > 1);
		}
	}

	// Token: 0x06003B35 RID: 15157 RVA: 0x00150DC8 File Offset: 0x0014EFC8
	private void UpdateSlotSelectedState()
	{
		this.SelectedSlotIndex = this.SlotDataList.FindIndex(new Predicate<FurnitureSlotScrollItemData>(this.IsSlotMatched));
		for (int i = 0; i < this.SlotDataList.Count; i++)
		{
			this.SlotDataList[i].IsSelected = (i == this.SelectedSlotIndex);
		}
	}

	// Token: 0x06003B36 RID: 15158 RVA: 0x00150E24 File Offset: 0x0014F024
	private void UpdateSlotLineState()
	{
		int count = this.SlotDataList.Count;
		for (int i = 0; i < count; i++)
		{
			this.SlotDataList[i].LineShowState = (i != count - 1);
		}
	}

	// Token: 0x06003B37 RID: 15159 RVA: 0x00150E64 File Offset: 0x0014F064
	private void AddSceneSlotData(int slotEntityId, FurnitureAreaData areaData)
	{
		IFurnitureSlot sceneSlotEntitySlotInfo = FurnitureModel.Instance.GetSceneSlotEntitySlotInfo(this.MapId, slotEntityId);
		if (sceneSlotEntitySlotInfo == null)
		{
			return;
		}
		FurnitureSceneSlotData sceneSlotData = areaData.GetSceneSlotData(slotEntityId);
		int furnitureTag = sceneSlotEntitySlotInfo.FurnitureTag;
		int placedFurnitureId = (sceneSlotData != null) ? sceneSlotData.GetPlacedFurnitureConfigId() : 0;
		FurnitureSlotScrollItemData item = new FurnitureSlotScrollItemData
		{
			SceneSlotEntityId = slotEntityId,
			PlacedFurnitureId = placedFurnitureId,
			SubSlotIndex = -1,
			SlotType = EFurnitureSlotType.SceneSlot,
			TagId = furnitureTag,
			TagIndex = 0,
			ShowTagIndex = false,
			IsSelected = false,
			LineShowState = false,
			RedDotShowState = FurnitureModel.Instance.CheckFurnitureSlotRedDot(areaData, slotEntityId, -1)
		};
		this.SlotDataList.Add(item);
	}

	// Token: 0x06003B38 RID: 15160 RVA: 0x00150F08 File Offset: 0x0014F108
	private void AddSubSlotData(int slotEntityId, FurnitureAreaData areaData)
	{
		FurnitureSceneSlotData sceneSlotData = areaData.GetSceneSlotData(slotEntityId);
		if (sceneSlotData == null || sceneSlotData.GetPlacedFurnitureConfigId() == 0)
		{
			return;
		}
		int subSlotDataListLength = sceneSlotData.GetSubSlotDataListLength();
		if (subSlotDataListLength <= 0)
		{
			return;
		}
		for (int i = 0; i < subSlotDataListLength; i++)
		{
			FurnitureSubSlotData subSlotData = sceneSlotData.GetSubSlotData(i);
			if (subSlotData != null)
			{
				int slotTagId = subSlotData.GetSlotTagId();
				int andIncrementTagIndex = this.GetAndIncrementTagIndex(slotTagId);
				int placedFurnitureConfigId = subSlotData.GetPlacedFurnitureConfigId();
				FurnitureSlotScrollItemData item = new FurnitureSlotScrollItemData
				{
					SceneSlotEntityId = slotEntityId,
					PlacedFurnitureId = placedFurnitureConfigId,
					SubSlotIndex = i,
					SlotType = EFurnitureSlotType.SubSlot,
					TagId = slotTagId,
					TagIndex = andIncrementTagIndex,
					ShowTagIndex = false,
					IsSelected = false,
					LineShowState = false,
					RedDotShowState = FurnitureModel.Instance.CheckFurnitureSlotRedDot(areaData, slotEntityId, i)
				};
				this.SlotDataList.Add(item);
			}
		}
	}

	// Token: 0x06003B39 RID: 15161 RVA: 0x00150FD8 File Offset: 0x0014F1D8
	private void SortSlotDataList()
	{
		this.SlotDataList.Sort(delegate(FurnitureSlotScrollItemData a, FurnitureSlotScrollItemData b)
		{
			if (a.SceneSlotEntityId != b.SceneSlotEntityId)
			{
				return a.SceneSlotEntityId - b.SceneSlotEntityId;
			}
			return a.SubSlotIndex - b.SubSlotIndex;
		});
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x00151004 File Offset: 0x0014F204
	private int GetAndIncrementTagIndex(int tagId)
	{
		int num;
		this.TagCounterMap.TryGetValue(tagId, out num);
		int num2 = num + 1;
		if (this.TagCounterMap.ContainsKey(tagId))
		{
			this.TagCounterMap[tagId] = num2;
		}
		else
		{
			this.TagCounterMap.Add(tagId, num2);
		}
		return num2;
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x0015104F File Offset: 0x0014F24F
	private bool IsSlotMatched(FurnitureSlotScrollItemData slotData)
	{
		return slotData.SlotType == this.SelectedSlotType && slotData.SceneSlotEntityId == this.SelectedSceneSlotEntityId && slotData.SubSlotIndex == this.SelectedSubSlotIndex;
	}

	// Token: 0x06003B3C RID: 15164 RVA: 0x00151080 File Offset: 0x0014F280
	public void SelectSlot(int index)
	{
		int selectedSlotIndex = this.SelectedSlotIndex;
		if (!this.SetSlotSelectedState(index))
		{
			return;
		}
		int selectedSlotIndex2 = this.SelectedSlotIndex;
		GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> furnitureSlotScrollView = this.FurnitureSlotScrollView;
		GenericLayout<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> genericLayout = (furnitureSlotScrollView != null) ? furnitureSlotScrollView.GetGenericLayout() : null;
		if (genericLayout != null)
		{
			FurnitureSlotScrollItem layoutItemByIndex = genericLayout.GetLayoutItemByIndex(selectedSlotIndex);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.RefreshItemToggle();
			}
			FurnitureSlotScrollItem layoutItemByIndex2 = genericLayout.GetLayoutItemByIndex(selectedSlotIndex2);
			if (layoutItemByIndex2 != null)
			{
				layoutItemByIndex2.RefreshItemToggle();
			}
		}
		this.UpdateFurnitureScrollItemDataList();
		this.RefreshFurnitureScrollItemLayout(true);
		this.EnterCurSelectedSceneSlotCamera(true);
	}

	// Token: 0x06003B3D RID: 15165 RVA: 0x001510F4 File Offset: 0x0014F2F4
	public void SelectFurniture(int index)
	{
		int selectedFurnitureIndex = this.SelectedFurnitureIndex;
		FurnitureScrollItemData furnitureScrollItemData = (this.FurnitureScrollItemDataList.Count > this.SelectedFurnitureIndex && this.SelectedFurnitureIndex >= 0) ? this.FurnitureScrollItemDataList[this.SelectedFurnitureIndex] : null;
		if (!this.SetFurnitureSelectedState(index))
		{
			return;
		}
		int selectedFurnitureIndex2 = this.SelectedFurnitureIndex;
		FurnitureScrollItemData furnitureScrollItemData2 = (this.FurnitureScrollItemDataList.Count > this.SelectedFurnitureIndex && this.SelectedFurnitureIndex >= 0) ? this.FurnitureScrollItemDataList[this.SelectedFurnitureIndex] : null;
		FurnitureAreaData curEditAreaData = this.CurEditAreaData;
		if (curEditAreaData == null)
		{
			return;
		}
		FurnitureController instance = FurnitureController.Instance;
		FurnitureSlotContext slotContext = new FurnitureSlotContext
		{
			SlotEntityId = this.SelectedSceneSlotEntityId,
			SubSlotIndex = this.SelectedSubSlotIndex
		};
		FurnitureAreaSlotContext areaSlotContext = new FurnitureAreaSlotContext
		{
			AreaData = curEditAreaData,
			SlotContext = slotContext
		};
		FurnitureSceneItemPlaceContext placeContext = new FurnitureSceneItemPlaceContext
		{
			AreaSlotContext = areaSlotContext,
			FurnitureId = this.SelectedFurnitureConfigId,
			KeepSubFurniture = true
		};
		instance.PlaceFurnitureAsync(placeContext);
		if (this.SelectedSlotType == EFurnitureSlotType.SceneSlot)
		{
			this.UpdateSlotDataList();
			GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> furnitureSlotScrollView = this.FurnitureSlotScrollView;
			if (furnitureSlotScrollView != null)
			{
				furnitureSlotScrollView.RefreshByData(this.SlotDataList, null, false);
			}
		}
		else
		{
			FurnitureSlotScrollItemData furnitureSlotScrollItemData = (this.SlotDataList.Count > this.SelectedSlotIndex && this.SelectedSlotIndex >= 0) ? this.SlotDataList[this.SelectedSlotIndex] : null;
			if (furnitureSlotScrollItemData != null)
			{
				furnitureSlotScrollItemData.PlacedFurnitureId = this.SelectedFurnitureConfigId;
				GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> furnitureSlotScrollView2 = this.FurnitureSlotScrollView;
				if (furnitureSlotScrollView2 != null)
				{
					FurnitureSlotScrollItem scrollItemByIndex = furnitureSlotScrollView2.GetScrollItemByIndex(this.SelectedSlotIndex);
					if (scrollItemByIndex != null)
					{
						scrollItemByIndex.RefreshIcon();
					}
				}
			}
		}
		GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
		GenericLayout<FurnitureScrollItem, FurnitureScrollItemData> genericLayout = (furnitureScrollItemScrollView != null) ? furnitureScrollItemScrollView.GetGenericLayout() : null;
		if (genericLayout != null)
		{
			this.RefreshFurnitureScrollItemAfterSelect(selectedFurnitureIndex, genericLayout);
			this.RefreshFurnitureScrollItemAfterSelect(selectedFurnitureIndex2, genericLayout);
		}
		this.RefreshAtmosphereText(true);
		this.RefreshSaveBtn();
		EFurnitureDesignReportOperationType operationType = this.CurEditAreaData.UsePreset ? EFurnitureDesignReportOperationType.ChangeAfterPreset : EFurnitureDesignReportOperationType.OnlyChange;
		int value = (furnitureScrollItemData != null) ? furnitureScrollItemData.FurnitureConfig.Id : 0;
		int value2 = (furnitureScrollItemData2 != null) ? furnitureScrollItemData2.FurnitureConfig.Id : 0;
		FurnitureDesignReportContext context = new FurnitureDesignReportContext
		{
			AreaId = this.CurEditAreaData.GetAreaId(),
			OperationType = operationType,
			SlotContext = slotContext,
			OldFurnitureId = new int?(value),
			NewFurnitureId = new int?(value2)
		};
		FurnitureController.Instance.FurnitureDesignReport(context);
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x00151344 File Offset: 0x0014F544
	private void RefreshFurnitureScrollItemAfterSelect(int index, GenericLayout<FurnitureScrollItem, FurnitureScrollItemData> layout)
	{
		if (index == -1)
		{
			return;
		}
		FurnitureScrollItemData furnitureScrollItemData = (this.FurnitureScrollItemDataList.Count > index) ? this.FurnitureScrollItemDataList[index] : null;
		if (furnitureScrollItemData == null)
		{
			return;
		}
		this.UpdateFurnitureScrollItemDataLeftCount(furnitureScrollItemData);
		FurnitureScrollItem layoutItemByIndex = layout.GetLayoutItemByIndex(index);
		if (layoutItemByIndex != null)
		{
			layoutItemByIndex.RefreshCount();
			layoutItemByIndex.RefreshItemToggle(false);
		}
	}

	// Token: 0x06003B3F RID: 15167 RVA: 0x00151398 File Offset: 0x0014F598
	public void RefreshSwitchAreaBtn()
	{
		bool uiactive = this.AreaList.Count > 1;
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06003B40 RID: 15168 RVA: 0x001513E8 File Offset: 0x0014F5E8
	public void ResetSlotSelected()
	{
		this.SelectedSlotIndex = -1;
		this.SelectedSceneSlotEntityId = 0;
		this.SelectedSubSlotIndex = -1;
		this.SelectedSlotType = EFurnitureSlotType.SceneSlot;
		this.SelectedFurnitureIndex = -1;
		this.SelectedFurnitureConfigId = 0;
		this.FurnitureScrollItemDataList.Clear();
	}

	// Token: 0x06003B41 RID: 15169 RVA: 0x00151420 File Offset: 0x0014F620
	[NullableContext(2)]
	private void ShowConfirm(EConfirmBoxConfigId confirmBoxConfigId, Action leftFunc = null, Action rightFunc = null)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(confirmBoxConfigId);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(1, leftFunc);
		confirmBoxDataNew.FunctionMap.Add(2, rightFunc);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06003B42 RID: 15170 RVA: 0x00151464 File Offset: 0x0014F664
	[NullableContext(2)]
	public void TrySwitchArea(int areaIndex, int slotEntityId = 0, int subSlotIndex = -1, Action afterSwitch = null)
	{
		FurnitureAreaData curEditAreaData = this.CurEditAreaData;
		if (curEditAreaData == null)
		{
			return;
		}
		FurnitureAreaData originalAreaData = FurnitureModel.Instance.GetAreaData(this.SelectedAreaId);
		if (originalAreaData == null)
		{
			return;
		}
		FurnitureAreaData originalAreaData2 = originalAreaData;
		if (originalAreaData2 == null || !originalAreaData2.Compare(curEditAreaData))
		{
			this.ShowConfirm(EConfirmBoxConfigId.FurnitureSwitchAreaConfirm, delegate
			{
				this.SaveReport(false);
				FurnitureController.Instance.ChangeAreaFurnitureSceneItemsAsync(curEditAreaData, originalAreaData);
				FurnitureAreaData furnitureAreaData = new FurnitureAreaData();
				furnitureAreaData.DeepCopy(originalAreaData);
				if (this.EditorAreaDataMap != null)
				{
					if (this.EditorAreaDataMap.ContainsKey(originalAreaData.GetAreaId()))
					{
						this.EditorAreaDataMap[originalAreaData.GetAreaId()] = furnitureAreaData;
					}
					else
					{
						this.EditorAreaDataMap.Add(originalAreaData.GetAreaId(), furnitureAreaData);
					}
				}
				this.SwitchArea(areaIndex, slotEntityId, subSlotIndex);
				Action afterSwitch3 = afterSwitch;
				if (afterSwitch3 == null)
				{
					return;
				}
				afterSwitch3();
			}, delegate
			{
				this.SaveInternalAsync();
				this.SwitchArea(areaIndex, slotEntityId, subSlotIndex);
				Action afterSwitch3 = afterSwitch;
				if (afterSwitch3 == null)
				{
					return;
				}
				afterSwitch3();
			});
			return;
		}
		this.SwitchArea(areaIndex, slotEntityId, subSlotIndex);
		Action afterSwitch2 = afterSwitch;
		if (afterSwitch2 == null)
		{
			return;
		}
		afterSwitch2();
	}

	// Token: 0x06003B43 RID: 15171 RVA: 0x00151538 File Offset: 0x0014F738
	public void SwitchArea(int areaIndex, int slotEntityId = 0, int subSlotIndex = -1)
	{
		FurnitureDesignView.<>c__DisplayClass62_0 CS$<>8__locals1 = new FurnitureDesignView.<>c__DisplayClass62_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.areaIndex = areaIndex;
		CS$<>8__locals1.slotEntityId = slotEntityId;
		CS$<>8__locals1.subSlotIndex = subSlotIndex;
		UiAsyncTask task = new UiAsyncTask("SwitchArea", delegate()
		{
			FurnitureDesignView.<>c__DisplayClass62_0.<<SwitchArea>b__0>d <<SwitchArea>b__0>d;
			<<SwitchArea>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<SwitchArea>b__0>d.<>4__this = CS$<>8__locals1;
			<<SwitchArea>b__0>d.<>1__state = -1;
			<<SwitchArea>b__0>d.<>t__builder.Start<FurnitureDesignView.<>c__DisplayClass62_0.<<SwitchArea>b__0>d>(ref <<SwitchArea>b__0>d);
			return <<SwitchArea>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06003B44 RID: 15172 RVA: 0x00151588 File Offset: 0x0014F788
	public UniTask SwitchAreaAsync(int areaIndex, int slotEntityId = 0, int subSlotIndex = -1)
	{
		FurnitureDesignView.<SwitchAreaAsync>d__63 <SwitchAreaAsync>d__;
		<SwitchAreaAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SwitchAreaAsync>d__.<>4__this = this;
		<SwitchAreaAsync>d__.areaIndex = areaIndex;
		<SwitchAreaAsync>d__.slotEntityId = slotEntityId;
		<SwitchAreaAsync>d__.subSlotIndex = subSlotIndex;
		<SwitchAreaAsync>d__.<>1__state = -1;
		<SwitchAreaAsync>d__.<>t__builder.Start<FurnitureDesignView.<SwitchAreaAsync>d__63>(ref <SwitchAreaAsync>d__);
		return <SwitchAreaAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B45 RID: 15173 RVA: 0x001515E4 File Offset: 0x0014F7E4
	public void SelectAreaCameraToggle()
	{
		this.IsInAreaCamera = true;
		UUIExtendToggle extendToggle = base.GetExtendToggle(21);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(true);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(16);
		if (extendToggle2 != null)
		{
			extendToggle2.RootUIComp.Get().SetUIActive(false);
		}
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(22);
		if (extendToggle3 != null)
		{
			extendToggle3.RootUIComp.Get().SetUIActive(true);
		}
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId);
		this.FurnitureCameraComponent.EnterAreaCamera(furnitureAreaConfig.Value.CameraList(this.CurAreaCameraIndex), null);
		ScrollingTipsController.Instance.ShowTipsByTextId("DIY_CamEnterSuccess_Tip", Array.Empty<object>());
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayOrReplaySequenceByName("Hide", true, null);
		}
		this.RefreshAreaCameraSelectionItem();
	}

	// Token: 0x06003B46 RID: 15174 RVA: 0x001516C8 File Offset: 0x0014F8C8
	public void CancelAreaCameraToggle()
	{
		this.IsInAreaCamera = false;
		UUIExtendToggle extendToggle = base.GetExtendToggle(21);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(16);
		if (extendToggle2 != null)
		{
			extendToggle2.RootUIComp.Get().SetUIActive(true);
		}
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(22);
		if (extendToggle3 != null)
		{
			extendToggle3.RootUIComp.Get().SetUIActive(false);
		}
		this.EnterCurSelectedSceneSlotCamera(true);
		base.GetItem(17).SetUIActive(true);
		ScrollingTipsController.Instance.ShowTipsByTextId("DIY_CamBackSuccess_Tip", Array.Empty<object>());
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayOrReplaySequenceByName("Show", false, null);
		}
		this.RefreshAreaCameraSelectionItem();
	}

	// Token: 0x06003B47 RID: 15175 RVA: 0x00151790 File Offset: 0x0014F990
	public void EnterCurSelectedSceneSlotCamera(bool needFade = true)
	{
		if (this.SelectedSceneSlotEntityId == 0)
		{
			return;
		}
		IFurnitureCameraFadeInContext fadeInContext = null;
		if (!needFade)
		{
			fadeInContext = new FurnitureCameraFadeInContext
			{
				FadeInTime = 0f,
				FadeInExp = 0f
			};
		}
		FurnitureSlotContext slotContext = new FurnitureSlotContext
		{
			SlotEntityId = this.SelectedSceneSlotEntityId,
			SubSlotIndex = this.SelectedSubSlotIndex
		};
		this.FurnitureCameraComponent.EnterSlotCamera(slotContext, fadeInContext);
	}

	// Token: 0x06003B48 RID: 15176 RVA: 0x001517F2 File Offset: 0x0014F9F2
	public void RefreshFurnitureScrollItemLayout(bool bPlayAnimation = false)
	{
		GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
		if (furnitureScrollItemScrollView != null)
		{
			furnitureScrollItemScrollView.RefreshByData(this.FurnitureScrollItemDataList, new Action(this.LateScrollToFurnitureScrollItem), bPlayAnimation);
		}
		this.RefreshFurnitureEmptyItem();
	}

	// Token: 0x06003B49 RID: 15177 RVA: 0x00151820 File Offset: 0x0014FA20
	private void LateScrollToFurnitureScrollItem()
	{
		GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
		UUIItem uuiitem = (furnitureScrollItemScrollView != null) ? furnitureScrollItemScrollView.GetItemByIndex(0) : null;
		if (uuiitem != null)
		{
			GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView2 = this.FurnitureScrollItemScrollView;
			if (furnitureScrollItemScrollView2 == null)
			{
				return;
			}
			furnitureScrollItemScrollView2.LateScrollTo(uuiitem, null, false);
		}
	}

	// Token: 0x06003B4A RID: 15178 RVA: 0x00151858 File Offset: 0x0014FA58
	public void RefreshAtmosphereText(bool bPlayTween = false)
	{
		if (this.CurEditAreaData == null)
		{
			return;
		}
		int atmosphere = this.CurEditAreaData.GetAtmosphere();
		if (bPlayTween && this.OldAtmosphere != atmosphere)
		{
			UUIArtText artText = base.GetArtText(18);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.OldAtmosphere);
			artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			this.AtmosphereTween.PlayTween((float)this.OldAtmosphere, (float)atmosphere, 0.35f, null);
		}
		else
		{
			this.AtmosphereTween.KillTween();
			UUIArtText artText2 = base.GetArtText(18);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(atmosphere);
			artText2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		this.OldAtmosphere = atmosphere;
	}

	// Token: 0x06003B4B RID: 15179 RVA: 0x00151904 File Offset: 0x0014FB04
	public void RefreshAreaNameText()
	{
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), furnitureAreaConfig.Value.AreaName, Array.Empty<object>());
	}

	// Token: 0x06003B4C RID: 15180 RVA: 0x00151947 File Offset: 0x0014FB47
	public void RefreshFurnitureEmptyItem()
	{
		base.GetItem(15).SetUIActive(this.FurnitureScrollItemDataList.Count == 0);
	}

	// Token: 0x06003B4D RID: 15181 RVA: 0x00151964 File Offset: 0x0014FB64
	public void RefreshSaveBtn()
	{
		if (this.CurEditAreaData == null)
		{
			return;
		}
		FurnitureAreaData areaData = FurnitureModel.Instance.GetAreaData(this.SelectedAreaId);
		if (areaData == null)
		{
			return;
		}
		bool selfInteractive = !areaData.Compare(this.CurEditAreaData);
		base.GetButton(11).SetSelfInteractive(selfInteractive);
	}

	// Token: 0x06003B4E RID: 15182 RVA: 0x001519B0 File Offset: 0x0014FBB0
	public void RefreshAreaCameraSelectionItem()
	{
		bool flag = this.IsInAreaCamera && !this.IsInPreview;
		FurnitureAreaCameraSelectionItem areaCameraSelectionItem = this.AreaCameraSelectionItem;
		if (areaCameraSelectionItem != null)
		{
			areaCameraSelectionItem.SetUiActive(flag);
		}
		if (!flag)
		{
			return;
		}
		int id = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId).Value.CameraList(this.CurAreaCameraIndex);
		SpringFestivalAreaCamera? areaCameraConfig = FurnitureConfig.Instance.GetAreaCameraConfig(id);
		FurnitureAreaCameraSelectionItem areaCameraSelectionItem2 = this.AreaCameraSelectionItem;
		if (areaCameraSelectionItem2 == null)
		{
			return;
		}
		areaCameraSelectionItem2.Refresh(areaCameraConfig.Value.CameraName);
	}

	// Token: 0x06003B4F RID: 15183 RVA: 0x00151A3C File Offset: 0x0014FC3C
	public void RefreshPresetBtn()
	{
		bool furniturePresetFunctionIsUnlocked = FurnitureModel.Instance.GetFurniturePresetFunctionIsUnlocked();
		base.GetButton(20).RootUIComp.Get().SetUIActive(furniturePresetFunctionIsUnlocked);
	}

	// Token: 0x06003B50 RID: 15184 RVA: 0x00151A70 File Offset: 0x0014FC70
	public void RefreshAllSlotRedDot()
	{
		if (this.CurEditAreaData == null)
		{
			return;
		}
		foreach (FurnitureSlotScrollItemData furnitureSlotScrollItemData in this.SlotDataList)
		{
			furnitureSlotScrollItemData.RedDotShowState = FurnitureModel.Instance.CheckFurnitureSlotRedDot(this.CurEditAreaData, furnitureSlotScrollItemData.SceneSlotEntityId, furnitureSlotScrollItemData.SubSlotIndex);
		}
		GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> furnitureSlotScrollView = this.FurnitureSlotScrollView;
		List<FurnitureSlotScrollItem> list = (furnitureSlotScrollView != null) ? furnitureSlotScrollView.GetScrollItemList() : null;
		if (list == null)
		{
			return;
		}
		foreach (FurnitureSlotScrollItem furnitureSlotScrollItem in list)
		{
			furnitureSlotScrollItem.RefreshRedDot();
		}
	}

	// Token: 0x06003B51 RID: 15185 RVA: 0x00151B38 File Offset: 0x0014FD38
	private void OnClickCloseBtn()
	{
		if (this.EditorAreaDataMap == null || this.EditorAreaDataMap.Count == 0)
		{
			base.CloseMe(null);
			return;
		}
		List<FurnitureAreaData> diffOriginalAreaDataList = new List<FurnitureAreaData>();
		List<FurnitureAreaData> diffEditorAreaDataList = new List<FurnitureAreaData>();
		foreach (KeyValuePair<int, FurnitureAreaData> keyValuePair in this.EditorAreaDataMap)
		{
			int key = keyValuePair.Key;
			FurnitureAreaData value = keyValuePair.Value;
			FurnitureAreaData areaData = FurnitureModel.Instance.GetAreaData(key);
			if (areaData != null && !areaData.Compare(value))
			{
				diffOriginalAreaDataList.Add(areaData);
				diffEditorAreaDataList.Add(value);
			}
		}
		if (diffOriginalAreaDataList.Count == 0)
		{
			base.CloseMe(null);
			return;
		}
		Action<bool> <>9__2;
		this.ShowConfirm(EConfirmBoxConfigId.FurnitureExitConfirm, delegate
		{
			this.SaveReport(false);
			for (int i = 0; i < diffOriginalAreaDataList.Count; i++)
			{
				FurnitureController.Instance.ChangeAreaFurnitureSceneItemsAsync(diffEditorAreaDataList[i], diffOriginalAreaDataList[i]);
			}
			this.CloseMe(null);
		}, delegate
		{
			UniTask<bool> task = this.SaveInternalAsync();
			Action<bool> continuationFunction;
			if ((continuationFunction = <>9__2) == null)
			{
				continuationFunction = (<>9__2 = delegate(bool _)
				{
					this.CloseMe(null);
				});
			}
			task.ContinueWith(continuationFunction);
		});
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x00151C44 File Offset: 0x0014FE44
	private void OnAreaCameraSelectionPreBtnClick()
	{
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId);
		int[] array = furnitureAreaConfig.Value.CameraList();
		if (this.CurAreaCameraIndex == 0)
		{
			this.CurAreaCameraIndex = array.Length - 1;
		}
		else
		{
			this.CurAreaCameraIndex--;
		}
		this.FurnitureCameraComponent.EnterAreaCamera(furnitureAreaConfig.Value.CameraList(this.CurAreaCameraIndex), null);
		this.RefreshAreaCameraSelectionItem();
	}

	// Token: 0x06003B53 RID: 15187 RVA: 0x00151CBC File Offset: 0x0014FEBC
	private void OnAreaCameraSelectionNextBtnClick()
	{
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId);
		int[] array = furnitureAreaConfig.Value.CameraList();
		if (this.CurAreaCameraIndex == array.Length - 1)
		{
			this.CurAreaCameraIndex = 0;
		}
		else
		{
			this.CurAreaCameraIndex++;
		}
		this.FurnitureCameraComponent.EnterAreaCamera(furnitureAreaConfig.Value.CameraList(this.CurAreaCameraIndex), null);
		this.RefreshAreaCameraSelectionItem();
	}

	// Token: 0x06003B54 RID: 15188 RVA: 0x00151D38 File Offset: 0x0014FF38
	private void OnClickRightBtn()
	{
		int num = this.SelectedAreaIndex + 1;
		if (num >= this.AreaList.Count)
		{
			num = 0;
		}
		this.TrySwitchArea(num, 0, -1, null);
	}

	// Token: 0x06003B55 RID: 15189 RVA: 0x00151D68 File Offset: 0x0014FF68
	private void OnClickLeftBtn()
	{
		int num = this.SelectedAreaIndex - 1;
		if (num < 0)
		{
			num = this.AreaList.Count - 1;
		}
		this.TrySwitchArea(num, 0, -1, null);
	}

	// Token: 0x06003B56 RID: 15190 RVA: 0x00151D9A File Offset: 0x0014FF9A
	private void OnClickSaveBtn()
	{
		this.SaveInternalAsync().ContinueWith(delegate(bool result)
		{
			this.RefreshSaveBtn();
			this.UpdateOriginalPlacedFurnitureId();
			foreach (FurnitureScrollItemData furnitureScrollItemData in this.FurnitureScrollItemDataList)
			{
				furnitureScrollItemData.IsCheck = (furnitureScrollItemData.FurnitureConfig.Id == this.OriginalPlacedFurnitureId);
			}
			GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
			List<FurnitureScrollItem> list = (furnitureScrollItemScrollView != null) ? furnitureScrollItemScrollView.GetScrollItemList() : null;
			if (list != null)
			{
				foreach (FurnitureScrollItem furnitureScrollItem in list)
				{
					furnitureScrollItem.RefreshCheckItem();
				}
			}
		});
	}

	// Token: 0x06003B57 RID: 15191 RVA: 0x00151DB4 File Offset: 0x0014FFB4
	[NullableContext(0)]
	private UniTask<bool> SaveInternalAsync()
	{
		FurnitureDesignView.<SaveInternalAsync>d__82 <SaveInternalAsync>d__;
		<SaveInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SaveInternalAsync>d__.<>4__this = this;
		<SaveInternalAsync>d__.<>1__state = -1;
		<SaveInternalAsync>d__.<>t__builder.Start<FurnitureDesignView.<SaveInternalAsync>d__82>(ref <SaveInternalAsync>d__);
		return <SaveInternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B58 RID: 15192 RVA: 0x00151DF8 File Offset: 0x0014FFF8
	private UniTask TeleportInternalAsync(bool bSave, bool recover)
	{
		FurnitureDesignView.<TeleportInternalAsync>d__83 <TeleportInternalAsync>d__;
		<TeleportInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TeleportInternalAsync>d__.<>4__this = this;
		<TeleportInternalAsync>d__.bSave = bSave;
		<TeleportInternalAsync>d__.recover = recover;
		<TeleportInternalAsync>d__.<>1__state = -1;
		<TeleportInternalAsync>d__.<>t__builder.Start<FurnitureDesignView.<TeleportInternalAsync>d__83>(ref <TeleportInternalAsync>d__);
		return <TeleportInternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B59 RID: 15193 RVA: 0x00151E4C File Offset: 0x0015004C
	[NullableContext(0)]
	private UniTask<bool> ResetToBattleViewAsync()
	{
		FurnitureDesignView.<ResetToBattleViewAsync>d__84 <ResetToBattleViewAsync>d__;
		<ResetToBattleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ResetToBattleViewAsync>d__.<>1__state = -1;
		<ResetToBattleViewAsync>d__.<>t__builder.Start<FurnitureDesignView.<ResetToBattleViewAsync>d__84>(ref <ResetToBattleViewAsync>d__);
		return <ResetToBattleViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B5A RID: 15194 RVA: 0x00151E87 File Offset: 0x00150087
	private void OnClickAreaCameraToggle(EToggleState _)
	{
		this.SelectAreaCameraToggle();
	}

	// Token: 0x06003B5B RID: 15195 RVA: 0x00151E90 File Offset: 0x00150090
	private void OnClickPresetBtn()
	{
		if (this.CurEditAreaData == null)
		{
			return;
		}
		FurniturePresetViewOpenData param = new FurniturePresetViewOpenData
		{
			AreaData = this.CurEditAreaData,
			OnApplyDelegate = new Action<FurnitureAreaData>(this.OnApplyFurniturePreset)
		};
		UiManager.Instance.OpenView(EUiViewName.FurniturePresetView, param, null);
	}

	// Token: 0x06003B5C RID: 15196 RVA: 0x00151EDB File Offset: 0x001500DB
	private bool CanAreaCameraToggleExecuteChange()
	{
		return false;
	}

	// Token: 0x06003B5D RID: 15197 RVA: 0x00151EDE File Offset: 0x001500DE
	private bool CanBottomCameraToggleExecuteChange()
	{
		return false;
	}

	// Token: 0x06003B5E RID: 15198 RVA: 0x00151EE1 File Offset: 0x001500E1
	private bool CanEyeToggleExecuteChange()
	{
		return false;
	}

	// Token: 0x06003B5F RID: 15199 RVA: 0x00151EE4 File Offset: 0x001500E4
	private void OnClickEyeToggle(EToggleState _)
	{
		this.IsInPreview = true;
		base.GetButton(23).RootUIComp.Get().SetUIActive(true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(21);
		if (extendToggle2 != null)
		{
			extendToggle2.RootUIComp.Get().SetUIActive(false);
		}
		this.RefreshAreaCameraSelectionItem();
	}

	// Token: 0x06003B60 RID: 15200 RVA: 0x00151F5C File Offset: 0x0015015C
	private void OnClickMaskButton()
	{
		this.IsInPreview = false;
		base.GetButton(23).RootUIComp.Get().SetUIActive(false);
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		if (extendToggle != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(true);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(21);
		if (extendToggle2 != null)
		{
			extendToggle2.RootUIComp.Get().SetUIActive(true);
		}
		this.RefreshAreaCameraSelectionItem();
	}

	// Token: 0x06003B61 RID: 15201 RVA: 0x00151FD3 File Offset: 0x001501D3
	private void OnClickBottomCameraToggle(EToggleState _)
	{
		this.CancelAreaCameraToggle();
	}

	// Token: 0x06003B62 RID: 15202 RVA: 0x00151FDC File Offset: 0x001501DC
	private void OnClickSaveAndTeleportBtn()
	{
		if (this.CurEditAreaData == null)
		{
			return;
		}
		FurnitureAreaData areaData = FurnitureModel.Instance.GetAreaData(this.SelectedAreaId);
		if (areaData == null)
		{
			return;
		}
		if (!areaData.Compare(this.CurEditAreaData))
		{
			Action leftFunc = delegate()
			{
				this.TeleportInternalAsync(false, true);
			};
			Action rightFunc = delegate()
			{
				this.TeleportInternalAsync(true, false);
			};
			this.ShowConfirm(EConfirmBoxConfigId.FurnitureDesignSaveAndTeleportConfirm, leftFunc, rightFunc);
			return;
		}
		Action rightFunc2 = delegate()
		{
			this.TeleportInternalAsync(false, false);
		};
		this.ShowConfirm(EConfirmBoxConfigId.FurnitureTeleportConfirm, null, rightFunc2);
	}

	// Token: 0x06003B63 RID: 15203 RVA: 0x0015205C File Offset: 0x0015025C
	private void OnApplyFurniturePreset(FurnitureAreaData areaData)
	{
		this.UpdateSlotDataList();
		this.UpdateFurnitureScrollItemDataList();
		GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> furnitureSlotScrollView = this.FurnitureSlotScrollView;
		if (furnitureSlotScrollView != null)
		{
			furnitureSlotScrollView.RefreshByData(this.SlotDataList, null, false);
		}
		this.RefreshFurnitureScrollItemLayout(false);
		this.RefreshAtmosphereText(true);
		this.RefreshSaveBtn();
		if (this.CurEditAreaData != null)
		{
			this.CurEditAreaData.UsePreset = true;
		}
		EFurnitureDesignReportOperationType operationType = EFurnitureDesignReportOperationType.Preset;
		FurnitureDesignReportContext context = new FurnitureDesignReportContext
		{
			AreaId = this.CurEditAreaData.GetAreaId(),
			OperationType = operationType
		};
		FurnitureController.Instance.FurnitureDesignReport(context);
	}

	// Token: 0x06003B64 RID: 15204 RVA: 0x001520E1 File Offset: 0x001502E1
	private void OnClickFurnitureSlotScrollItem(int index)
	{
		this.SelectSlot(index);
	}

	// Token: 0x06003B65 RID: 15205 RVA: 0x001520EA File Offset: 0x001502EA
	private void OnFurnitureItemSelected(int index)
	{
		this.SelectFurniture(index);
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x001520F3 File Offset: 0x001502F3
	private void OnFurnitureItemUnSelected(int index)
	{
		this.SelectFurniture(-1);
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x001520FC File Offset: 0x001502FC
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Hide")
		{
			base.GetItem(17).SetUIActive(false);
		}
	}

	// Token: 0x06003B68 RID: 15208 RVA: 0x0015211C File Offset: 0x0015031C
	private EFurnitureCanNotClickReason CheckFurnitureCanClick(int index)
	{
		FurnitureScrollItemData furnitureScrollItemData = (this.FurnitureScrollItemDataList.Count > index) ? this.FurnitureScrollItemDataList[index] : null;
		if (furnitureScrollItemData == null)
		{
			return EFurnitureCanNotClickReason.ConfigNotFound;
		}
		if (furnitureScrollItemData.IsLock)
		{
			return EFurnitureCanNotClickReason.Lock;
		}
		int limitCount = furnitureScrollItemData.FurnitureConfig.LimitCount;
		if (!furnitureScrollItemData.IsSelected && limitCount > 0 && furnitureScrollItemData.LeftCount <= 0)
		{
			return EFurnitureCanNotClickReason.CountLimit;
		}
		int tagId = furnitureScrollItemData.FurnitureConfig.TagId;
		if (tagId <= 0)
		{
			return EFurnitureCanNotClickReason.ConfigNotFound;
		}
		FurnitureDiyTag? furnitureTagConfig = FurnitureConfig.Instance.GetFurnitureTagConfig(tagId);
		if (furnitureTagConfig == null)
		{
			return EFurnitureCanNotClickReason.ConfigNotFound;
		}
		if (furnitureTagConfig.Value.CanUnPlace || !furnitureScrollItemData.IsSelected)
		{
			return EFurnitureCanNotClickReason.None;
		}
		return EFurnitureCanNotClickReason.CanNotUnPlace;
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x001521C7 File Offset: 0x001503C7
	private bool OnFurnitureItemCanToggleChanged(int index)
	{
		return this.CheckFurnitureCanClick(index) == EFurnitureCanNotClickReason.None;
	}

	// Token: 0x06003B6A RID: 15210 RVA: 0x001521D4 File Offset: 0x001503D4
	private void OnFurnitureItemPointUpCallBack(int index)
	{
		EFurnitureCanNotClickReason efurnitureCanNotClickReason = this.CheckFurnitureCanClick(index);
		if (efurnitureCanNotClickReason == EFurnitureCanNotClickReason.None)
		{
			return;
		}
		switch (efurnitureCanNotClickReason)
		{
		case EFurnitureCanNotClickReason.Lock:
			this.HandleLockedFurniture(index);
			return;
		case EFurnitureCanNotClickReason.CountLimit:
			this.HandleCountLimitedFurniture(index);
			return;
		case EFurnitureCanNotClickReason.CanNotUnPlace:
			ScrollingTipsController.Instance.ShowTipsByTextId("DIY_RemoveBannedTips", Array.Empty<object>());
			return;
		default:
			return;
		}
	}

	// Token: 0x06003B6B RID: 15211 RVA: 0x00152228 File Offset: 0x00150428
	private void HandleLockedFurniture(int index)
	{
		Furniture? furniture;
		if (this.FurnitureScrollItemDataList.Count <= index)
		{
			furniture = null;
		}
		else
		{
			FurnitureScrollItemData furnitureScrollItemData = this.FurnitureScrollItemDataList[index];
			furniture = ((furnitureScrollItemData != null) ? new Furniture?(furnitureScrollItemData.FurnitureConfig) : null);
		}
		Furniture? furniture2 = furniture;
		if (furniture2 == null)
		{
			return;
		}
		if (furniture2.Value.SourceType == 1)
		{
			this.HandleShopSourceFurniture(furniture2.Value);
			return;
		}
		if (furniture2.Value.SourceType == 2)
		{
			this.HandleGiftSourceFurniture(furniture2.Value);
			return;
		}
		if (furniture2.Value.SourceType == 3)
		{
			this.HandleAtmosphereSourceFurniture(furniture2.Value);
		}
	}

	// Token: 0x06003B6C RID: 15212 RVA: 0x001522E0 File Offset: 0x001504E0
	private void HandleShopSourceFurniture(Furniture furnitureConfig)
	{
		int goodsId = furnitureConfig.GetWayId;
		if (goodsId <= 0)
		{
			return;
		}
		PayShopGoods payShopGoods = PayShopModel.Instance.GetPayShopGoods(goodsId);
		if (payShopGoods == null)
		{
			return;
		}
		bool furnitureShopFunctionIsUnlocked = FurnitureModel.Instance.GetFurnitureShopFunctionIsUnlocked();
		Action jumpFunction = null;
		string lockReasonTextId;
		if (!furnitureShopFunctionIsUnlocked)
		{
			lockReasonTextId = "DIY_Furniture_Obtain_AtmoLockedState";
		}
		else
		{
			lockReasonTextId = (payShopGoods.IfCanBuy() ? "" : payShopGoods.GetConditionTextId());
			jumpFunction = delegate()
			{
				this.JumpToFurnitureShop(goodsId);
			};
		}
		FurnitureGetWayViewData param = new FurnitureGetWayViewData
		{
			FurnitureConfig = furnitureConfig,
			LockReason = EFurnitureLockReason.Shop,
			LockReasonTextId = lockReasonTextId,
			JumpFunction = jumpFunction
		};
		UiManager.Instance.OpenView(EUiViewName.FurnitureGetWayView, param, null);
	}

	// Token: 0x06003B6D RID: 15213 RVA: 0x0015239C File Offset: 0x0015059C
	private void HandleGiftSourceFurniture(Furniture furnitureConfig)
	{
		FurnitureGetWayViewData param = new FurnitureGetWayViewData
		{
			FurnitureConfig = furnitureConfig,
			LockReason = EFurnitureLockReason.Gift,
			LockReasonTextId = "",
			JumpFunction = delegate
			{
				this.JumpToFurnitureGift(furnitureConfig);
			}
		};
		UiManager.Instance.OpenView(EUiViewName.FurnitureGetWayView, param, null);
	}

	// Token: 0x06003B6E RID: 15214 RVA: 0x00152404 File Offset: 0x00150604
	private void HandleAtmosphereSourceFurniture(Furniture furnitureConfig)
	{
		FurnitureGetWayViewData param = new FurnitureGetWayViewData
		{
			FurnitureConfig = furnitureConfig,
			LockReason = EFurnitureLockReason.Atmosphere,
			LockReasonTextId = "DIY_Furniture_Gain_AtmoLockedState",
			LockReasonTextParams = new string[]
			{
				furnitureConfig.GetWayId.ToString()
			}
		};
		UiManager.Instance.OpenView(EUiViewName.FurnitureGetWayView, param, null);
	}

	// Token: 0x06003B6F RID: 15215 RVA: 0x00152464 File Offset: 0x00150664
	private void HandleCountLimitedFurniture(int index)
	{
		if (this.EditorAreaDataMap == null || this.CurEditAreaData == null)
		{
			return;
		}
		Furniture? furniture;
		if (this.FurnitureScrollItemDataList.Count <= index)
		{
			furniture = null;
		}
		else
		{
			FurnitureScrollItemData furnitureScrollItemData = this.FurnitureScrollItemDataList[index];
			furniture = ((furnitureScrollItemData != null) ? new Furniture?(furnitureScrollItemData.FurnitureConfig) : null);
		}
		Furniture? furniture2 = furniture;
		if (furniture2 == null)
		{
			return;
		}
		int id = furniture2.Value.Id;
		IFurnitureAreaSlotContext oldAreaSlotContext = FurnitureModel.Instance.FindFurniturePlacedSlot(id, this.EditorAreaDataMap);
		if (oldAreaSlotContext == null)
		{
			return;
		}
		FurnitureSlotContext slotContext = new FurnitureSlotContext
		{
			SlotEntityId = this.SelectedSceneSlotEntityId,
			SubSlotIndex = this.SelectedSubSlotIndex
		};
		FurnitureAreaSlotContext targetContext = new FurnitureAreaSlotContext
		{
			AreaData = this.CurEditAreaData,
			SlotContext = slotContext
		};
		FurniturePlaceToNewSlotContext placeToNewSlotContext = new FurniturePlaceToNewSlotContext
		{
			SourceContext = oldAreaSlotContext,
			TargetContext = targetContext
		};
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(oldAreaSlotContext.AreaData.GetAreaId());
		FurnitureGetWayViewData param = new FurnitureGetWayViewData
		{
			FurnitureConfig = furniture2.Value,
			LockReason = EFurnitureLockReason.Occupied,
			LockReasonTextId = "DIY_OccupiedWindow_OccState_1",
			LockReasonTextParams = new string[]
			{
				ConfigMultiTextLang.GetLocalTextNew(furnitureAreaConfig.Value.AreaName, null)
			},
			JumpFunction = delegate
			{
				this.JumpToSlot(oldAreaSlotContext);
			},
			ConfirmFunction = delegate
			{
				this.ShowFurniturePlaceToNewSlotConfirm(placeToNewSlotContext);
			}
		};
		UiManager.Instance.OpenView(EUiViewName.FurnitureGetWayView, param, null);
	}

	// Token: 0x06003B70 RID: 15216 RVA: 0x0015260C File Offset: 0x0015080C
	private void OnFurnitureItemPointerEnter(int index)
	{
		FurnitureScrollItemData furnitureScrollItemData = (this.FurnitureScrollItemDataList.Count > index) ? this.FurnitureScrollItemDataList[index] : null;
		if (furnitureScrollItemData == null)
		{
			return;
		}
		if (!furnitureScrollItemData.RedDotShowState)
		{
			return;
		}
		FurnitureController.Instance.SetFurnitureDesignItemRedDotAsRead(furnitureScrollItemData.FurnitureConfig.Id);
		furnitureScrollItemData.RedDotShowState = false;
		GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
		FurnitureScrollItem furnitureScrollItem = (furnitureScrollItemScrollView != null) ? furnitureScrollItemScrollView.GetScrollItemByIndex(index) : null;
		if (furnitureScrollItem != null)
		{
			furnitureScrollItem.RefreshRedDot();
		}
		this.RefreshAllSlotRedDot();
	}

	// Token: 0x06003B71 RID: 15217 RVA: 0x00152688 File Offset: 0x00150888
	private void JumpToFurnitureShop(int goodsId)
	{
		UiManager.Instance.CloseView(EUiViewName.FurnitureGetWayView, delegate(bool result)
		{
			if (result)
			{
				FurnitureController.Instance.OpenFurnitureShopViewAsync(goodsId);
			}
		});
	}

	// Token: 0x06003B72 RID: 15218 RVA: 0x001526C0 File Offset: 0x001508C0
	private void JumpToFurnitureGift(Furniture furnitureConfig)
	{
		UiManager.Instance.CloseView(EUiViewName.FurnitureGetWayView, delegate(bool result)
		{
			FurnitureController.Instance.TryJumpToFurnitureGift(furnitureConfig);
		});
	}

	// Token: 0x06003B73 RID: 15219 RVA: 0x001526F8 File Offset: 0x001508F8
	private void JumpToSlot(IFurnitureAreaSlotContext areaSlotContext)
	{
		Action afterSwitch = delegate()
		{
			UiManager.Instance.CloseView(EUiViewName.FurnitureGetWayView, null);
		};
		int areaId = areaSlotContext.AreaData.GetAreaId();
		int num = this.AreaList.IndexOf(areaId);
		if (num == -1)
		{
			return;
		}
		IFurnitureSlotContext slotContext = areaSlotContext.SlotContext;
		int slotEntityId = slotContext.SlotEntityId;
		int subSlotIndex = slotContext.SubSlotIndex;
		this.TrySwitchArea(num, slotEntityId, subSlotIndex, afterSwitch);
	}

	// Token: 0x06003B74 RID: 15220 RVA: 0x00152764 File Offset: 0x00150964
	private void ShowFurniturePlaceToNewSlotConfirm(IFurniturePlaceToNewSlotContext placeToNewSlotContext)
	{
		Action rightFunc = delegate()
		{
			this.PlaceToNewSlotAsync(placeToNewSlotContext);
		};
		this.ShowConfirm(EConfirmBoxConfigId.FurniturePlaceToNewSlotConfirm, null, rightFunc);
	}

	// Token: 0x06003B75 RID: 15221 RVA: 0x001527A0 File Offset: 0x001509A0
	private UniTask PlaceToNewSlotAsync(IFurniturePlaceToNewSlotContext placeToNewSlotContext)
	{
		FurnitureDesignView.<PlaceToNewSlotAsync>d__112 <PlaceToNewSlotAsync>d__;
		<PlaceToNewSlotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaceToNewSlotAsync>d__.<>4__this = this;
		<PlaceToNewSlotAsync>d__.placeToNewSlotContext = placeToNewSlotContext;
		<PlaceToNewSlotAsync>d__.<>1__state = -1;
		<PlaceToNewSlotAsync>d__.<>t__builder.Start<FurnitureDesignView.<PlaceToNewSlotAsync>d__112>(ref <PlaceToNewSlotAsync>d__);
		return <PlaceToNewSlotAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003B76 RID: 15222 RVA: 0x001527EB File Offset: 0x001509EB
	private FurnitureSlotScrollItem InitFurnitureSlotScrollItem()
	{
		return new FurnitureSlotScrollItem
		{
			OnItemSelected = new Action<int>(this.OnClickFurnitureSlotScrollItem)
		};
	}

	// Token: 0x06003B77 RID: 15223 RVA: 0x00152804 File Offset: 0x00150A04
	private FurnitureScrollItem InitFurnitureItem()
	{
		return new FurnitureScrollItem
		{
			OnItemSelectedDelegate = new Action<int>(this.OnFurnitureItemSelected),
			OnItemUnSelectedDelegate = new Action<int>(this.OnFurnitureItemUnSelected),
			CanToggleChangedDelegate = new Func<int, bool>(this.OnFurnitureItemCanToggleChanged),
			OnPointUpCallBackDelegate = new Action<int>(this.OnFurnitureItemPointUpCallBack),
			OnPointerEnterDelegate = new Action<int>(this.OnFurnitureItemPointerEnter)
		};
	}

	// Token: 0x06003B78 RID: 15224 RVA: 0x00152870 File Offset: 0x00150A70
	private FurnitureAreaPointItem InitAreaPointItem()
	{
		return new FurnitureAreaPointItem();
	}

	// Token: 0x06003B79 RID: 15225 RVA: 0x00152878 File Offset: 0x00150A78
	private void OnAtmosphereTweenUpdate(float value)
	{
		int value2 = (int)value;
		UUIArtText artText = base.GetArtText(18);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
		artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06003B7A RID: 15226 RVA: 0x001528B0 File Offset: 0x00150AB0
	private void SaveReport(bool bSave)
	{
		FurnitureAreaData areaData = FurnitureModel.Instance.GetAreaData(this.SelectedAreaId);
		FurnitureAreaData curEditAreaData = this.CurEditAreaData;
		if (areaData == null || curEditAreaData == null)
		{
			return;
		}
		FurnitureSaveReportContext context = new FurnitureSaveReportContext
		{
			AreaId = this.SelectedAreaId,
			OldAreaData = areaData,
			NewAreaData = curEditAreaData,
			IsSave = bSave
		};
		FurnitureController.Instance.FurnitureSaveReport(context);
	}

	// Token: 0x06003B7B RID: 15227 RVA: 0x00152910 File Offset: 0x00150B10
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		string a = configParams[0];
		if (a == "Furniture")
		{
			int index = int.Parse(configParams[1]);
			GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
			FurnitureScrollItem furnitureScrollItem = (furnitureScrollItemScrollView != null) ? furnitureScrollItemScrollView.GetScrollItemByIndex(index) : null;
			UUIItem uuiitem = (furnitureScrollItem != null) ? furnitureScrollItem.GetRootItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else
		{
			if (!(a == "FurnitureSlot"))
			{
				return null;
			}
			int index2 = int.Parse(configParams[1]);
			GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> furnitureSlotScrollView = this.FurnitureSlotScrollView;
			FurnitureSlotScrollItem furnitureSlotScrollItem = (furnitureSlotScrollView != null) ? furnitureSlotScrollView.GetScrollItemByIndex(index2) : null;
			UUIItem uuiitem2 = (furnitureSlotScrollItem != null) ? furnitureSlotScrollItem.GetRootItem() : null;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}
	}

	// Token: 0x04002FC8 RID: 12232
	private int MapId;

	// Token: 0x04002FC9 RID: 12233
	private List<int> AreaList = new List<int>();

	// Token: 0x04002FCA RID: 12234
	private int SelectedAreaIndex = -1;

	// Token: 0x04002FCB RID: 12235
	private int SelectedAreaId;

	// Token: 0x04002FCC RID: 12236
	private int SelectedSlotIndex = -1;

	// Token: 0x04002FCD RID: 12237
	private int SelectedSceneSlotEntityId;

	// Token: 0x04002FCE RID: 12238
	private int SelectedSubSlotIndex = -1;

	// Token: 0x04002FCF RID: 12239
	private EFurnitureSlotType SelectedSlotType;

	// Token: 0x04002FD0 RID: 12240
	private int SelectedFurnitureIndex = -1;

	// Token: 0x04002FD1 RID: 12241
	private int SelectedFurnitureConfigId;

	// Token: 0x04002FD2 RID: 12242
	private int OriginalPlacedFurnitureId;

	// Token: 0x04002FD3 RID: 12243
	private int CurAreaCameraIndex;

	// Token: 0x04002FD4 RID: 12244
	[Nullable(2)]
	private FurnitureAreaData CurEditAreaData;

	// Token: 0x04002FD5 RID: 12245
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, FurnitureAreaData> EditorAreaDataMap;

	// Token: 0x04002FD6 RID: 12246
	private readonly List<FurnitureSlotScrollItemData> SlotDataList = new List<FurnitureSlotScrollItemData>();

	// Token: 0x04002FD7 RID: 12247
	private readonly List<FurnitureScrollItemData> FurnitureScrollItemDataList = new List<FurnitureScrollItemData>();

	// Token: 0x04002FD8 RID: 12248
	private readonly List<bool> AreaPointDataList = new List<bool>();

	// Token: 0x04002FD9 RID: 12249
	private readonly Dictionary<int, int> TagCounterMap = new Dictionary<int, int>();

	// Token: 0x04002FDA RID: 12250
	private bool IsExchanging;

	// Token: 0x04002FDB RID: 12251
	private int OldAtmosphere;

	// Token: 0x04002FDC RID: 12252
	private bool IsInAreaCamera;

	// Token: 0x04002FDD RID: 12253
	private bool IsInPreview;

	// Token: 0x04002FDE RID: 12254
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002FDF RID: 12255
	[Nullable(2)]
	private FurnitureAreaCameraSelectionItem AreaCameraSelectionItem;

	// Token: 0x04002FE0 RID: 12256
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> FurnitureSlotScrollView;

	// Token: 0x04002FE1 RID: 12257
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> FurnitureScrollItemScrollView;

	// Token: 0x04002FE2 RID: 12258
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FurnitureAreaPointItem, bool> AreaPointLayout;

	// Token: 0x04002FE3 RID: 12259
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04002FE4 RID: 12260
	protected LguiFloatTween AtmosphereTween;

	// Token: 0x04002FE5 RID: 12261
	private readonly FurnitureCameraComponent FurnitureCameraComponent = new FurnitureCameraComponent();
}
