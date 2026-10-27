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

// Token: 0x02000FC9 RID: 4041
[NullableContext(1)]
[Nullable(0)]
public class FurnitureDesignView : UiViewBase
{
	// Token: 0x0600678B RID: 26507 RVA: 0x00147B50 File Offset: 0x00145D50
	public FurnitureDesignView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600678C RID: 26508 RVA: 0x00147BC4 File Offset: 0x00145DC4
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

	// Token: 0x0600678D RID: 26509 RVA: 0x00147EC8 File Offset: 0x001460C8
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureDesignView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureDesignView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600678E RID: 26510 RVA: 0x00147F0C File Offset: 0x0014610C
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		FurnitureDesignView.<OnBeforeShowAsyncImplementImplement>d__33 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<FurnitureDesignView.<OnBeforeShowAsyncImplementImplement>d__33>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600678F RID: 26511 RVA: 0x00147F4F File Offset: 0x0014614F
	protected override void OnBeforeHide()
	{
		this.ResumeTimeDilation();
	}

	// Token: 0x06006790 RID: 26512 RVA: 0x00147F58 File Offset: 0x00146158
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

	// Token: 0x06006791 RID: 26513 RVA: 0x00147FB6 File Offset: 0x001461B6
	protected virtual void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("FurnitureDesignView");
	}

	// Token: 0x06006792 RID: 26514 RVA: 0x00147FC7 File Offset: 0x001461C7
	protected virtual void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("FurnitureDesignView");
	}

	// Token: 0x06006793 RID: 26515 RVA: 0x00147FD8 File Offset: 0x001461D8
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

	// Token: 0x06006794 RID: 26516 RVA: 0x00148078 File Offset: 0x00146278
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

	// Token: 0x06006795 RID: 26517 RVA: 0x00148108 File Offset: 0x00146308
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

	// Token: 0x06006796 RID: 26518 RVA: 0x001481B4 File Offset: 0x001463B4
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

	// Token: 0x06006797 RID: 26519 RVA: 0x001482A0 File Offset: 0x001464A0
	private void UpdateAreaPointDataList()
	{
		this.AreaPointDataList.Clear();
		foreach (int num in this.AreaList)
		{
			this.AreaPointDataList.Add(num == this.SelectedAreaId);
		}
	}

	// Token: 0x06006798 RID: 26520 RVA: 0x0014830C File Offset: 0x0014650C
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

	// Token: 0x06006799 RID: 26521 RVA: 0x00148338 File Offset: 0x00146538
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

	// Token: 0x0600679A RID: 26522 RVA: 0x001483B0 File Offset: 0x001465B0
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

	// Token: 0x0600679B RID: 26523 RVA: 0x00148444 File Offset: 0x00146644
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

	// Token: 0x0600679C RID: 26524 RVA: 0x0014848C File Offset: 0x0014668C
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

	// Token: 0x0600679D RID: 26525 RVA: 0x00148504 File Offset: 0x00146704
	private void UpdateSlotSelectedState()
	{
		this.SelectedSlotIndex = this.SlotDataList.FindIndex(new Predicate<FurnitureSlotScrollItemData>(this.IsSlotMatched));
		for (int i = 0; i < this.SlotDataList.Count; i++)
		{
			this.SlotDataList[i].IsSelected = (i == this.SelectedSlotIndex);
		}
	}

	// Token: 0x0600679E RID: 26526 RVA: 0x00148560 File Offset: 0x00146760
	private void UpdateSlotLineState()
	{
		int count = this.SlotDataList.Count;
		for (int i = 0; i < count; i++)
		{
			this.SlotDataList[i].LineShowState = (i != count - 1);
		}
	}

	// Token: 0x0600679F RID: 26527 RVA: 0x001485A0 File Offset: 0x001467A0
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

	// Token: 0x060067A0 RID: 26528 RVA: 0x00148644 File Offset: 0x00146844
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

	// Token: 0x060067A1 RID: 26529 RVA: 0x00148714 File Offset: 0x00146914
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

	// Token: 0x060067A2 RID: 26530 RVA: 0x00148740 File Offset: 0x00146940
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

	// Token: 0x060067A3 RID: 26531 RVA: 0x0014878B File Offset: 0x0014698B
	private bool IsSlotMatched(FurnitureSlotScrollItemData slotData)
	{
		return slotData.SlotType == this.SelectedSlotType && slotData.SceneSlotEntityId == this.SelectedSceneSlotEntityId && slotData.SubSlotIndex == this.SelectedSubSlotIndex;
	}

	// Token: 0x060067A4 RID: 26532 RVA: 0x001487BC File Offset: 0x001469BC
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

	// Token: 0x060067A5 RID: 26533 RVA: 0x00148830 File Offset: 0x00146A30
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

	// Token: 0x060067A6 RID: 26534 RVA: 0x00148A80 File Offset: 0x00146C80
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

	// Token: 0x060067A7 RID: 26535 RVA: 0x00148AD4 File Offset: 0x00146CD4
	public void RefreshSwitchAreaBtn()
	{
		bool uiactive = this.AreaList.Count > 1;
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(4).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060067A8 RID: 26536 RVA: 0x00148B24 File Offset: 0x00146D24
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

	// Token: 0x060067A9 RID: 26537 RVA: 0x00148B5C File Offset: 0x00146D5C
	[NullableContext(2)]
	private void ShowConfirm(EConfirmBoxConfigId confirmBoxConfigId, Action leftFunc = null, Action rightFunc = null)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(confirmBoxConfigId);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(1, leftFunc);
		confirmBoxDataNew.FunctionMap.Add(2, rightFunc);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060067AA RID: 26538 RVA: 0x00148BA0 File Offset: 0x00146DA0
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

	// Token: 0x060067AB RID: 26539 RVA: 0x00148C74 File Offset: 0x00146E74
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

	// Token: 0x060067AC RID: 26540 RVA: 0x00148CC4 File Offset: 0x00146EC4
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

	// Token: 0x060067AD RID: 26541 RVA: 0x00148D20 File Offset: 0x00146F20
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

	// Token: 0x060067AE RID: 26542 RVA: 0x00148E04 File Offset: 0x00147004
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

	// Token: 0x060067AF RID: 26543 RVA: 0x00148ECC File Offset: 0x001470CC
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

	// Token: 0x060067B0 RID: 26544 RVA: 0x00148F2E File Offset: 0x0014712E
	public void RefreshFurnitureScrollItemLayout(bool bPlayAnimation = false)
	{
		GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> furnitureScrollItemScrollView = this.FurnitureScrollItemScrollView;
		if (furnitureScrollItemScrollView != null)
		{
			furnitureScrollItemScrollView.RefreshByData(this.FurnitureScrollItemDataList, new Action(this.LateScrollToFurnitureScrollItem), bPlayAnimation);
		}
		this.RefreshFurnitureEmptyItem();
	}

	// Token: 0x060067B1 RID: 26545 RVA: 0x00148F5C File Offset: 0x0014715C
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

	// Token: 0x060067B2 RID: 26546 RVA: 0x00148F94 File Offset: 0x00147194
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

	// Token: 0x060067B3 RID: 26547 RVA: 0x00149040 File Offset: 0x00147240
	public void RefreshAreaNameText()
	{
		SpringFestivalArea? furnitureAreaConfig = FurnitureConfig.Instance.GetFurnitureAreaConfig(this.SelectedAreaId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), furnitureAreaConfig.Value.AreaName, Array.Empty<object>());
	}

	// Token: 0x060067B4 RID: 26548 RVA: 0x00149083 File Offset: 0x00147283
	public void RefreshFurnitureEmptyItem()
	{
		base.GetItem(15).SetUIActive(this.FurnitureScrollItemDataList.Count == 0);
	}

	// Token: 0x060067B5 RID: 26549 RVA: 0x001490A0 File Offset: 0x001472A0
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

	// Token: 0x060067B6 RID: 26550 RVA: 0x001490EC File Offset: 0x001472EC
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

	// Token: 0x060067B7 RID: 26551 RVA: 0x00149178 File Offset: 0x00147378
	public void RefreshPresetBtn()
	{
		bool furniturePresetFunctionIsUnlocked = FurnitureModel.Instance.GetFurniturePresetFunctionIsUnlocked();
		base.GetButton(20).RootUIComp.Get().SetUIActive(furniturePresetFunctionIsUnlocked);
	}

	// Token: 0x060067B8 RID: 26552 RVA: 0x001491AC File Offset: 0x001473AC
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

	// Token: 0x060067B9 RID: 26553 RVA: 0x00149274 File Offset: 0x00147474
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

	// Token: 0x060067BA RID: 26554 RVA: 0x00149380 File Offset: 0x00147580
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

	// Token: 0x060067BB RID: 26555 RVA: 0x001493F8 File Offset: 0x001475F8
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

	// Token: 0x060067BC RID: 26556 RVA: 0x00149474 File Offset: 0x00147674
	private void OnClickRightBtn()
	{
		int num = this.SelectedAreaIndex + 1;
		if (num >= this.AreaList.Count)
		{
			num = 0;
		}
		this.TrySwitchArea(num, 0, -1, null);
	}

	// Token: 0x060067BD RID: 26557 RVA: 0x001494A4 File Offset: 0x001476A4
	private void OnClickLeftBtn()
	{
		int num = this.SelectedAreaIndex - 1;
		if (num < 0)
		{
			num = this.AreaList.Count - 1;
		}
		this.TrySwitchArea(num, 0, -1, null);
	}

	// Token: 0x060067BE RID: 26558 RVA: 0x001494D6 File Offset: 0x001476D6
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

	// Token: 0x060067BF RID: 26559 RVA: 0x001494F0 File Offset: 0x001476F0
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

	// Token: 0x060067C0 RID: 26560 RVA: 0x00149534 File Offset: 0x00147734
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

	// Token: 0x060067C1 RID: 26561 RVA: 0x00149588 File Offset: 0x00147788
	[NullableContext(0)]
	private UniTask<bool> ResetToBattleViewAsync()
	{
		FurnitureDesignView.<ResetToBattleViewAsync>d__84 <ResetToBattleViewAsync>d__;
		<ResetToBattleViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ResetToBattleViewAsync>d__.<>1__state = -1;
		<ResetToBattleViewAsync>d__.<>t__builder.Start<FurnitureDesignView.<ResetToBattleViewAsync>d__84>(ref <ResetToBattleViewAsync>d__);
		return <ResetToBattleViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060067C2 RID: 26562 RVA: 0x001495C3 File Offset: 0x001477C3
	private void OnClickAreaCameraToggle(EToggleState _)
	{
		this.SelectAreaCameraToggle();
	}

	// Token: 0x060067C3 RID: 26563 RVA: 0x001495CC File Offset: 0x001477CC
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

	// Token: 0x060067C4 RID: 26564 RVA: 0x00149617 File Offset: 0x00147817
	private bool CanAreaCameraToggleExecuteChange()
	{
		return false;
	}

	// Token: 0x060067C5 RID: 26565 RVA: 0x0014961A File Offset: 0x0014781A
	private bool CanBottomCameraToggleExecuteChange()
	{
		return false;
	}

	// Token: 0x060067C6 RID: 26566 RVA: 0x0014961D File Offset: 0x0014781D
	private bool CanEyeToggleExecuteChange()
	{
		return false;
	}

	// Token: 0x060067C7 RID: 26567 RVA: 0x00149620 File Offset: 0x00147820
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

	// Token: 0x060067C8 RID: 26568 RVA: 0x00149698 File Offset: 0x00147898
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

	// Token: 0x060067C9 RID: 26569 RVA: 0x0014970F File Offset: 0x0014790F
	private void OnClickBottomCameraToggle(EToggleState _)
	{
		this.CancelAreaCameraToggle();
	}

	// Token: 0x060067CA RID: 26570 RVA: 0x00149718 File Offset: 0x00147918
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

	// Token: 0x060067CB RID: 26571 RVA: 0x00149798 File Offset: 0x00147998
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

	// Token: 0x060067CC RID: 26572 RVA: 0x0014981D File Offset: 0x00147A1D
	private void OnClickFurnitureSlotScrollItem(int index)
	{
		this.SelectSlot(index);
	}

	// Token: 0x060067CD RID: 26573 RVA: 0x00149826 File Offset: 0x00147A26
	private void OnFurnitureItemSelected(int index)
	{
		this.SelectFurniture(index);
	}

	// Token: 0x060067CE RID: 26574 RVA: 0x0014982F File Offset: 0x00147A2F
	private void OnFurnitureItemUnSelected(int index)
	{
		this.SelectFurniture(-1);
	}

	// Token: 0x060067CF RID: 26575 RVA: 0x00149838 File Offset: 0x00147A38
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Hide")
		{
			base.GetItem(17).SetUIActive(false);
		}
	}

	// Token: 0x060067D0 RID: 26576 RVA: 0x00149858 File Offset: 0x00147A58
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

	// Token: 0x060067D1 RID: 26577 RVA: 0x00149903 File Offset: 0x00147B03
	private bool OnFurnitureItemCanToggleChanged(int index)
	{
		return this.CheckFurnitureCanClick(index) == EFurnitureCanNotClickReason.None;
	}

	// Token: 0x060067D2 RID: 26578 RVA: 0x00149910 File Offset: 0x00147B10
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

	// Token: 0x060067D3 RID: 26579 RVA: 0x00149964 File Offset: 0x00147B64
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

	// Token: 0x060067D4 RID: 26580 RVA: 0x00149A1C File Offset: 0x00147C1C
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

	// Token: 0x060067D5 RID: 26581 RVA: 0x00149AD8 File Offset: 0x00147CD8
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

	// Token: 0x060067D6 RID: 26582 RVA: 0x00149B40 File Offset: 0x00147D40
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

	// Token: 0x060067D7 RID: 26583 RVA: 0x00149BA0 File Offset: 0x00147DA0
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

	// Token: 0x060067D8 RID: 26584 RVA: 0x00149D48 File Offset: 0x00147F48
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

	// Token: 0x060067D9 RID: 26585 RVA: 0x00149DC4 File Offset: 0x00147FC4
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

	// Token: 0x060067DA RID: 26586 RVA: 0x00149DFC File Offset: 0x00147FFC
	private void JumpToFurnitureGift(Furniture furnitureConfig)
	{
		UiManager.Instance.CloseView(EUiViewName.FurnitureGetWayView, delegate(bool result)
		{
			FurnitureController.Instance.TryJumpToFurnitureGift(furnitureConfig);
		});
	}

	// Token: 0x060067DB RID: 26587 RVA: 0x00149E34 File Offset: 0x00148034
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

	// Token: 0x060067DC RID: 26588 RVA: 0x00149EA0 File Offset: 0x001480A0
	private void ShowFurniturePlaceToNewSlotConfirm(IFurniturePlaceToNewSlotContext placeToNewSlotContext)
	{
		Action rightFunc = delegate()
		{
			this.PlaceToNewSlotAsync(placeToNewSlotContext);
		};
		this.ShowConfirm(EConfirmBoxConfigId.FurniturePlaceToNewSlotConfirm, null, rightFunc);
	}

	// Token: 0x060067DD RID: 26589 RVA: 0x00149EDC File Offset: 0x001480DC
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

	// Token: 0x060067DE RID: 26590 RVA: 0x00149F27 File Offset: 0x00148127
	private FurnitureSlotScrollItem InitFurnitureSlotScrollItem()
	{
		return new FurnitureSlotScrollItem
		{
			OnItemSelected = new Action<int>(this.OnClickFurnitureSlotScrollItem)
		};
	}

	// Token: 0x060067DF RID: 26591 RVA: 0x00149F40 File Offset: 0x00148140
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

	// Token: 0x060067E0 RID: 26592 RVA: 0x00149FAC File Offset: 0x001481AC
	private FurnitureAreaPointItem InitAreaPointItem()
	{
		return new FurnitureAreaPointItem();
	}

	// Token: 0x060067E1 RID: 26593 RVA: 0x00149FB4 File Offset: 0x001481B4
	private void OnAtmosphereTweenUpdate(float value)
	{
		int value2 = (int)value;
		UUIArtText artText = base.GetArtText(18);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
		artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060067E2 RID: 26594 RVA: 0x00149FEC File Offset: 0x001481EC
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

	// Token: 0x060067E3 RID: 26595 RVA: 0x0014A04C File Offset: 0x0014824C
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

	// Token: 0x04002F2F RID: 12079
	private int MapId;

	// Token: 0x04002F30 RID: 12080
	private List<int> AreaList = new List<int>();

	// Token: 0x04002F31 RID: 12081
	private int SelectedAreaIndex = -1;

	// Token: 0x04002F32 RID: 12082
	private int SelectedAreaId;

	// Token: 0x04002F33 RID: 12083
	private int SelectedSlotIndex = -1;

	// Token: 0x04002F34 RID: 12084
	private int SelectedSceneSlotEntityId;

	// Token: 0x04002F35 RID: 12085
	private int SelectedSubSlotIndex = -1;

	// Token: 0x04002F36 RID: 12086
	private EFurnitureSlotType SelectedSlotType;

	// Token: 0x04002F37 RID: 12087
	private int SelectedFurnitureIndex = -1;

	// Token: 0x04002F38 RID: 12088
	private int SelectedFurnitureConfigId;

	// Token: 0x04002F39 RID: 12089
	private int OriginalPlacedFurnitureId;

	// Token: 0x04002F3A RID: 12090
	private int CurAreaCameraIndex;

	// Token: 0x04002F3B RID: 12091
	[Nullable(2)]
	private FurnitureAreaData CurEditAreaData;

	// Token: 0x04002F3C RID: 12092
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, FurnitureAreaData> EditorAreaDataMap;

	// Token: 0x04002F3D RID: 12093
	private readonly List<FurnitureSlotScrollItemData> SlotDataList = new List<FurnitureSlotScrollItemData>();

	// Token: 0x04002F3E RID: 12094
	private readonly List<FurnitureScrollItemData> FurnitureScrollItemDataList = new List<FurnitureScrollItemData>();

	// Token: 0x04002F3F RID: 12095
	private readonly List<bool> AreaPointDataList = new List<bool>();

	// Token: 0x04002F40 RID: 12096
	private readonly Dictionary<int, int> TagCounterMap = new Dictionary<int, int>();

	// Token: 0x04002F41 RID: 12097
	private bool IsExchanging;

	// Token: 0x04002F42 RID: 12098
	private int OldAtmosphere;

	// Token: 0x04002F43 RID: 12099
	private bool IsInAreaCamera;

	// Token: 0x04002F44 RID: 12100
	private bool IsInPreview;

	// Token: 0x04002F45 RID: 12101
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002F46 RID: 12102
	[Nullable(2)]
	private FurnitureAreaCameraSelectionItem AreaCameraSelectionItem;

	// Token: 0x04002F47 RID: 12103
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FurnitureSlotScrollItem, FurnitureSlotScrollItemData> FurnitureSlotScrollView;

	// Token: 0x04002F48 RID: 12104
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FurnitureScrollItem, FurnitureScrollItemData> FurnitureScrollItemScrollView;

	// Token: 0x04002F49 RID: 12105
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FurnitureAreaPointItem, bool> AreaPointLayout;

	// Token: 0x04002F4A RID: 12106
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04002F4B RID: 12107
	protected LguiFloatTween AtmosphereTween;

	// Token: 0x04002F4C RID: 12108
	private readonly FurnitureCameraComponent FurnitureCameraComponent = new FurnitureCameraComponent();
}
