using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.RoleUi.TabView.VisionSubView;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x020024C5 RID: 9413
[NullableContext(1)]
[Nullable(0)]
public class VisionEquipmentView : UiViewBase
{
	// Token: 0x06012DF1 RID: 77297 RVA: 0x004A8CFC File Offset: 0x004A6EFC
	public VisionEquipmentView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012DF2 RID: 77298 RVA: 0x004A8D90 File Offset: 0x004A6F90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUISprite)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(30, typeof(UUIText)),
			new ValueTuple<int, Type>(31, typeof(UUIItem)),
			new ValueTuple<int, Type>(32, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(33, typeof(UUIItem)),
			new ValueTuple<int, Type>(34, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(35, typeof(UUIItem)),
			new ValueTuple<int, Type>(37, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(21, new Action<EToggleState>(this.OnSimplyButtonClick)),
			new ValueTuple<int, Delegate>(27, new Action(this.OnMonsterSkinBtnClick)),
			new ValueTuple<int, Delegate>(29, new Action(this.OnClickCompareButton)),
			new ValueTuple<int, Delegate>(32, new Action(this.OnClickJumpVisionRecoveryButton)),
			new ValueTuple<int, Delegate>(34, new Action<EToggleState>(this.OnClickRecommendToggle))
		};
	}

	// Token: 0x06012DF3 RID: 77299 RVA: 0x004A917C File Offset: 0x004A737C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.RefreshPhantom));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add(EEventName.PhantomEquipError, new Action(this.OnEquipError));
		EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		EventSystem.Instance.Add<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
		EventSystem.Instance.Add(EEventName.VisionFilterMonster, new Action(this.OnVisionFilterMonster));
		EventSystem.Instance.Add<UiCameraAnimationDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnCameraFinish));
		EventSystem.Instance.Add<bool>(EEventName.VisionSkinViewClose, new Action<bool>(this.VisionSkinViewClose));
		EventSystem.Instance.Add<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Add<int, int>(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
	}

	// Token: 0x06012DF4 RID: 77300 RVA: 0x004A92C0 File Offset: 0x004A74C0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.RefreshPhantom));
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.PhantomEquipError, new Action(this.OnEquipError));
		EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		EventSystem.Instance.Remove<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
		EventSystem.Instance.Remove(EEventName.VisionFilterMonster, new Action(this.OnVisionFilterMonster));
		EventSystem.Instance.Remove<UiCameraAnimationDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraAnimationDefine.IFinishData>(this.OnCameraFinish));
		EventSystem.Instance.Remove<bool>(EEventName.VisionSkinViewClose, new Action<bool>(this.VisionSkinViewClose));
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
	}

	// Token: 0x06012DF5 RID: 77301 RVA: 0x004A9404 File Offset: 0x004A7604
	protected override void OnStart()
	{
		this.InitUiBlur();
		this.CameraState = false;
		base.GetItem(15).SetUIActive(true);
		base.GetItem(15).SetRaycastTarget(false);
		base.GetItem(9).SetUIActive(true);
		this.FilterEntrance = new FilterEntrance<IPhantomItemData>(base.GetItem(12), new TUpdateDataListFunction<IPhantomItemData>(this.OnFilterRefresh));
		this.FilterEntrance.OnBtnClearClickCallback = delegate()
		{
			this.VisionEquipmentRecommendItem.ClearSelectMainPhantom(true);
		};
		this.SortEntrance = new SortEntrance<IPhantomItemData>(base.GetItem(13), new TUpdateDataListFunction<IPhantomItemData>(this.OnFilterRefresh));
		this.LoopScrollView = new LoopScrollView<VisionMediumItemGrid, PhantomBattleData>(base.GetLoopScrollViewComponent(6), base.GetItem(8).GetOwner() as AUIBaseActor, new Func<VisionMediumItemGrid>(this.InitItem), false);
		this.InitDetailItem();
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAlpha(1f);
		}
		this.RootLevelSequence = new LevelSequencePlayer(this.RootItem);
		this.RootLevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
		base.GetItem(14).SetUIActive(false);
		this.RefreshUiBlur(false);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(7));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.LongPressTime = (float)PhantomBattleConfig.Instance.GetVisionScrollerPressTime();
		this.ScrollerMoveDistance = (float)PhantomBattleConfig.Instance.GetVisionScrollerMoveDistance();
		this.BeforeLongPressTime = (float)PhantomBattleConfig.Instance.GetVisionBeforeScrollerLongPressTime();
		this.InitCurrentSelectVision();
		this.ShowDefaultElement();
		this.SetPressItemShowState(false);
		base.GetVerticalLayout(17).SetEnable(false);
		this.VisionDetailComponentCompare.RefreshViewByCompareState(true);
		this.InitCostTab();
		this.InitDropDown();
		this.InitState = true;
		EToggleState state = PhantomBattleModel.Instance.GetIfSimpleState(1) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(21);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		this.RootLevelSequence.PlaySequencePurely("ContrastSwitch", false, true, null, null, false);
		this.CurrentAnimationState = false;
		base.GetButton(32).RootUIComp.Get().SetUIActive(FunctionModel.Instance.IsOpen(10024001));
	}

	// Token: 0x06012DF6 RID: 77302 RVA: 0x004A963A File Offset: 0x004A783A
	private void InitUiBlur()
	{
		AUIBaseActor rootActor = this.RootActor;
		this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		if (this.UiBlur != null)
		{
			this.UiBlur.SetEnableUiBlur(false);
		}
	}

	// Token: 0x06012DF7 RID: 77303 RVA: 0x004A9678 File Offset: 0x004A7878
	protected override void OnHandlePostLoadScene(bool isSceneLoad)
	{
		if (this.PreSelectMeshId <= 0)
		{
			return;
		}
		if (PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.PreSelectMeshId) != null)
		{
			if (PhantomBattleModel.Instance.GetPhantomBattleData(this.PreSelectMeshId) != null)
			{
				this.RefreshMesh(this.PreSelectMeshId, false);
				SkeletalObserverHandle visionSkeletalHandle = this.VisionSkeletalHandle;
				if (((visionSkeletalHandle != null) ? visionSkeletalHandle.Model : null) != null)
				{
					PhantomBattleController.Instance.SetMeshTransform(this.VisionSkeletalHandle);
					return;
				}
			}
		}
		else
		{
			this.CurrentSelectPhantomData = null;
		}
	}

	// Token: 0x06012DF8 RID: 77304 RVA: 0x004A96EC File Offset: 0x004A78EC
	private void SequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "ContrastSwitch")
		{
			base.GetItem(11).SetUIActive(this.CurrentAnimationState);
		}
	}

	// Token: 0x06012DF9 RID: 77305 RVA: 0x004A970E File Offset: 0x004A790E
	private void OnDeselectMainPhantomCallback()
	{
		FilterEntrance<IPhantomItemData> filterEntrance = this.FilterEntrance;
		if (filterEntrance != null)
		{
			filterEntrance.TryClearData();
		}
		this.MultiSelectDropDown.SetSelectedIndices(new List<int>
		{
			0
		});
		this.RefreshSelectAllToggleState();
	}

	// Token: 0x06012DFA RID: 77306 RVA: 0x004A9740 File Offset: 0x004A7940
	private void OnMainPhantomFilterChanged(IMainPhantomFilterChangedInfo info)
	{
		if (info.IsDeselect)
		{
			return;
		}
		int num = this.CostArray.IndexOf(info.Cost);
		if (num >= 0)
		{
			StaticTabComponent<CostTabItem> staticTabComponent = this.StaticTabComponent;
			if (staticTabComponent == null)
			{
				return;
			}
			staticTabComponent.SelectToggleByIndex(num, false);
		}
	}

	// Token: 0x06012DFB RID: 77307 RVA: 0x004A9780 File Offset: 0x004A7980
	private void OnSelectAllCallback(List<int> fetterGroupIds, bool isSelectAll)
	{
		FilterEntrance<IPhantomItemData> filterEntrance = this.FilterEntrance;
		if (filterEntrance != null)
		{
			filterEntrance.TryClearData();
		}
		if (isSelectAll)
		{
			List<int> list = (from id in fetterGroupIds
			select this.FetterSuitFilterArray.IndexOf(id) into idx
			where idx > 0
			select idx).ToList<int>();
			MultiSelectDropDown<int, int> multiSelectDropDown = this.MultiSelectDropDown;
			List<int> selectedIndices;
			if (list.Count <= 0)
			{
				(selectedIndices = new List<int>()).Add(0);
			}
			else
			{
				selectedIndices = list;
			}
			multiSelectDropDown.SetSelectedIndices(selectedIndices);
		}
		else
		{
			this.MultiSelectDropDown.SetSelectedIndices(new List<int>
			{
				0
			});
		}
		this.UpdateFilterComponent();
		this.RefreshSelectAllToggleState();
	}

	// Token: 0x06012DFC RID: 77308 RVA: 0x004A9828 File Offset: 0x004A7A28
	private void RefreshSelectAllToggleState()
	{
		if (this.VisionEquipmentRecommendItem == null)
		{
			return;
		}
		List<int> selectedFetterGroupIds = this.GetSelectedFetterGroupIds();
		this.VisionEquipmentRecommendItem.RefreshSelectAllToggleState(selectedFetterGroupIds);
	}

	// Token: 0x06012DFD RID: 77309 RVA: 0x004A9854 File Offset: 0x004A7A54
	private void OnChangeSelectRecommendAttr()
	{
		if (this.InitState)
		{
			VisionMainSelectPhantomData currentMainPhantom = VisionRecommendModel.Instance.CurrentMainPhantom;
			if (currentMainPhantom != null)
			{
				int num = this.FetterSuitFilterArray.IndexOf(currentMainPhantom.FetterGroupId);
				if (num > 0)
				{
					this.MultiSelectDropDown.SetSelectedIndices(new List<int>
					{
						num
					});
				}
				else
				{
					this.MultiSelectDropDown.SetSelectedIndices(new List<int>
					{
						0
					});
				}
				this.OnClickVisionAndRefreshVisionView(0);
				this.FilterEntrance.SelectSingleById(currentMainPhantom.MonsterId);
			}
			this.UpdateFilterComponent();
		}
		VisionEquipmentRecommendFetterGroupView visionEquipmentRecommendFetterGroupView = this.VisionEquipmentRecommendFetterGroupView;
		if (visionEquipmentRecommendFetterGroupView != null)
		{
			visionEquipmentRecommendFetterGroupView.Refresh(this.VisionEquipmentRecommendItem.CurrentPlanInfo.BuildFetterList());
		}
		this.RefreshSelectAllToggleState();
	}

	// Token: 0x06012DFE RID: 77310 RVA: 0x004A9904 File Offset: 0x004A7B04
	protected override UniTask OnBeforeStartAsync()
	{
		VisionEquipmentView.<OnBeforeStartAsync>d__75 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionEquipmentView.<OnBeforeStartAsync>d__75>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DFF RID: 77311 RVA: 0x004A9948 File Offset: 0x004A7B48
	private void InitDetailItem()
	{
		this.VisionDetailComponent.GetDetailUnderComponent().SetRightButtonClick(new Action(this.OnClickLevelUpButton));
		this.VisionDetailComponent.GetDetailUnderComponent().SetLeftButtonClick(new Action(this.OnClickEquipButton));
		this.VisionDetailComponent.SetActive(false);
		this.VisionDetailComponentCompare.SetButtonPanelShowState(true);
		this.VisionDetailComponentCompare.SetActive(true);
	}

	// Token: 0x06012E00 RID: 77312 RVA: 0x004A99B4 File Offset: 0x004A7BB4
	private UniTask InitVisionTabItem()
	{
		VisionEquipmentView.<InitVisionTabItem>d__77 <InitVisionTabItem>d__;
		<InitVisionTabItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitVisionTabItem>d__.<>4__this = this;
		<InitVisionTabItem>d__.<>1__state = -1;
		<InitVisionTabItem>d__.<>t__builder.Start<VisionEquipmentView.<InitVisionTabItem>d__77>(ref <InitVisionTabItem>d__);
		return <InitVisionTabItem>d__.<>t__builder.Task;
	}

	// Token: 0x06012E01 RID: 77313 RVA: 0x004A99F8 File Offset: 0x004A7BF8
	private void InitDropDown()
	{
		List<VisionFetterRecommendInfo> recommendInfoList = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.RoleId);
		IEnumerable<PhantomFetterGroup> fetterGroupArray = PhantomBattleConfig.Instance.GetFetterGroupArray();
		this.FetterSortIdMap.Clear();
		foreach (PhantomFetterGroup phantomFetterGroup in fetterGroupArray)
		{
			this.FetterSuitFilterArray.Add(phantomFetterGroup.Id);
			this.FetterSortIdMap[phantomFetterGroup.Id] = phantomFetterGroup.SortId;
		}
		this.FetterSuitFilterArray.Sort(delegate(int a, int b)
		{
			VisionFetterRecommendInfo visionFetterRecommendInfo = (recommendInfoList != null) ? recommendInfoList.Find((VisionFetterRecommendInfo item) => item.GetRecommendFetterGroupId() == a) : null;
			VisionFetterRecommendInfo visionFetterRecommendInfo2 = (recommendInfoList != null) ? recommendInfoList.Find((VisionFetterRecommendInfo item) => item.GetRecommendFetterGroupId() == b) : null;
			if (visionFetterRecommendInfo != null && visionFetterRecommendInfo2 == null)
			{
				return -1;
			}
			if (visionFetterRecommendInfo == null && visionFetterRecommendInfo2 != null)
			{
				return 1;
			}
			if (visionFetterRecommendInfo != null && visionFetterRecommendInfo2 != null)
			{
				int usage = visionFetterRecommendInfo.GetUsage();
				return visionFetterRecommendInfo2.GetUsage() - usage;
			}
			int num = this.FetterSortIdMap.ContainsKey(a) ? this.FetterSortIdMap[a] : 0;
			return (this.FetterSortIdMap.ContainsKey(b) ? this.FetterSortIdMap[b] : 0) - num;
		});
		this.FetterSuitFilterArray.Insert(0, 0);
		this.MultiSelectDropDown.SetOnCloseCall(new Action<List<int>>(this.OnDropDownClose));
		this.MultiSelectDropDown.SetOnItemToggleCall(new Action<int, bool>(this.OnSuitToggled));
		this.MultiSelectDropDown.SetShowType(ECommonDropDownShowType.Down);
		this.MultiSelectDropDown.InitScroll(this.FetterSuitFilterArray, new Func<int, int>(this.GetDropDownTextId), new List<int>
		{
			0
		});
	}

	// Token: 0x06012E02 RID: 77314 RVA: 0x004A9B24 File Offset: 0x004A7D24
	private void OnSuitToggled(int index, bool isSelected)
	{
		this.DropDownDirty = true;
		if (index == 0 && isSelected)
		{
			using (List<int>.Enumerator enumerator = this.MultiSelectDropDown.GetSelectedIndices().ToList<int>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					if (num != 0)
					{
						this.MultiSelectDropDown.ToggleItem(num, false);
					}
				}
				goto IL_80;
			}
		}
		if (index != 0 && isSelected && this.MultiSelectDropDown.GetSelectedIndices().Contains(0))
		{
			this.MultiSelectDropDown.ToggleItem(0, false);
		}
		IL_80:
		if (this.MultiSelectDropDown.GetSelectedIndices().Count == 0)
		{
			this.MultiSelectDropDown.ToggleItem(0, true);
		}
	}

	// Token: 0x06012E03 RID: 77315 RVA: 0x004A9BE0 File Offset: 0x004A7DE0
	private void OnDropDownClose(List<int> indices)
	{
		if (this.InitState && this.DropDownDirty)
		{
			this.DropDownDirty = false;
			this.UpdateFilterComponent();
			VisionMainSelectPhantomData currentMainPhantom = VisionRecommendModel.Instance.CurrentMainPhantom;
			if (currentMainPhantom != null)
			{
				List<int> selectedFetterGroupIds = this.GetSelectedFetterGroupIds();
				if (selectedFetterGroupIds.Count > 0 && !selectedFetterGroupIds.Contains(currentMainPhantom.FetterGroupId))
				{
					this.VisionEquipmentRecommendItem.ClearSelectMainPhantom(false);
				}
			}
		}
		this.RefreshSelectAllToggleState();
	}

	// Token: 0x06012E04 RID: 77316 RVA: 0x004A9C48 File Offset: 0x004A7E48
	private int GetDropDownTextId(int data)
	{
		return data;
	}

	// Token: 0x06012E05 RID: 77317 RVA: 0x004A9C4B File Offset: 0x004A7E4B
	private VisionEquipmentDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
	{
		VisionEquipmentDropDownItem visionEquipmentDropDownItem = new VisionEquipmentDropDownItem(uiItem);
		visionEquipmentDropDownItem.SetRoleId(this.RoleId);
		return visionEquipmentDropDownItem;
	}

	// Token: 0x06012E06 RID: 77318 RVA: 0x004A9C5F File Offset: 0x004A7E5F
	private VisionEquipmentMultiSelectDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new VisionEquipmentMultiSelectDropDownTitleItem(uiItem);
	}

	// Token: 0x06012E07 RID: 77319 RVA: 0x004A9C68 File Offset: 0x004A7E68
	private List<int> GetSelectedFetterGroupIds()
	{
		MultiSelectDropDown<int, int> multiSelectDropDown = this.MultiSelectDropDown;
		IReadOnlySet<int> readOnlySet = (multiSelectDropDown != null) ? multiSelectDropDown.GetSelectedIndices() : null;
		if (readOnlySet == null || readOnlySet.Contains(0) || readOnlySet.Count == 0)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		foreach (int index in readOnlySet)
		{
			int num = this.FetterSuitFilterArray[index];
			if (num > 0)
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x06012E08 RID: 77320 RVA: 0x004A9CF8 File Offset: 0x004A7EF8
	private void InitCostTab()
	{
		int num = 23;
		int num2 = 26;
		List<UUIItem> list = new List<UUIItem>();
		for (int i = num; i <= num2; i++)
		{
			UUIItem item = base.GetItem(i);
			if (item != null)
			{
				list.Add(item);
			}
		}
		UUIItem item2 = base.GetItem(20);
		this.StaticTabComponent = new StaticTabComponent<CostTabItem>(new Func<UUIItem, int, CostTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack));
		this.StaticTabComponent.Init(list);
		int num3 = item2.GetAttachUIChildren().Num();
		for (int j = 0; j < num3; j++)
		{
			int num4 = j;
			if (j > 1)
			{
				num4++;
			}
			this.CostArray.Add(num4);
		}
		this.StaticTabComponent.SelectToggleByIndex(0, true);
	}

	// Token: 0x06012E09 RID: 77321 RVA: 0x004A9DAB File Offset: 0x004A7FAB
	private CostTabItem TabItemProxyCreate(UUIItem uiItem, int index)
	{
		CostTabItem costTabItem = new CostTabItem(uiItem);
		costTabItem.Init();
		return costTabItem;
	}

	// Token: 0x06012E0A RID: 77322 RVA: 0x004A9DB9 File Offset: 0x004A7FB9
	private void ToggleCallBack(int index)
	{
		this.CurrentCost = this.CostArray[index];
		this.VisionEquipmentRecommendItem.ChangeCost(this.CurrentCost, this.RoleId);
	}

	// Token: 0x06012E0B RID: 77323 RVA: 0x004A9DE4 File Offset: 0x004A7FE4
	private void OnSimplyButtonClick(EToggleState toggleState)
	{
		PhantomBattleModel.Instance.SaveIfSimpleState(1, toggleState != EToggleState.ETT_Checked);
	}

	// Token: 0x06012E0C RID: 77324 RVA: 0x004A9DF8 File Offset: 0x004A7FF8
	private void OnMonsterSkinBtnClick()
	{
		VisionSkinViewOpenParam visionSkinViewOpenParam = new VisionSkinViewOpenParam();
		PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
		visionSkinViewOpenParam.UniqueId = ((currentSelectPhantomData != null) ? new int?(currentSelectPhantomData.GetUniqueId()) : null);
		visionSkinViewOpenParam.ShowItemIdList = null;
		IVisionSkinViewOpenParam param = visionSkinViewOpenParam;
		UiManager.Instance.OpenView(EUiViewName.VisionSkinView, param, null);
	}

	// Token: 0x06012E0D RID: 77325 RVA: 0x004A9E48 File Offset: 0x004A8048
	private void OnCameraFinish(UiCameraAnimationDefine.IFinishData finishData)
	{
		if (finishData.ToHandleData.ViewName != EUiViewName.VisionEquipmentView)
		{
			return;
		}
		if (!base.IsShowOrShowing)
		{
			return;
		}
		if (!this.CameraState)
		{
			this.CameraState = true;
			this.RefreshMesh((this.CurrentSelectPhantomData != null) ? this.CurrentSelectPhantomData.GetUniqueId() : 0, false);
		}
	}

	// Token: 0x06012E0E RID: 77326 RVA: 0x004A9EA8 File Offset: 0x004A80A8
	private void VisionSkinViewClose(bool skinChanged)
	{
		if (!skinChanged)
		{
			return;
		}
		int currentMeshId = this.CurrentMeshId;
		this.CurrentMeshId = 0;
		this.RefreshMesh(currentMeshId, false);
	}

	// Token: 0x06012E0F RID: 77327 RVA: 0x004A9ED0 File Offset: 0x004A80D0
	private void InitCurrentSelectVision()
	{
		if (this.PresetSelectIndexInternal >= 0)
		{
			this.CurrentSelectIndex = (EPhantomItemIndex)this.PresetSelectIndexInternal;
			PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = this.PresetSelectIndexInternal;
		}
		else
		{
			this.CurrentSelectIndex = (EPhantomItemIndex)PhantomBattleModel.Instance.CurrentEquipmentSelectIndex;
		}
		int currentSelectUniqueId = PhantomBattleModel.Instance.CurrentSelectUniqueId;
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(currentSelectUniqueId);
		if (currentSelectUniqueId > 0 && phantomBattleData != null)
		{
			this.SetCurrentSelectPhantomData(phantomBattleData);
			return;
		}
		this.SetCurrentSelectPhantomData(this.GetCurrentSelectIndexPhantomData((int)this.CurrentSelectIndex));
	}

	// Token: 0x06012E10 RID: 77328 RVA: 0x004A9F4C File Offset: 0x004A814C
	private void TryUnbindConfirmButtonRedDot()
	{
		if (this.CurrentConfirmButtonRedDotUniqueId > 0)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.VisionIdentifyTab, base.GetItem(28), this.CurrentConfirmButtonRedDotUniqueId);
			this.CurrentConfirmButtonRedDotUniqueId = 0;
		}
	}

	// Token: 0x06012E11 RID: 77329 RVA: 0x004A9F78 File Offset: 0x004A8178
	private void RefreshConfirmButtonRedDot()
	{
		this.TryUnbindConfirmButtonRedDot();
		if (this.CurrentSelectPhantomData != null)
		{
			this.CurrentConfirmButtonRedDotUniqueId = this.CurrentSelectPhantomData.GetUniqueId();
			RedDotController.Instance.BindRedDot(ERedDotName.VisionIdentifyTab, base.GetItem(28), null, this.CurrentConfirmButtonRedDotUniqueId);
		}
	}

	// Token: 0x06012E12 RID: 77330 RVA: 0x004A9FB4 File Offset: 0x004A81B4
	private void ShowDefaultElement()
	{
		this.RefreshView(this.CurrentSelectPhantomData);
		this.RefreshMesh((this.CurrentSelectPhantomData != null) ? this.CurrentSelectPhantomData.GetUniqueId() : 0, false);
		this.RefreshPhantomClickState();
	}

	// Token: 0x06012E13 RID: 77331 RVA: 0x004A9FE8 File Offset: 0x004A81E8
	private void OnClickEquipButton()
	{
		if (this.CurrentSelectPhantomData == null || PhantomBattleModel.Instance.GetPhantomBattleData(this.CurrentSelectPhantomData.GetUniqueId()) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.TZJ;
			string message = "[声骸堆叠] 装配按钮选中记录已不存在，忽略操作";
			string item = "uniqueId";
			PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (currentSelectPhantomData != null) ? currentSelectPhantomData.GetUniqueId() : 0);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		RoleInstance roleInstance = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		Action doFunction = delegate()
		{
			PhantomBattleController.Instance.SendPhantomPutOnRequest(this.CurrentSelectPhantomData.GetUniqueId(), roleInstance.GetRoleId(), (int)this.CurrentSelectIndex, -1, false);
		};
		this.DoEquip(this.CurrentSelectPhantomData, (int)this.CurrentSelectIndex, doFunction);
	}

	// Token: 0x06012E14 RID: 77332 RVA: 0x004AA095 File Offset: 0x004A8295
	private void SetPressItemAlpha(float alpha)
	{
		base.GetItem(18).SetAlpha(alpha);
		this.LongPressItemAlpha = alpha;
	}

	// Token: 0x06012E15 RID: 77333 RVA: 0x004AA0AC File Offset: 0x004A82AC
	private void SetPressItemShowState(bool state)
	{
		base.GetItem(18).SetUIActive(state);
	}

	// Token: 0x06012E16 RID: 77334 RVA: 0x004AA0BC File Offset: 0x004A82BC
	private void DoEquip(PhantomBattleData phantomData, int targetIndex, Action doFunction)
	{
		if (!this.CheckCost(phantomData, targetIndex))
		{
			this.ResetVisionPosition(true);
			return;
		}
		this.TryEquip(phantomData, targetIndex, doFunction);
	}

	// Token: 0x06012E17 RID: 77335 RVA: 0x004AA0DC File Offset: 0x004A82DC
	private bool CheckCost(PhantomBattleData phantomData, int targetIndex)
	{
		int? equipRole = PhantomBattleController.Instance.GetEquipRole(phantomData.GetUniqueId());
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		int roleIndexPhantomId = instance.GetRoleIndexPhantomId(roleInstanceById.GetRoleId(), targetIndex);
		int num = (instance.GetPhantomBattleData(roleIndexPhantomId) != null) ? instance.GetPhantomBattleData(roleIndexPhantomId).GetCost() : 0;
		int roleCurrentPhantomCost = instance.GetRoleCurrentPhantomCost(roleInstanceById.GetRoleId());
		if (equipRole != null && equipRole.Value != roleInstanceById.GetRoleId())
		{
			int num2 = instance.GetRoleCurrentPhantomCost(equipRole.Value) - phantomData.GetCost() + num;
			int num3 = roleCurrentPhantomCost - num + phantomData.GetCost();
			if (num2 > this.GetCostMax() || num3 > this.GetCostMax())
			{
				this.TryShowMaxCost();
				return false;
			}
		}
		else
		{
			if (equipRole != null && equipRole.Value == roleInstanceById.GetRoleId())
			{
				return true;
			}
			if (roleCurrentPhantomCost - num + phantomData.GetCost() > this.GetCostMax())
			{
				this.TryShowMaxCost();
				return false;
			}
		}
		return true;
	}

	// Token: 0x06012E18 RID: 77336 RVA: 0x004AA1D8 File Offset: 0x004A83D8
	private void TryShowMaxCost()
	{
		if (this.GetCostMax() < PhantomBattleConfig.Instance.GetVisionReachableCostMax())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.JumpToCalabash);
			Action value = delegate()
			{
				this.DestroyVisionHandle();
				UiManager.Instance.OpenView(EUiViewName.CalabashRootView, null, delegate(bool success, int _)
				{
					if (success)
					{
						UiManager.Instance.CloseView(EUiViewName.VisionEquipmentView, null);
						EventSystem.Instance.Emit(EEventName.PhantomCostInsufficient);
					}
				});
			};
			confirmBoxDataNew.FunctionMap.Add(1, value);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.CostMax);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
	}

	// Token: 0x06012E19 RID: 77337 RVA: 0x004AA248 File Offset: 0x004A8448
	private void RefreshCostText()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		int num = PhantomBattleModel.Instance.GetRoleCurrentPhantomCost(roleInstanceById.GetRoleId());
		int roleIndexPhantomId = PhantomBattleModel.Instance.GetRoleIndexPhantomId(roleInstanceById.GetRoleId(), (int)this.CurrentSelectIndex);
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleInstanceById.GetRoleId()).GetIncrIdList();
		int num2 = (this.CurrentSelectPhantomData != null) ? this.CurrentSelectPhantomData.GetUniqueId() : 0;
		bool flag = false;
		if (incrIdList != null)
		{
			for (int i = 0; i < incrIdList.Count; i++)
			{
				if (incrIdList[i] == num2)
				{
					flag = true;
					break;
				}
			}
		}
		if (roleIndexPhantomId > 0 && !flag)
		{
			PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(roleIndexPhantomId);
			num -= phantomDataBase.GetCost();
		}
		if (!flag)
		{
			num += ((this.CurrentSelectPhantomData != null) ? this.CurrentSelectPhantomData.GetCost() : 0);
		}
		string hexStr;
		string hexStr2;
		if (num > this.GetCostMax())
		{
			hexStr = PhantomBattleConfig.Instance.GetVisionCostColorAlert();
			hexStr2 = PhantomBattleConfig.Instance.GetVisionCostColorFull();
			if (!this.IfPlayingCostBlinkAnimate)
			{
				this.RootLevelSequence.PlaySequencePurely("CostBlink", false, false, null, null, false);
				this.IfPlayingCostBlinkAnimate = true;
			}
		}
		else if (num == this.GetCostMax())
		{
			hexStr = PhantomBattleConfig.Instance.GetVisionCostColorFull();
			hexStr2 = PhantomBattleConfig.Instance.GetVisionCostColorFull();
			this.RootLevelSequence.StopSequenceByKey("CostBlink", false, true);
			this.IfPlayingCostBlinkAnimate = false;
		}
		else
		{
			hexStr = PhantomBattleConfig.Instance.GetVisionCostColorBase();
			hexStr2 = PhantomBattleConfig.Instance.GetVisionCostColorBase();
			this.RootLevelSequence.StopSequenceByKey("CostBlink", false, true);
			this.IfPlayingCostBlinkAnimate = false;
		}
		base.GetText(5).SetText(StringUtils.Format("/{0}", new string[]
		{
			this.GetCostMax().ToString()
		}), true);
		base.GetText(30).SetText(StringUtils.Format("{0}", new string[]
		{
			num.ToString()
		}), true);
		base.GetText(30).SetColor(FColor.FromHex(hexStr));
		base.GetText(5).SetColor(FColor.FromHex(hexStr2));
	}

	// Token: 0x06012E1A RID: 77338 RVA: 0x004AA464 File Offset: 0x004A8664
	private void OnClickLevelUpButton()
	{
		VisionIntensifyViewPassData visionIntensifyViewPassData = new VisionIntensifyViewPassData
		{
			UniqueId = this.CurrentSelectPhantomData.GetUniqueId(),
			Cost = this.CurrentCost,
			RoleId = this.RoleId
		};
		this.VisionIntensifyPassData = visionIntensifyViewPassData;
		UiManager.Instance.OpenView(EUiViewName.VisionIntensifyView, visionIntensifyViewPassData, null);
	}

	// Token: 0x06012E1B RID: 77339 RVA: 0x004AA4B8 File Offset: 0x004A86B8
	private void OnClickJumpVisionRecoveryButton()
	{
		this.PreSelectMeshId = this.CurrentMeshId;
		this.DestroyVisionHandle();
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
	}

	// Token: 0x06012E1C RID: 77340 RVA: 0x004AA4DC File Offset: 0x004A86DC
	private void OnClickRecommendToggle(EToggleState toggleState)
	{
		if (this.CurrentCompareState)
		{
			this.OnCompareButtonClicked();
		}
		if (base.GetExtendToggle(34).GetToggleState() == EToggleState.ETT_Checked)
		{
			this.VisionEquipmentRecommendItem.Show(null);
			return;
		}
		this.VisionEquipmentRecommendItem.Hide(null);
	}

	// Token: 0x06012E1D RID: 77341 RVA: 0x004AA517 File Offset: 0x004A8717
	private void OnClickCompareButton()
	{
		if (base.GetExtendToggle(34).GetToggleState() == EToggleState.ETT_Checked)
		{
			base.GetExtendToggle(34).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.VisionEquipmentRecommendItem.Hide(null);
		}
		this.OnCompareButtonClicked();
	}

	// Token: 0x06012E1E RID: 77342 RVA: 0x004AA550 File Offset: 0x004A8750
	private void OnCompareButtonClicked()
	{
		this.CurrentCompareState = !this.CurrentCompareState;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		int roleIndexPhantomId = PhantomBattleModel.Instance.GetRoleIndexPhantomId(roleInstanceById.GetRoleId(), (int)this.CurrentSelectIndex);
		if (roleIndexPhantomId > 0)
		{
			if (this.CurrentCompareState)
			{
				base.GetItem(11).SetUIActive(true);
				this.RootLevelSequence.StopSequenceByKey("ContrastSwitch", false, false);
				this.RootLevelSequence.PlaySequencePurely("ContrastSwitch", false, false, null, null, false);
				this.CurrentAnimationState = true;
			}
			else
			{
				if (this.CurrentAnimationState)
				{
					this.RootLevelSequence.StopSequenceByKey("ContrastSwitch", false, false);
					this.RootLevelSequence.PlaySequencePurely("ContrastSwitch", false, true, null, null, false);
				}
				this.CurrentAnimationState = false;
			}
		}
		else
		{
			this.CurrentCompareState = false;
		}
		bool flag = this.CurrentCompareState && roleIndexPhantomId > 0;
		base.GetItem(14).SetUIActive(flag);
		this.RefreshUiBlur(flag);
		this.RefreshVisionDetailCompare();
	}

	// Token: 0x06012E1F RID: 77343 RVA: 0x004AA65C File Offset: 0x004A885C
	private void RefreshVisionDetailCompare()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(roleInstanceById.GetRoleId(), (int)this.CurrentSelectIndex);
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(equipByIndex);
		if (phantomBattleData != null)
		{
			this.VisionDetailComponentCompare.Update(phantomBattleData, this.RoleId, this.CurrentCost, true);
			return;
		}
		RoleInstance roleInstanceById2 = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (PhantomBattleModel.Instance.GetRoleIndexPhantomId(roleInstanceById2.GetRoleId(), (int)this.CurrentSelectIndex) == 0 && this.CurrentAnimationState)
		{
			this.RootLevelSequence.PlaySequencePurely("ContrastSwitch", false, true, null, null, false);
			this.CurrentAnimationState = false;
			this.CurrentCompareState = false;
		}
	}

	// Token: 0x06012E20 RID: 77344 RVA: 0x004AA717 File Offset: 0x004A8917
	private void RefreshUiBlur(bool state)
	{
		if (this.UiBlur != null)
		{
			this.UiBlur.SetEnableUiBlur(state);
		}
	}

	// Token: 0x06012E21 RID: 77345 RVA: 0x004AA730 File Offset: 0x004A8930
	private VisionMediumItemGrid InitItem()
	{
		VisionMediumItemGrid visionMediumItemGrid = new VisionMediumItemGrid();
		visionMediumItemGrid.Source = this.Source;
		visionMediumItemGrid.RoleId = this.RoleId;
		visionMediumItemGrid.SetUseFixedAsync(true);
		visionMediumItemGrid.SetClickToggleEvent(new Action<PhantomBattleData, int>(this.OnPhantomItemClick));
		visionMediumItemGrid.SetOnRefreshEvent(new Action<VisionMediumItemGrid>(this.OnItemRefresh));
		visionMediumItemGrid.SetOnPointDownCallBack(new Action<VisionMediumItemGrid, PhantomBattleData>(this.OnPhantomPointerDown));
		visionMediumItemGrid.SetOnPointUpCallBack(new Action<VisionMediumItemGrid, PhantomBattleData>(this.OnPhantomPointerUp));
		return visionMediumItemGrid;
	}

	// Token: 0x06012E22 RID: 77346 RVA: 0x004AA7A9 File Offset: 0x004A89A9
	private void OnItemRefresh(VisionMediumItemGrid item)
	{
		if (item.CheckSelectedState(this.CurrentSelectPhantomData))
		{
			this.LoopScrollView.DeselectCurrentGridProxy(false);
			this.LoopScrollView.SelectGridProxy(item.GridIndex, false);
		}
	}

	// Token: 0x06012E23 RID: 77347 RVA: 0x004AA7D7 File Offset: 0x004A89D7
	private void SetCurrentSelectPhantomData(PhantomBattleData data)
	{
		this.CurrentSelectPhantomData = data;
		this.RefreshSwitchButtonText();
		this.RefreshCostText();
		this.RefreshConfirmButtonRedDot();
	}

	// Token: 0x06012E24 RID: 77348 RVA: 0x004AA7F2 File Offset: 0x004A89F2
	private void ClearPhantomClickTick()
	{
		if (this.PhantomClickTick != -1)
		{
			TickSystem.Instance.Remove(this.PhantomClickTick);
			this.PhantomClickTick = -1;
		}
	}

	// Token: 0x06012E25 RID: 77349 RVA: 0x004AA818 File Offset: 0x004A8A18
	private void OnPhantomPointerDown(VisionMediumItemGrid item, PhantomBattleData data)
	{
		this.ClearPhantomClickTick();
		this.PressTime = 0f;
		this.FillPressTime = 0f;
		this.CheckState = true;
		this.CurrentPressItem = item;
		FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
		this.OnPressPositionX = worldPointInPlane.X;
		this.OnPressPositionY = worldPointInPlane.Z;
		this.AfterLongPressState = false;
		this.VisionEquipmentDragItem.UpdateItem(data);
		this.ScrollVisionDragItem.Refresh(data, false);
		this.SetPressItemShowState(true);
		this.SetPressItemAlpha(0f);
		this.CurrentDragIndex = -1;
		base.GetSprite(19).SetFillAmount(0f);
		this.PhantomClickTick = TickSystem.Instance.Add(new Action<float>(this.OnPhantomPointerTick), "RoleVisionAnimation", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
	}

	// Token: 0x06012E26 RID: 77350 RVA: 0x004AA8F0 File Offset: 0x004A8AF0
	private void RefreshLongPressItemPosition()
	{
		FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
		Vector2D vector2D = Vector2D.Create((double)pointerEventDataPosition.Value.X, (double)pointerEventDataPosition.Value.Y);
		Vector2D vector2D2 = vector2D;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = vector2D.ToUeVector2D(false);
		vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
		float num = PhantomBattleConfig.Instance.GetVisionScrollerOffsetX() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetXDir();
		float num2 = PhantomBattleConfig.Instance.GetVisionScrollerOffsetY() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetYDir();
		double num3 = vector2D.X + (double)num;
		double num4 = vector2D.Y + (double)num2;
		UUIItem item = base.GetItem(18);
		FVector fvector = new FVector((float)num3, (float)num4, 0f);
		item.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06012E27 RID: 77351 RVA: 0x004AA9B8 File Offset: 0x004A8BB8
	[NullableContext(2)]
	private void OnPhantomPointerUp(VisionMediumItemGrid item, PhantomBattleData data)
	{
		this.ClearPhantomClickTick();
		base.GetLoopScrollViewComponent(6).SetEnable(true);
		VisionCommonDragItem scrollVisionDragItem = this.ScrollVisionDragItem;
		if (scrollVisionDragItem != null)
		{
			scrollVisionDragItem.ClearStayingItem();
		}
		this.VisionEquipmentDragItem.SetActive(false);
		this.SetPressItemShowState(false);
		this.CurrentDragIndex = 999;
		if (item == null && data == null)
		{
			this.ResetVisionPosition(true);
		}
	}

	// Token: 0x06012E28 RID: 77352 RVA: 0x004AAA15 File Offset: 0x004A8C15
	private void ClearScrollerMoveTick()
	{
		if (this.ScrollerTickId != -1)
		{
			TickSystem.Instance.Remove(this.ScrollerTickId);
			this.ScrollerTickId = -1;
		}
	}

	// Token: 0x06012E29 RID: 77353 RVA: 0x004AAA38 File Offset: 0x004A8C38
	private void OnPhantomPointerTick(float _)
	{
		this.PressTime += Time.Instance.DeltaTime;
		if (this.AfterLongPressState)
		{
			this.ScrollVisionDragItem.TickCheckDrag();
		}
		if (!this.CheckState)
		{
			return;
		}
		if (this.PressTime > this.BeforeLongPressTime && this.LongPressItemAlpha == 0f)
		{
			this.RefreshLongPressItemPosition();
			this.SetPressItemAlpha(1f);
			this.FillPressTime = 0f;
		}
		if (this.LongPressItemAlpha > 0f)
		{
			this.FillPressTime += Time.Instance.DeltaTime;
		}
		if (this.CurrentPressItem != null)
		{
			FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
			float value = this.OnPressPositionX - worldPointInPlane.X;
			float value2 = this.OnPressPositionY - worldPointInPlane.Z;
			if (Math.Abs(value) + Math.Abs(value2) > this.ScrollerMoveDistance)
			{
				this.SetPressItemShowState(false);
				this.CheckState = false;
			}
		}
		if (this.FillPressTime > this.LongPressTime)
		{
			base.GetLoopScrollViewComponent(6).SetEnable(false);
			this.SetPressItemShowState(false);
			this.CheckState = false;
			this.AfterLongPressState = true;
			this.VisionEquipmentDragItem.SetActive(true);
			this.ScrollVisionDragItem.StartDragState();
			this.ScrollVisionDragItem.SetItemToPointerPosition();
			this.OnPointerDownCallBack(this.ScrollVisionDragItem.GetCurrentIndex());
			this.ScrollVisionDragItem.SetDragItemHierarchyMax();
			AudioSystem.Instance.PostEvent("ui_vision_item_drag");
			this.PhantomScrollerItemPositionTick = TickSystem.Instance.Add(new Action<float>(this.CheckPhantomsScrollerItemMove), "RoleVisionAnimation", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			return;
		}
		base.GetSprite(19).SetFillAmount(this.FillPressTime / this.LongPressTime);
	}

	// Token: 0x06012E2A RID: 77354 RVA: 0x004AABF4 File Offset: 0x004A8DF4
	private void CheckPhantomsScrollerItemMove(float _)
	{
		bool flag = LguiEventSystemManager.Instance.IsPressComponentIsValid(0);
		bool flag2 = LguiEventSystemManager.Instance.IsNowTriggerPressed(0);
		List<VisionCommonDragItem> stayingItem = this.ScrollVisionDragItem.GetStayingItem();
		if (!flag && !flag2)
		{
			if (stayingItem != null && stayingItem.Count == 0)
			{
				this.OnPhantomPointerUp(null, null);
				AudioSystem.Instance.PostEvent("ui_vision_item_drop");
			}
			else
			{
				this.OnDragEndCallBack(this.ScrollVisionDragItem, this.ScrollVisionDragItem.GetStayingItem(), false);
				this.OnPhantomPointerUp(null, null);
			}
			this.ClearScrollerItemMoveTick();
		}
	}

	// Token: 0x06012E2B RID: 77355 RVA: 0x004AAC74 File Offset: 0x004A8E74
	private void ClearScrollerItemMoveTick()
	{
		if (this.PhantomScrollerItemPositionTick != -1)
		{
			TickSystem.Instance.Remove(this.PhantomScrollerItemPositionTick);
			this.PhantomScrollerItemPositionTick = -1;
		}
	}

	// Token: 0x06012E2C RID: 77356 RVA: 0x004AAC98 File Offset: 0x004A8E98
	private void OnPhantomItemClick(PhantomBattleData data, int index)
	{
		this.SetCurrentSelectPhantomData(data);
		this.LoopScrollView.DeselectCurrentGridProxy(false);
		this.LoopScrollView.SelectGridProxy(index, false);
		this.RefreshCurrentDetailComponent(data, false);
		PhantomBattleModel.Instance.CurrentSelectData = this.GetCurrentSelectIndexPhantomData(index);
		PhantomBattleModel.Instance.CurrentSelectUniqueId = data.GetUniqueId();
		this.RefreshMesh(this.CurrentSelectPhantomData.GetUniqueId(), false);
		this.RefreshSkinButton();
	}

	// Token: 0x06012E2D RID: 77357 RVA: 0x004AAD08 File Offset: 0x004A8F08
	protected void TryEquip(PhantomBattleData phantomData, int targetIndex, Action doFunction)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		switch ((phantomData != null) ? PhantomBattleController.Instance.GetEquipState(roleInstanceById.GetRoleId(), targetIndex, phantomData.GetUniqueId()) : EEquipType.Equip)
		{
		case EEquipType.UnEquip:
			if (targetIndex == -1)
			{
				return;
			}
			this.UnEquip(targetIndex);
			return;
		case EEquipType.Equip:
			this.CheckIfCanEquip(phantomData, targetIndex, doFunction);
			return;
		case EEquipType.Replace:
			this.CheckIfCanEquip(phantomData, targetIndex, doFunction);
			return;
		default:
			return;
		}
	}

	// Token: 0x06012E2E RID: 77358 RVA: 0x004AAD78 File Offset: 0x004A8F78
	private void UnEquip(int index)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		PhantomBattleController.Instance.SendPhantomPutOnRequest(0, roleInstanceById.GetRoleId(), index, index, false);
	}

	// Token: 0x06012E2F RID: 77359 RVA: 0x004AADAC File Offset: 0x004A8FAC
	private void CheckIfCanEquip(PhantomBattleData phantomData, int index, Action call)
	{
		int? equipRole = PhantomBattleController.Instance.GetEquipRole(phantomData.GetUniqueId());
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (equipRole != null && equipRole.Value != roleInstanceById.GetRoleId())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomEquipRoleTip);
			RoleInstance roleInstanceById2 = RoleModel.Instance.GetRoleInstanceById(equipRole.Value);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				roleInstanceById2.GetName(null)
			});
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			});
			confirmBoxDataNew.FunctionMap.Add(2, call);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		call();
	}

	// Token: 0x06012E30 RID: 77360 RVA: 0x004AAE7A File Offset: 0x004A907A
	protected void OnClickFailVision(int index)
	{
		this.ResetVisionPosition(true);
	}

	// Token: 0x06012E31 RID: 77361 RVA: 0x004AAE84 File Offset: 0x004A9084
	protected void OnClickVisionAndRefreshVisionView(int index)
	{
		base.GetItem(15).SetRaycastTarget(false);
		this.SetCurrentSelectIndex(index);
		this.RefreshVisionBySelectIndex(false, false, true);
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (PhantomBattleController.Instance.GetEquipByIndex(roleInstanceById.GetRoleId(), index) == 0)
		{
			this.LoopScrollView.ResetGridController();
		}
		this.RefreshCostText();
		if (this.CurrentSelectPhantomData != null)
		{
			this.SetCurrentSelectPhantomData(this.CurrentSelectPhantomData);
		}
		AudioSystem.Instance.PostEvent("ui_vision_item_click");
	}

	// Token: 0x06012E32 RID: 77362 RVA: 0x004AAF08 File Offset: 0x004A9108
	private void SetCurrentSelectIndex(int index)
	{
		if (this.CurrentSelectIndex == (EPhantomItemIndex)index)
		{
			return;
		}
		this.CurrentSelectIndex = (EPhantomItemIndex)index;
		PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = index;
	}

	// Token: 0x06012E33 RID: 77363 RVA: 0x004AAF26 File Offset: 0x004A9126
	private void RefreshVisionBySelectIndex(bool meshChangeGoldEffect = false, bool needResetScrollerWhenUniqueIdZero = true, bool needScrollToItem = true)
	{
		this.RefreshScrollByCurrentUniqueId(needResetScrollerWhenUniqueIdZero, needScrollToItem);
		this.RefreshVisionBySelectPhantomData(meshChangeGoldEffect);
	}

	// Token: 0x06012E34 RID: 77364 RVA: 0x004AAF38 File Offset: 0x004A9138
	private void RefreshScrollByCurrentUniqueId(bool needResetScrollerWhenUniqueIdZero = true, bool needScrollToItem = true)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(roleInstanceById.GetRoleId(), (int)this.CurrentSelectIndex);
		if (equipByIndex != 0)
		{
			this.ScrollToUniqueItem(equipByIndex, needScrollToItem);
			PhantomBattleData currentSelectIndexPhantomData = this.GetCurrentSelectIndexPhantomData((int)this.CurrentSelectIndex);
			this.SetCurrentSelectPhantomData(currentSelectIndexPhantomData);
			return;
		}
		if (needResetScrollerWhenUniqueIdZero)
		{
			this.SetCurrentSelectPhantomData(this.GetCurrentSelectIndexPhantomData((int)this.CurrentSelectIndex));
			this.LoopScrollView.ResetGridController();
			PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
			this.ScrollToUniqueItem((currentSelectPhantomData != null) ? currentSelectPhantomData.GetUniqueId() : 0, needScrollToItem);
		}
	}

	// Token: 0x06012E35 RID: 77365 RVA: 0x004AAFC8 File Offset: 0x004A91C8
	private void RefreshVisionBySelectPhantomData(bool meshChangeGoldEffect = false)
	{
		this.RefreshCurrentDetailComponent(this.CurrentSelectPhantomData, false);
		this.RefreshPhantomHeadSelectState();
		this.RefreshVisionDetailCompare();
		PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
		this.RefreshMesh((currentSelectPhantomData != null) ? currentSelectPhantomData.GetUniqueId() : 0, meshChangeGoldEffect);
		this.RefreshSkinButton();
		this.RefreshPhantomClickState();
		this.ResetVisionPosition(true);
	}

	// Token: 0x06012E36 RID: 77366 RVA: 0x004AB01C File Offset: 0x004A921C
	private void SetClickStateUnCheck()
	{
		int count = this.RoleVisionItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.RoleVisionItem[i].SetToggleState(EToggleState.ETT_UnChecked, false, true);
		}
	}

	// Token: 0x06012E37 RID: 77367 RVA: 0x004AB058 File Offset: 0x004A9258
	private void RefreshPhantomClickState()
	{
		int count = this.RoleVisionItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.RoleVisionItem[i].SetToggleState((this.CurrentSelectIndex == (EPhantomItemIndex)i) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false);
		}
	}

	// Token: 0x06012E38 RID: 77368 RVA: 0x004AB0A0 File Offset: 0x004A92A0
	[NullableContext(2)]
	private PhantomBattleData GetCurrentSelectIndexPhantomData(int index)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(roleInstanceById.GetRoleId(), index);
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(equipByIndex);
		if (phantomBattleData == null)
		{
			phantomBattleData = ((this.CurrentShowingDataList.Count > 0) ? this.CurrentShowingDataList[0] : null);
		}
		return phantomBattleData;
	}

	// Token: 0x06012E39 RID: 77369 RVA: 0x004AB0FE File Offset: 0x004A92FE
	private void RefreshCurrentDetailComponent(PhantomBattleData data, bool ifOnEquip = false)
	{
		if (data == null)
		{
			this.VisionDetailComponent.SetActive(false);
			return;
		}
		this.VisionDetailComponent.SetActive(true);
		this.VisionDetailComponent.Update(data, this.RoleId, this.CurrentCost, false);
	}

	// Token: 0x06012E3A RID: 77370 RVA: 0x004AB138 File Offset: 0x004A9338
	private void RefreshCurrentSelectAfterIntensify()
	{
		VisionIntensifyViewPassData visionIntensifyPassData = this.VisionIntensifyPassData;
		int num = (visionIntensifyPassData != null) ? visionIntensifyPassData.UniqueId : 0;
		this.VisionIntensifyPassData = null;
		if (num <= 0)
		{
			return;
		}
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num);
		if (phantomBattleData == null)
		{
			return;
		}
		this.CurrentSelectPhantomData = phantomBattleData;
	}

	// Token: 0x06012E3B RID: 77371 RVA: 0x004AB17C File Offset: 0x004A937C
	private void ScrollToUniqueItem(int uniqueId, bool needScrollToItem = true)
	{
		this.LoopScrollView.DeselectCurrentGridProxy(false);
		bool flag = false;
		int num = 0;
		using (List<PhantomBattleData>.Enumerator enumerator = this.CurrentShowingDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetUniqueId() == uniqueId)
				{
					flag = true;
					break;
				}
				num++;
			}
		}
		if (!flag)
		{
			num = 0;
		}
		if (this.CurrentShowingDataList.Count > 0 && flag)
		{
			if (needScrollToItem)
			{
				this.LoopScrollView.ScrollToGridIndex(num, false);
			}
			this.LoopScrollView.SelectGridProxy(num, false);
		}
	}

	// Token: 0x06012E3C RID: 77372 RVA: 0x004AB21C File Offset: 0x004A941C
	protected override void OnBeforeShow()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		if (instance != null)
		{
			instance.AddNeedCameraFocusMethodDisableViewCount();
		}
		UiSceneUtils.SetSceneFloorReflection(true, true);
		if (this.CurrentMeshId > 0 && !UiSceneManager.Instance.HasVisionSkeletalHandle())
		{
			int currentMeshId = this.CurrentMeshId;
			this.CurrentMeshId = 0;
			this.RefreshMesh(currentMeshId, false);
		}
		PhantomBattleModel.Instance.ClearCurrentDragIndex();
		this.RefreshCurrentSelectAfterIntensify();
		if (PhantomBattleModel.Instance.GetVisionLevelUpTag())
		{
			this.UpdateFilterComponent();
			PhantomBattleModel.Instance.ClearVisionLevelUp();
		}
		else if (PhantomBattleModel.Instance.CurrentSelectFetterGroupId > 0)
		{
			int num = this.FetterSuitFilterArray.IndexOf(PhantomBattleModel.Instance.CurrentSelectFetterGroupId);
			PhantomBattleModel.Instance.CurrentSelectFetterGroupId = 0;
			if (num > 0)
			{
				this.MultiSelectDropDown.SetSelectedIndices(new List<int>
				{
					num
				});
			}
			else
			{
				this.MultiSelectDropDown.SetSelectedIndices(new List<int>
				{
					0
				});
			}
			this.UpdateFilterComponent();
		}
		else
		{
			this.UpdateFilterComponent();
		}
		this.RefreshFilterList();
		this.SetClickStateUnCheck();
		this.RefreshPhantomClickState();
		this.RefreshSkinButton();
		this.RefreshPhantomHead();
	}

	// Token: 0x06012E3D RID: 77373 RVA: 0x004AB328 File Offset: 0x004A9528
	private void RefreshFilterList()
	{
		if (PhantomBattleModel.Instance.CurrentSelectedFetter != null)
		{
			PhantomBattleModel.Instance.CurrentSelectedFetter = null;
		}
	}

	// Token: 0x06012E3E RID: 77374 RVA: 0x004AB35C File Offset: 0x004A955C
	private void UpdateFilterComponent()
	{
		MultiSelectDropDown<int, int> multiSelectDropDown = this.MultiSelectDropDown;
		IReadOnlySet<int> readOnlySet = (multiSelectDropDown != null) ? multiSelectDropDown.GetSelectedIndices() : null;
		IPhantomItemData[] source;
		if (readOnlySet == null || readOnlySet.Contains(0) || readOnlySet.Count == 0)
		{
			source = PhantomBattleModel.Instance.GetVisionSortUseDataList(0, this.CurrentCost);
		}
		else
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int index in readOnlySet)
			{
				hashSet.Add(this.FetterSuitFilterArray[index]);
			}
			source = PhantomBattleModel.Instance.GetVisionSortUseDataListByMultiGroup(hashSet, this.CurrentCost);
		}
		MultiSelectDropDown<int, int> multiSelectDropDown2 = this.MultiSelectDropDown;
		if (multiSelectDropDown2 != null)
		{
			multiSelectDropDown2.RefreshAllDropDownItem();
		}
		this.FilterEntrance.UpdateDataWithConfig(this.UseWayId, EFilterSortConfigId.VisionEquipment, source.ToList<IPhantomItemData>(), this.RoleId.ToString(), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateDataWithConfig(this.UseWayId, EFilterSortConfigId.VisionEquipment, source.ToList<IPhantomItemData>(), this.RoleId.ToString(), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x06012E3F RID: 77375 RVA: 0x004AB4C8 File Offset: 0x004A96C8
	protected override void OnAfterShow()
	{
		foreach (VisionCommonDragItem visionCommonDragItem in this.VisionDragItem)
		{
			visionCommonDragItem.SetScrollViewItem(base.GetLoopScrollViewComponent(6).RootUIComp.Get());
		}
		if (!this.CameraState)
		{
			this.CameraState = true;
			PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
			this.RefreshMesh((currentSelectPhantomData != null) ? currentSelectPhantomData.GetUniqueId() : 0, false);
		}
	}

	// Token: 0x06012E40 RID: 77376 RVA: 0x004AB554 File Offset: 0x004A9754
	protected override void OnAfterHide()
	{
		this.ResetVisionPosition(true);
		UiLayer.Instance.SetShowMaskLayer("playBackToStartPositionAnimation", false);
		UiLayer.Instance.SetShowMaskLayer("OnEquipVision", false);
	}

	// Token: 0x06012E41 RID: 77377 RVA: 0x004AB580 File Offset: 0x004A9780
	private void RefreshMesh(int uniqueId, bool needGoldEffect = false)
	{
		if (!this.CameraState)
		{
			return;
		}
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(uniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		if (this.CurrentMeshId == phantomItemDataByUniqueId.GetUniqueId())
		{
			return;
		}
		this.CheckAndCreateVisionHandle();
		PhantomBattleController.Instance.SetMeshShow(phantomItemDataByUniqueId.GetConfigId(true), delegate
		{
			this.PlayMeshEffect(needGoldEffect);
		}, this.VisionSkeletalHandle, true);
		this.CurrentMeshId = uniqueId;
	}

	// Token: 0x06012E42 RID: 77378 RVA: 0x004AB5FC File Offset: 0x004A97FC
	private void PlayMeshEffect(bool needGoldEffect = false)
	{
		if (this.VisionSkeletalHandle == null)
		{
			return;
		}
		UiModelBase model = this.VisionSkeletalHandle.Model;
		string effectId;
		string materialId;
		if (needGoldEffect)
		{
			effectId = "VisionChangeEffect";
			materialId = "VisionChangeController";
		}
		else
		{
			effectId = "VisionLevelUpEffect";
			materialId = "VisionStepupController";
		}
		UiModelUtil.Instance.PlayEffectOnRoot(model, effectId);
		UiModelUtil.Instance.SetRenderingMaterial(model, materialId);
	}

	// Token: 0x06012E43 RID: 77379 RVA: 0x004AB658 File Offset: 0x004A9858
	[NullableContext(2)]
	private void RefreshView(PhantomBattleData data)
	{
		this.RefreshPhantomHead();
		this.RefreshCostText();
		this.RefreshSkinButton();
		this.ScrollToUniqueItem((data != null) ? data.GetUniqueId() : 0, true);
	}

	// Token: 0x06012E44 RID: 77380 RVA: 0x004AB680 File Offset: 0x004A9880
	private void RefreshSwitchButtonText()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		EEquipType eequipType = (this.CurrentSelectPhantomData != null) ? PhantomBattleController.Instance.GetEquipState(roleInstanceById.GetRoleId(), (int)this.CurrentSelectIndex, this.CurrentSelectPhantomData.GetUniqueId()) : EEquipType.Equip;
		string underLeftButtonText = "";
		switch (eequipType)
		{
		case EEquipType.UnEquip:
			underLeftButtonText = "PhantomTakeOff";
			break;
		case EEquipType.Equip:
			underLeftButtonText = "PhantomPutOn";
			break;
		case EEquipType.Replace:
			underLeftButtonText = "PhantomReplace";
			break;
		}
		this.VisionDetailComponent.SetUnderLeftButtonText(underLeftButtonText);
	}

	// Token: 0x06012E45 RID: 77381 RVA: 0x004AB708 File Offset: 0x004A9908
	private void RefreshPhantomNotReload()
	{
		this.LoopScrollView.DeselectCurrentGridProxy(false);
		if (this.CurrentShowingDataList.Count > 0)
		{
			base.GetLoopScrollViewComponent(6).RootUIComp.Get().SetUIActive(true);
			this.LoopScrollView.RefreshAllGridProxies();
			return;
		}
		base.GetLoopScrollViewComponent(6).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06012E46 RID: 77382 RVA: 0x004AB76F File Offset: 0x004A996F
	private void OnItemFuncValueChange(int _)
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06012E47 RID: 77383 RVA: 0x004AB77C File Offset: 0x004A997C
	private void RefreshPhantom(int uniqueId = 0)
	{
		this.LoopScrollView.DeselectCurrentGridProxy(false);
		if (this.CurrentShowingDataList.Count > 0)
		{
			base.GetLoopScrollViewComponent(6).RootUIComp.Get().SetUIActive(true);
			this.LoopScrollView.ReloadData(this.CurrentShowingDataList, this.SuppressScrollOnRebuild);
		}
		else
		{
			base.GetLoopScrollViewComponent(6).RootUIComp.Get().SetUIActive(false);
		}
		this.RefreshEmptyItem();
	}

	// Token: 0x06012E48 RID: 77384 RVA: 0x004AB7F8 File Offset: 0x004A99F8
	private void RefreshPhantomHead()
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		List<PhantomDataBase> currentViewShowPhantomList = PhantomBattleModel.Instance.GetCurrentViewShowPhantomList(roleInstanceById);
		int count = this.RoleVisionItem.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomDataBase data = (currentViewShowPhantomList.Count > i) ? currentViewShowPhantomList[i] : null;
			this.RoleVisionItem[i].UpdateItem(data, null);
			this.VisionDragItem[i].Refresh(data, false);
		}
		this.RefreshPhantomHeadSelectState();
	}

	// Token: 0x06012E49 RID: 77385 RVA: 0x004AB880 File Offset: 0x004A9A80
	private void RefreshPhantomHeadSelectState()
	{
		int count = this.RoleVisionItem.Count;
		for (int i = 0; i < count; i++)
		{
			if (i == (int)this.CurrentSelectIndex)
			{
				this.RoleVisionItem[i].SetSelected();
			}
			else
			{
				this.RoleVisionItem[i].SetUnSelected();
			}
		}
	}

	// Token: 0x06012E4A RID: 77386 RVA: 0x004AB8D4 File Offset: 0x004A9AD4
	protected void OnBeginDrag(int index)
	{
		int count = this.VisionDragItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.VisionDragItem[i].StartDragState();
		}
		for (int j = 0; j < count; j++)
		{
			if (PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.VisionDragItem[j].GetCurrentIndex()))
			{
				this.VisionDragItem[j].SetDragItemHierarchyMax();
			}
		}
		this.VisionDragItem[index].SetItemToPointerPosition();
		this.CurrentDragIndex = index;
		AudioSystem.Instance.PostEvent("ui_vision_item_drag");
	}

	// Token: 0x06012E4B RID: 77387 RVA: 0x004AB96C File Offset: 0x004A9B6C
	protected void OnPointerDownCallBack(int index)
	{
		base.GetItem(15).SetRaycastTarget(true);
		int count = this.VisionDragItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.VisionDragItem[i].StartClickCheckTimer();
		}
	}

	// Token: 0x06012E4C RID: 77388 RVA: 0x004AB9B0 File Offset: 0x004A9BB0
	private void OnFailAnimationTick(float _)
	{
		this.CurrentRunningTime += Time.Instance.DeltaTime;
		float num = this.CurrentRunningTime / 300f;
		if (num >= 1f)
		{
			num = 1f;
		}
		this.VisionDragItem[this.CurrentDragIndex].TickDoCeaseAnimation(num);
		if (num >= 1f)
		{
			this.DoFailCeaseAnimation(this.CurrentDragIndex);
			this.ClearFailAnimationTick();
		}
	}

	// Token: 0x06012E4D RID: 77389 RVA: 0x004ABA24 File Offset: 0x004A9C24
	private UniTask DoFailCeaseAnimation(int index)
	{
		VisionEquipmentView.<DoFailCeaseAnimation>d__154 <DoFailCeaseAnimation>d__;
		<DoFailCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoFailCeaseAnimation>d__.<>4__this = this;
		<DoFailCeaseAnimation>d__.index = index;
		<DoFailCeaseAnimation>d__.<>1__state = -1;
		<DoFailCeaseAnimation>d__.<>t__builder.Start<VisionEquipmentView.<DoFailCeaseAnimation>d__154>(ref <DoFailCeaseAnimation>d__);
		return <DoFailCeaseAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x06012E4E RID: 77390 RVA: 0x004ABA70 File Offset: 0x004A9C70
	private UniTask PlayCeaseAnimation(int index)
	{
		VisionEquipmentView.<PlayCeaseAnimation>d__155 <PlayCeaseAnimation>d__;
		<PlayCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCeaseAnimation>d__.<>4__this = this;
		<PlayCeaseAnimation>d__.index = index;
		<PlayCeaseAnimation>d__.<>1__state = -1;
		<PlayCeaseAnimation>d__.<>t__builder.Start<VisionEquipmentView.<PlayCeaseAnimation>d__155>(ref <PlayCeaseAnimation>d__);
		return <PlayCeaseAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x06012E4F RID: 77391 RVA: 0x004ABABB File Offset: 0x004A9CBB
	private void ClearFailAnimationTick()
	{
		if (this.FailAnimationTick != -1)
		{
			TickSystem.Instance.Remove(this.FailAnimationTick);
			this.FailAnimationTick = -1;
		}
	}

	// Token: 0x06012E50 RID: 77392 RVA: 0x004ABAE0 File Offset: 0x004A9CE0
	private UniTask ResetVisionPosition(bool playBackToStartPositionAnimation = true)
	{
		VisionEquipmentView.<ResetVisionPosition>d__157 <ResetVisionPosition>d__;
		<ResetVisionPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ResetVisionPosition>d__.<>4__this = this;
		<ResetVisionPosition>d__.playBackToStartPositionAnimation = playBackToStartPositionAnimation;
		<ResetVisionPosition>d__.<>1__state = -1;
		<ResetVisionPosition>d__.<>t__builder.Start<VisionEquipmentView.<ResetVisionPosition>d__157>(ref <ResetVisionPosition>d__);
		return <ResetVisionPosition>d__.<>t__builder.Task;
	}

	// Token: 0x06012E51 RID: 77393 RVA: 0x004ABB2B File Offset: 0x004A9D2B
	private void SetIndexVisionMoveState(int index, bool state)
	{
		if (index >= 0)
		{
			this.VisionDragItem[index].SetMovingState(state);
		}
	}

	// Token: 0x06012E52 RID: 77394 RVA: 0x004ABB43 File Offset: 0x004A9D43
	private void SetIndexVisionAnimateState(int index, bool state)
	{
		if (index >= 0)
		{
			this.RoleVisionItem[index].SetAnimationState(state);
		}
	}

	// Token: 0x06012E53 RID: 77395 RVA: 0x004ABB5B File Offset: 0x004A9D5B
	protected void OnEquipError()
	{
		this.ResetVisionPosition(true);
	}

	// Token: 0x06012E54 RID: 77396 RVA: 0x004ABB68 File Offset: 0x004A9D68
	private void RefreshEmptyItem()
	{
		int count = this.CurrentShowingDataList.Count;
		base.GetItem(35).SetUIActive(count == 0);
	}

	// Token: 0x06012E55 RID: 77397 RVA: 0x004ABB92 File Offset: 0x004A9D92
	protected void OnPhantomEquip()
	{
		this.RefreshVisionDetailCompare();
	}

	// Token: 0x06012E56 RID: 77398 RVA: 0x004ABB9A File Offset: 0x004A9D9A
	private void OnAddPhantomItemList(IReadOnlyList<Aki.Protocol.PhantomItem> phantomItemList, bool isCatch)
	{
		this.SuppressScrollOnRebuild = true;
		this.UpdateFilterComponent();
		this.SuppressScrollOnRebuild = false;
	}

	// Token: 0x06012E57 RID: 77399 RVA: 0x004ABBB0 File Offset: 0x004A9DB0
	private void OnRemovePhantomItem(IReadOnlyList<int> uniqueIdList)
	{
		this.SuppressScrollOnRebuild = true;
		this.UpdateFilterComponent();
		this.SuppressScrollOnRebuild = false;
	}

	// Token: 0x06012E58 RID: 77400 RVA: 0x004ABBC8 File Offset: 0x004A9DC8
	private void OnPhantomStackMerge(int mergedIncrId, int representativeIncrId)
	{
		if (this.CurrentSelectPhantomData == null || this.CurrentSelectPhantomData.GetUniqueId() != mergedIncrId)
		{
			return;
		}
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(representativeIncrId);
		if (phantomBattleData == null)
		{
			return;
		}
		this.SetCurrentSelectPhantomData(phantomBattleData);
	}

	// Token: 0x06012E59 RID: 77401 RVA: 0x004ABC03 File Offset: 0x004A9E03
	protected void OnVisionFilterMonster()
	{
		this.RefreshFilterList();
	}

	// Token: 0x06012E5A RID: 77402 RVA: 0x004ABC0C File Offset: 0x004A9E0C
	private void OnMoveToScrollViewDragEndCallBack(int index, PhantomBattleData data)
	{
		this.ClearFailAnimationTick();
		this.CurrentRunningTime = 0f;
		this.CurrentDragIndex = 999;
		this.VisionDragItem[index].SetActive(false);
		this.VisionDragItem[index].ResetPosition();
		this.RoleVisionItem[index].ResetPosition();
		base.GetItem(15).SetRaycastTarget(false);
		RoleInstance roleInstance = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		Action doFunction = delegate()
		{
			PhantomBattleController.Instance.SendPhantomPutOnRequest(data.GetUniqueId(), roleInstance.GetRoleId(), index, -1, false);
		};
		this.DoEquip(data, index, doFunction);
	}

	// Token: 0x06012E5B RID: 77403 RVA: 0x004ABCD0 File Offset: 0x004A9ED0
	protected void OnDragEndCallBack(VisionCommonDragItem self, List<VisionCommonDragItem> targets, bool _)
	{
		if (targets.Count < 1)
		{
			this.ResetVisionPosition(true);
			AudioSystem.Instance.PostEvent("ui_vision_item_drop");
			return;
		}
		int targetIndex = VisionCommonDragItem.GetOverlapIndex(self, targets);
		if (targetIndex == -1)
		{
			this.ResetVisionPosition(true);
			return;
		}
		if (self.GetCurrentIndex() == -1)
		{
			this.ResetVisionPosition(true);
		}
		int selfIndex = self.GetCurrentIndex();
		RoleInstance currentRoleInstance = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		bool fromDrag = selfIndex != -1;
		Action doFunction = delegate()
		{
			this.SetIndexVisionMoveState(selfIndex, true);
			this.SetIndexVisionMoveState(targetIndex, true);
			this.SetIndexVisionAnimateState(selfIndex, true);
			this.SetIndexVisionAnimateState(targetIndex, true);
			PhantomBattleController.Instance.SendPhantomPutOnRequest((self.GetCurrentData() as PhantomBattleData).GetUniqueId(), currentRoleInstance.GetRoleId(), targetIndex, selfIndex, fromDrag);
		};
		this.DoEquip(self.GetCurrentData() as PhantomBattleData, targetIndex, doFunction);
	}

	// Token: 0x06012E5C RID: 77404 RVA: 0x004ABDB0 File Offset: 0x004A9FB0
	private void OnEquipEquipment(int selfIndex, int targetIndex, bool fromDrag)
	{
		this.CurrentDragIndex = 999;
		if (selfIndex >= 0)
		{
			this.VisionDragItem[selfIndex].SetActive(true);
			this.RoleVisionItem[selfIndex].SetAniLightState(false);
		}
		if (fromDrag && selfIndex != -1)
		{
			UiLayer.Instance.SetShowMaskLayer("OnEquipVision", true);
			this.ClearAnimationTick();
			this.CurrentRunningTime = 0f;
			Vector2D animationTargetPos = this.VisionDragItem[targetIndex].GetAnimationTargetPos();
			this.VisionDragItem[selfIndex].SetDragComponentToTargetPositionParam(animationTargetPos);
			Vector2D animationTargetPos2 = this.VisionDragItem[selfIndex].GetAnimationTargetPos();
			this.VisionDragItem[targetIndex].SetDragComponentToTargetPositionParam(animationTargetPos2);
			this.CurrentAnimationSourceIndex = selfIndex;
			this.CurrentAnimationTargetIndex = targetIndex;
			this.SetIndexVisionMoveState(this.CurrentAnimationSourceIndex, true);
			this.SetIndexVisionMoveState(this.CurrentAnimationTargetIndex, true);
			this.SetIndexVisionAnimateState(this.CurrentAnimationSourceIndex, true);
			this.SetIndexVisionAnimateState(this.CurrentAnimationTargetIndex, true);
			this.MoveAnimationTick = TickSystem.Instance.Add(new Action<float>(this.OnTick), "RoleVisionAnimation", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			return;
		}
		this.SetIndexVisionMoveState(selfIndex, false);
		this.SetIndexVisionMoveState(targetIndex, false);
		this.SetIndexVisionAnimateState(selfIndex, false);
		this.SetIndexVisionAnimateState(targetIndex, false);
		this.RefreshOnEquip();
		this.SetCurrentSelectIndex(targetIndex);
		this.RefreshVisionBySelectIndex(true, false, false);
		if (this.RoleVisionItem[targetIndex].GetCurrentData() != null)
		{
			this.PlayTargetIndexEquipmentCeaseAnimation(targetIndex);
		}
		if (selfIndex >= 0)
		{
			AudioSystem.Instance.PostEvent("ui_vision_equip_off");
			return;
		}
		AudioSystem.Instance.PostEvent("ui_vision_equip_on");
	}

	// Token: 0x06012E5D RID: 77405 RVA: 0x004ABF44 File Offset: 0x004AA144
	private UniTask PlayTargetIndexEquipmentCeaseAnimation(int targetIndex)
	{
		VisionEquipmentView.<PlayTargetIndexEquipmentCeaseAnimation>d__170 <PlayTargetIndexEquipmentCeaseAnimation>d__;
		<PlayTargetIndexEquipmentCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayTargetIndexEquipmentCeaseAnimation>d__.<>4__this = this;
		<PlayTargetIndexEquipmentCeaseAnimation>d__.targetIndex = targetIndex;
		<PlayTargetIndexEquipmentCeaseAnimation>d__.<>1__state = -1;
		<PlayTargetIndexEquipmentCeaseAnimation>d__.<>t__builder.Start<VisionEquipmentView.<PlayTargetIndexEquipmentCeaseAnimation>d__170>(ref <PlayTargetIndexEquipmentCeaseAnimation>d__);
		return <PlayTargetIndexEquipmentCeaseAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x06012E5E RID: 77406 RVA: 0x004ABF90 File Offset: 0x004AA190
	private void OnTick(float _)
	{
		this.CurrentRunningTime += Time.Instance.DeltaTime;
		float num = this.CurrentRunningTime / 300f;
		if (num >= 1f)
		{
			num = 1f;
		}
		this.VisionDragItem[this.CurrentAnimationSourceIndex].TickDoCeaseAnimation(num);
		this.VisionDragItem[this.CurrentAnimationTargetIndex].TickDoCeaseAnimation(num);
		if (num >= 1f)
		{
			this.DoCeaseAnimationAndResetView();
			this.ClearAnimationTick();
			AudioSystem.Instance.PostEvent("ui_vision_equip_on");
		}
	}

	// Token: 0x06012E5F RID: 77407 RVA: 0x004AC028 File Offset: 0x004AA228
	private UniTask DoCeaseAnimationAndResetView()
	{
		VisionEquipmentView.<DoCeaseAnimationAndResetView>d__172 <DoCeaseAnimationAndResetView>d__;
		<DoCeaseAnimationAndResetView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoCeaseAnimationAndResetView>d__.<>4__this = this;
		<DoCeaseAnimationAndResetView>d__.<>1__state = -1;
		<DoCeaseAnimationAndResetView>d__.<>t__builder.Start<VisionEquipmentView.<DoCeaseAnimationAndResetView>d__172>(ref <DoCeaseAnimationAndResetView>d__);
		return <DoCeaseAnimationAndResetView>d__.<>t__builder.Task;
	}

	// Token: 0x06012E60 RID: 77408 RVA: 0x004AC06B File Offset: 0x004AA26B
	private void RefreshOnEquip()
	{
		this.RefreshPhantomNotReload();
		this.RefreshPhantomHead();
		this.RefreshVisionDetailCompare();
		this.RefreshCostText();
		this.RefreshSwitchButtonText();
		this.ResetVisionPosition(true);
		this.RefreshSelectAllToggleState();
	}

	// Token: 0x06012E61 RID: 77409 RVA: 0x004AC099 File Offset: 0x004AA299
	private void ClearAnimationTick()
	{
		if (this.MoveAnimationTick != -1)
		{
			TickSystem.Instance.Remove(this.MoveAnimationTick);
			this.MoveAnimationTick = -1;
		}
	}

	// Token: 0x06012E62 RID: 77410 RVA: 0x004AC0BC File Offset: 0x004AA2BC
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012E63 RID: 77411 RVA: 0x004AC0C5 File Offset: 0x004AA2C5
	private int GetCostMax()
	{
		return PhantomBattleModel.Instance.GetMaxCost();
	}

	// Token: 0x06012E64 RID: 77412 RVA: 0x004AC0D1 File Offset: 0x004AA2D1
	private void CheckAndCreateVisionHandle()
	{
		if (!UiSceneManager.Instance.HasVisionSkeletalHandle())
		{
			UiSceneManager.Instance.InitVisionSkeletalHandle();
		}
		this.VisionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
	}

	// Token: 0x06012E65 RID: 77413 RVA: 0x004AC0F9 File Offset: 0x004AA2F9
	private void DestroyVisionHandle()
	{
		UiSceneManager.Instance.DestroyVisionSkeletalHandle();
		this.VisionSkeletalHandle = null;
		this.CurrentMeshId = 0;
	}

	// Token: 0x06012E66 RID: 77414 RVA: 0x004AC113 File Offset: 0x004AA313
	protected override void OnBeforeHide()
	{
		PhantomBattleModel instance = PhantomBattleModel.Instance;
		if (instance != null)
		{
			instance.ReduceNeedCameraFocusMethodDisableViewCount();
		}
		this.VisionEquipmentRecommendItem.Hide(null);
		UUIExtendToggle extendToggle = base.GetExtendToggle(34);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.RefreshUiBlur(false);
	}

	// Token: 0x06012E67 RID: 77415 RVA: 0x004AC150 File Offset: 0x004AA350
	protected override void OnBeforePlayCloseSequence()
	{
		this.DestroyVisionHandle();
		UUIExtendToggle extendToggle = base.GetExtendToggle(34);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012E68 RID: 77416 RVA: 0x004AC170 File Offset: 0x004AA370
	protected override void OnBeforeDestroy()
	{
		this.DestroyVisionHandle();
		this.VisionSkeletalHandle = null;
		this.ClearScrollerMoveTick();
		this.TryUnbindConfirmButtonRedDot();
		this.LoopScrollView.ClearGridProxies();
		this.ClearPhantomClickTick();
		this.ClearAnimationTick();
		this.ClearFailAnimationTick();
		this.StaticTabComponent.Destroy(null);
		MultiSelectDropDown<int, int> multiSelectDropDown = this.MultiSelectDropDown;
		if (multiSelectDropDown != null)
		{
			multiSelectDropDown.Destroy(null);
		}
		this.RefreshUiBlur(false);
	}

	// Token: 0x06012E69 RID: 77417 RVA: 0x004AC1D8 File Offset: 0x004AA3D8
	private bool NeedClearSelectMainPhantom()
	{
		Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> selectRuleDataMap = this.FilterEntrance.GetSelectRuleDataMap();
		VisionRecommendModel instance = VisionRecommendModel.Instance;
		int? num;
		if (instance == null)
		{
			num = null;
		}
		else
		{
			VisionMainSelectPhantomData currentMainPhantom = instance.CurrentMainPhantom;
			num = ((currentMainPhantom != null) ? new int?(currentMainPhantom.MonsterId) : null);
		}
		int? num2 = num;
		bool result = false;
		if (num2 != null)
		{
			if (selectRuleDataMap == null || selectRuleDataMap.Count != 1)
			{
				result = true;
			}
			else
			{
				Dictionary<int, string> dictionary = selectRuleDataMap.Values.ToArray<Dictionary<int, string>>()[0];
				if (dictionary == null || dictionary.Count > 1 || !dictionary.ContainsKey(num2.Value))
				{
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06012E6A RID: 77418 RVA: 0x004AC270 File Offset: 0x004AA470
	private void OnFilterRefresh(List<IPhantomItemData> list, bool ifOutSideChange, EFilterSortType type)
	{
		if (type == EFilterSortType.Filter && !ifOutSideChange && this.NeedClearSelectMainPhantom())
		{
			this.VisionEquipmentRecommendItem.ClearSelectMainPhantom(false);
			return;
		}
		List<PhantomBattleData> list2 = new List<PhantomBattleData>();
		foreach (IPhantomItemData phantomItemData in list)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData.Id);
			if (phantomBattleData != null)
			{
				list2.Add(phantomBattleData);
			}
		}
		this.CurrentShowingDataList = list2;
		this.RefreshPhantom(0);
		bool uiactive = list != null && list.Count > 0;
		base.GetLoopScrollViewComponent(6).RootUIComp.Get().SetUIActive(uiactive);
		if (this.SuppressScrollOnRebuild)
		{
			return;
		}
		this.RefreshDefaultVisionOnFilter(list.ToArray(), ifOutSideChange, type);
	}

	// Token: 0x06012E6B RID: 77419 RVA: 0x004AC34C File Offset: 0x004AA54C
	private void RefreshDefaultVisionOnFilter(IPhantomItemData[] dataList, bool ifOutSideChange, EFilterSortType type)
	{
		if (dataList == null || dataList.Length == 0)
		{
			return;
		}
		int num = 0;
		if (type == EFilterSortType.Sort && !ifOutSideChange)
		{
			num = dataList[0].Id;
		}
		else
		{
			int num2 = dataList.Length;
			for (int i = 0; i < num2; i++)
			{
				int id = dataList[i].Id;
				PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
				int? num3 = (currentSelectPhantomData != null) ? new int?(currentSelectPhantomData.GetUniqueId()) : null;
				if (id == num3.GetValueOrDefault() & num3 != null)
				{
					PhantomBattleData currentSelectPhantomData2 = this.CurrentSelectPhantomData;
					num = ((currentSelectPhantomData2 != null) ? currentSelectPhantomData2.GetUniqueId() : 0);
					break;
				}
			}
			if (num == 0)
			{
				num = dataList[0].Id;
			}
		}
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num);
		if (phantomBattleData == null && this.CurrentShowingDataList.Count > 0)
		{
			phantomBattleData = this.CurrentShowingDataList[0];
			num = phantomBattleData.GetUniqueId();
		}
		this.SetCurrentSelectPhantomData(phantomBattleData);
		this.ScrollToUniqueItem(num, true);
		this.RefreshCurrentDetailComponent(this.CurrentSelectPhantomData, false);
		this.RefreshVisionDetailCompare();
		this.RefreshMesh(num, false);
		this.RefreshSkinButton();
		this.RefreshPhantomClickState();
	}

	// Token: 0x06012E6C RID: 77420 RVA: 0x004AC450 File Offset: 0x004AA650
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		List<PhantomBattleData> currentShowingDataList = this.CurrentShowingDataList;
		if (currentShowingDataList.Count == 0)
		{
			return null;
		}
		if (configParams.Length != 2)
		{
			Log.Instance.Error(ELogModule.Guide, ELogAuthor.TL, "声骸聚焦引导extraParam配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (configParams[0] == "txt")
		{
			VisionDetailComponent visionDetailComponent = this.VisionDetailComponent;
			UUIItem uuiitem = (visionDetailComponent != null) ? visionDetailComponent.GetTxtItemByIndex(int.Parse(configParams[1])) : null;
			if (uuiitem != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
		}
		if (!(configParams[0] == "item"))
		{
			return null;
		}
		int num = int.Parse(configParams[1]);
		if (num == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "声骸聚焦引导extraParam字段配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		int gridIndex = -1;
		for (int i = 0; i < currentShowingDataList.Count; i++)
		{
			if (currentShowingDataList[i].GetMonsterId(true) == num)
			{
				gridIndex = i;
				break;
			}
		}
		this.LoopScrollView.ScrollToGridIndex(gridIndex, true);
		UUIItem grid = this.LoopScrollView.GetGrid(gridIndex);
		return new UUIItem[]
		{
			grid,
			grid
		};
	}

	// Token: 0x06012E6D RID: 77421 RVA: 0x004AC578 File Offset: 0x004AA778
	private void RefreshSkinButton()
	{
		PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
		int? num = (currentSelectPhantomData != null) ? new int?(currentSelectPhantomData.GetMonsterId(false)) : null;
		if (num == null)
		{
			base.GetButton(27).RootUIComp.Get().SetUIActive(false);
			return;
		}
		int[] monsterSkinListByMonsterId = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(num.Value);
		if (monsterSkinListByMonsterId == null)
		{
			base.GetButton(27).RootUIComp.Get().SetUIActive(false);
			return;
		}
		bool uiactive = monsterSkinListByMonsterId.Length > 1;
		base.GetButton(27).RootUIComp.Get().SetUIActive(uiactive);
		bool monsterSkinListHasNew = PhantomBattleModel.Instance.GetMonsterSkinListHasNew(this.CurrentSelectPhantomData.GetConfigId(false));
		base.GetItem(31).SetUIActive(monsterSkinListHasNew);
	}

	// Token: 0x04008E3A RID: 36410
	private const int ANIMATIONTIME = 300;

	// Token: 0x04008E3B RID: 36411
	private const int INVALIDINDEX = 999;

	// Token: 0x04008E3C RID: 36412
	private readonly EFilterSortGroupId UseWayId = EFilterSortGroupId.PhantomEquip;

	// Token: 0x04008E3D RID: 36413
	[Nullable(2)]
	private CustomPromise<bool> FailAnimationPromise;

	// Token: 0x04008E3E RID: 36414
	private int MoveAnimationTick = -1;

	// Token: 0x04008E3F RID: 36415
	private int PhantomClickTick = -1;

	// Token: 0x04008E40 RID: 36416
	private int FailAnimationTick = -1;

	// Token: 0x04008E41 RID: 36417
	private int PhantomScrollerItemPositionTick = -1;

	// Token: 0x04008E42 RID: 36418
	private int RoleId;

	// Token: 0x04008E43 RID: 36419
	private int CurrentAnimationSourceIndex;

	// Token: 0x04008E44 RID: 36420
	private int CurrentAnimationTargetIndex;

	// Token: 0x04008E45 RID: 36421
	private float CurrentRunningTime;

	// Token: 0x04008E46 RID: 36422
	private ERoleViewSource Source;

	// Token: 0x04008E47 RID: 36423
	private readonly List<RoleVisionCommonItem> RoleVisionItem = new List<RoleVisionCommonItem>();

	// Token: 0x04008E48 RID: 36424
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008E49 RID: 36425
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<VisionMediumItemGrid, PhantomBattleData> LoopScrollView;

	// Token: 0x04008E4A RID: 36426
	private List<PhantomBattleData> CurrentShowingDataList = new List<PhantomBattleData>();

	// Token: 0x04008E4B RID: 36427
	[Nullable(2)]
	private PhantomBattleData CurrentSelectPhantomData;

	// Token: 0x04008E4C RID: 36428
	[Nullable(2)]
	private VisionIntensifyViewPassData VisionIntensifyPassData;

	// Token: 0x04008E4D RID: 36429
	private EPhantomItemIndex CurrentSelectIndex;

	// Token: 0x04008E4E RID: 36430
	[Nullable(2)]
	private VisionDetailComponent VisionDetailComponent;

	// Token: 0x04008E4F RID: 36431
	[Nullable(2)]
	private VisionDetailComponent VisionDetailComponentCompare;

	// Token: 0x04008E50 RID: 36432
	private int CurrentMeshId;

	// Token: 0x04008E51 RID: 36433
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<IPhantomItemData> FilterEntrance;

	// Token: 0x04008E52 RID: 36434
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<IPhantomItemData> SortEntrance;

	// Token: 0x04008E53 RID: 36435
	[Nullable(2)]
	private LevelSequencePlayer RootLevelSequence;

	// Token: 0x04008E54 RID: 36436
	private int CurrentDragIndex = 999;

	// Token: 0x04008E55 RID: 36437
	private bool SuppressScrollOnRebuild;

	// Token: 0x04008E56 RID: 36438
	private float PressTime;

	// Token: 0x04008E57 RID: 36439
	private float FillPressTime;

	// Token: 0x04008E58 RID: 36440
	private bool CheckState;

	// Token: 0x04008E59 RID: 36441
	private bool AfterLongPressState;

	// Token: 0x04008E5A RID: 36442
	private float OnPressPositionX;

	// Token: 0x04008E5B RID: 36443
	private float OnPressPositionY;

	// Token: 0x04008E5C RID: 36444
	private int ScrollerTickId = -1;

	// Token: 0x04008E5D RID: 36445
	[Nullable(2)]
	private VisionMediumItemGrid CurrentPressItem;

	// Token: 0x04008E5E RID: 36446
	[Nullable(2)]
	protected VisionEquipmentDragItem VisionEquipmentDragItem;

	// Token: 0x04008E5F RID: 36447
	private readonly List<VisionCommonDragItem> VisionDragItem = new List<VisionCommonDragItem>();

	// Token: 0x04008E60 RID: 36448
	[Nullable(2)]
	private VisionCommonDragItem ScrollVisionDragItem;

	// Token: 0x04008E61 RID: 36449
	private float LongPressTime;

	// Token: 0x04008E62 RID: 36450
	private float BeforeLongPressTime;

	// Token: 0x04008E63 RID: 36451
	private float LongPressItemAlpha;

	// Token: 0x04008E64 RID: 36452
	private float ScrollerMoveDistance;

	// Token: 0x04008E65 RID: 36453
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StaticTabComponent<CostTabItem> StaticTabComponent;

	// Token: 0x04008E66 RID: 36454
	private int CurrentCost;

	// Token: 0x04008E67 RID: 36455
	private readonly List<int> CostArray = new List<int>();

	// Token: 0x04008E68 RID: 36456
	[Nullable(2)]
	private MultiSelectDropDown<int, int> MultiSelectDropDown;

	// Token: 0x04008E69 RID: 36457
	private readonly List<int> FetterSuitFilterArray = new List<int>();

	// Token: 0x04008E6A RID: 36458
	private readonly Dictionary<int, int> FetterSortIdMap = new Dictionary<int, int>();

	// Token: 0x04008E6B RID: 36459
	private bool DropDownDirty;

	// Token: 0x04008E6C RID: 36460
	private bool InitState;

	// Token: 0x04008E6D RID: 36461
	private bool CurrentCompareState;

	// Token: 0x04008E6E RID: 36462
	private bool CurrentAnimationState;

	// Token: 0x04008E6F RID: 36463
	private int CurrentConfirmButtonRedDotUniqueId;

	// Token: 0x04008E70 RID: 36464
	private bool CameraState = true;

	// Token: 0x04008E71 RID: 36465
	private bool IfPlayingCostBlinkAnimate;

	// Token: 0x04008E72 RID: 36466
	private int PreSelectMeshId;

	// Token: 0x04008E73 RID: 36467
	[Nullable(2)]
	private VisionEquipmentRecommendItem VisionEquipmentRecommendItem;

	// Token: 0x04008E74 RID: 36468
	private int PresetSelectIndexInternal;

	// Token: 0x04008E75 RID: 36469
	[Nullable(2)]
	private TsUiBlur UiBlur;

	// Token: 0x04008E76 RID: 36470
	[Nullable(2)]
	private VisionEquipmentRecommendFetterGroupView VisionEquipmentRecommendFetterGroupView;

	// Token: 0x04008E77 RID: 36471
	[Nullable(2)]
	private SkeletalObserverHandle VisionSkeletalHandle;

	// Token: 0x02008A37 RID: 35383
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CE02 RID: 183810
		MainVisionItem,
		// Token: 0x0402CE03 RID: 183811
		SubVisionItem1,
		// Token: 0x0402CE04 RID: 183812
		SubVisionItem2,
		// Token: 0x0402CE05 RID: 183813
		SubVisionItem3,
		// Token: 0x0402CE06 RID: 183814
		SubVisionItem4,
		// Token: 0x0402CE07 RID: 183815
		CostTextBack,
		// Token: 0x0402CE08 RID: 183816
		Scroller,
		// Token: 0x0402CE09 RID: 183817
		CaptionItem,
		// Token: 0x0402CE0A RID: 183818
		LoopItem,
		// Token: 0x0402CE0B RID: 183819
		FilterItem,
		// Token: 0x0402CE0C RID: 183820
		AttributePanelOne,
		// Token: 0x0402CE0D RID: 183821
		AttributePanelTwo,
		// Token: 0x0402CE0E RID: 183822
		Filter,
		// Token: 0x0402CE0F RID: 183823
		Sort,
		// Token: 0x0402CE10 RID: 183824
		BgBlack,
		// Token: 0x0402CE11 RID: 183825
		DragPanel,
		// Token: 0x0402CE12 RID: 183826
		DragItem,
		// Token: 0x0402CE13 RID: 183827
		HeadListLayout,
		// Token: 0x0402CE14 RID: 183828
		LongPressItem,
		// Token: 0x0402CE15 RID: 183829
		LongPressBar,
		// Token: 0x0402CE16 RID: 183830
		SwitchCostTab,
		// Token: 0x0402CE17 RID: 183831
		SimplyToggle,
		// Token: 0x0402CE18 RID: 183832
		SuitFilter,
		// Token: 0x0402CE19 RID: 183833
		TabItem1,
		// Token: 0x0402CE1A RID: 183834
		TabItem2,
		// Token: 0x0402CE1B RID: 183835
		TabItem3,
		// Token: 0x0402CE1C RID: 183836
		TabItem4,
		// Token: 0x0402CE1D RID: 183837
		MonsterSkinBtn,
		// Token: 0x0402CE1E RID: 183838
		ButtonRedDot,
		// Token: 0x0402CE1F RID: 183839
		CompareButton,
		// Token: 0x0402CE20 RID: 183840
		CostTextFront,
		// Token: 0x0402CE21 RID: 183841
		MonsterSkinBtnRedDot,
		// Token: 0x0402CE22 RID: 183842
		JumpVisionRecoveryButton,
		// Token: 0x0402CE23 RID: 183843
		RecommendPanel,
		// Token: 0x0402CE24 RID: 183844
		RecommendToggle,
		// Token: 0x0402CE25 RID: 183845
		EmptyItem,
		// Token: 0x0402CE26 RID: 183846
		PnlRoleVisionPrefabInfo,
		// Token: 0x0402CE27 RID: 183847
		PnlCurrentElement
	}
}
