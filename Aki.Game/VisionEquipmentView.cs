using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.TabView.VisionSubView;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x020019AC RID: 6572
[NullableContext(1)]
[Nullable(0)]
public class VisionEquipmentView : UiViewBase
{
	// Token: 0x060102B1 RID: 66225 RVA: 0x004B68B0 File Offset: 0x004B4AB0
	public VisionEquipmentView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060102B2 RID: 66226 RVA: 0x004B6944 File Offset: 0x004B4B44
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

	// Token: 0x060102B3 RID: 66227 RVA: 0x004B6D30 File Offset: 0x004B4F30
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.RefreshPhantom));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add(EEventName.PhantomEquipError, new Action(this.OnEquipError));
		EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		EventSystem.Instance.Add<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
		EventSystem.Instance.Add(EEventName.VisionFilterMonster, new Action(this.OnVisionFilterMonster));
		EventSystem.Instance.Add<UiCameraDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnCameraFinish));
		EventSystem.Instance.Add<bool>(EEventName.VisionSkinViewClose, new Action<bool>(this.VisionSkinViewClose));
		EventSystem.Instance.Add<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Add<int, int>(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
	}

	// Token: 0x060102B4 RID: 66228 RVA: 0x004B6E74 File Offset: 0x004B5074
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomPersonalSkillActive, new Action<int>(this.RefreshPhantom));
		EventSystem.Instance.Remove<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.PhantomEquipError, new Action(this.OnEquipError));
		EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
		EventSystem.Instance.Remove<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, new Action<int, int, bool>(this.OnEquipEquipment));
		EventSystem.Instance.Remove(EEventName.VisionFilterMonster, new Action(this.OnVisionFilterMonster));
		EventSystem.Instance.Remove<UiCameraDefine.IFinishData>(EEventName.OnPlayCameraAnimationFinish, new Action<UiCameraDefine.IFinishData>(this.OnCameraFinish));
		EventSystem.Instance.Remove<bool>(EEventName.VisionSkinViewClose, new Action<bool>(this.VisionSkinViewClose));
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnPhantomStackMerge, new Action<int, int>(this.OnPhantomStackMerge));
	}

	// Token: 0x060102B5 RID: 66229 RVA: 0x004B6FB8 File Offset: 0x004B51B8
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

	// Token: 0x060102B6 RID: 66230 RVA: 0x004B71EE File Offset: 0x004B53EE
	private void InitUiBlur()
	{
		AUIBaseActor rootActor = this.RootActor;
		this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		if (this.UiBlur != null)
		{
			this.UiBlur.SetEnableUiBlur(false);
		}
	}

	// Token: 0x060102B7 RID: 66231 RVA: 0x004B722C File Offset: 0x004B542C
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

	// Token: 0x060102B8 RID: 66232 RVA: 0x004B72A0 File Offset: 0x004B54A0
	private void SequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "ContrastSwitch")
		{
			base.GetItem(11).SetUIActive(this.CurrentAnimationState);
		}
	}

	// Token: 0x060102B9 RID: 66233 RVA: 0x004B72C2 File Offset: 0x004B54C2
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

	// Token: 0x060102BA RID: 66234 RVA: 0x004B72F4 File Offset: 0x004B54F4
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

	// Token: 0x060102BB RID: 66235 RVA: 0x004B7334 File Offset: 0x004B5534
	private void OnSelectAllCallback(List<int> fetterGroupIds, bool isSelectAll)
	{
		FilterEntrance<IPhantomItemData> filterEntrance = this.FilterEntrance;
		if (filterEntrance != null)
		{
			filterEntrance.TryClearData();
		}
		if (isSelectAll)
		{
			List<int> list = new List<int>();
			foreach (int item in fetterGroupIds)
			{
				int num = this.FetterSuitFilterArray.IndexOf(item);
				if (num > 0)
				{
					list.Add(num);
				}
			}
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

	// Token: 0x060102BC RID: 66236 RVA: 0x004B73F8 File Offset: 0x004B55F8
	private void RefreshSelectAllToggleState()
	{
		if (this.VisionEquipmentRecommendItem == null)
		{
			return;
		}
		List<int> selectedFetterGroupIds = this.GetSelectedFetterGroupIds();
		this.VisionEquipmentRecommendItem.RefreshSelectAllToggleState(selectedFetterGroupIds);
	}

	// Token: 0x060102BD RID: 66237 RVA: 0x004B7424 File Offset: 0x004B5624
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

	// Token: 0x060102BE RID: 66238 RVA: 0x004B74D4 File Offset: 0x004B56D4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionEquipmentView.<OnBeforeStartAsync>d__75 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionEquipmentView.<OnBeforeStartAsync>d__75>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060102BF RID: 66239 RVA: 0x004B7518 File Offset: 0x004B5718
	private void InitDetailItem()
	{
		this.VisionDetailComponent.GetDetailUnderComponent().SetRightButtonClick(new Action(this.OnClickLevelUpButton));
		this.VisionDetailComponent.GetDetailUnderComponent().SetLeftButtonClick(new Action(this.OnClickEquipButton));
		this.VisionDetailComponent.SetActive(false);
		this.VisionDetailComponentCompare.SetButtonPanelShowState(true);
		this.VisionDetailComponentCompare.SetActive(true);
	}

	// Token: 0x060102C0 RID: 66240 RVA: 0x004B7584 File Offset: 0x004B5784
	private UniTask InitVisionTabItem()
	{
		VisionEquipmentView.<InitVisionTabItem>d__77 <InitVisionTabItem>d__;
		<InitVisionTabItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitVisionTabItem>d__.<>4__this = this;
		<InitVisionTabItem>d__.<>1__state = -1;
		<InitVisionTabItem>d__.<>t__builder.Start<VisionEquipmentView.<InitVisionTabItem>d__77>(ref <InitVisionTabItem>d__);
		return <InitVisionTabItem>d__.<>t__builder.Task;
	}

	// Token: 0x060102C1 RID: 66241 RVA: 0x004B75C8 File Offset: 0x004B57C8
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

	// Token: 0x060102C2 RID: 66242 RVA: 0x004B76F4 File Offset: 0x004B58F4
	private void OnSuitToggled(int index, bool isSelected)
	{
		this.DropDownDirty = true;
		if (index == 0 && isSelected)
		{
			using (IEnumerator<int> enumerator = this.MultiSelectDropDown.GetSelectedIndices().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					if (num != 0)
					{
						this.MultiSelectDropDown.ToggleItem(num, false);
					}
				}
				goto IL_75;
			}
		}
		if (index != 0 && isSelected && this.MultiSelectDropDown.GetSelectedIndices().Contains(0))
		{
			this.MultiSelectDropDown.ToggleItem(0, false);
		}
		IL_75:
		if (this.MultiSelectDropDown.GetSelectedIndices().Count == 0)
		{
			this.MultiSelectDropDown.ToggleItem(0, true);
		}
	}

	// Token: 0x060102C3 RID: 66243 RVA: 0x004B77A8 File Offset: 0x004B59A8
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

	// Token: 0x060102C4 RID: 66244 RVA: 0x004B7810 File Offset: 0x004B5A10
	private int GetDropDownTextId(int data)
	{
		return data;
	}

	// Token: 0x060102C5 RID: 66245 RVA: 0x004B7813 File Offset: 0x004B5A13
	private VisionEquipmentDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
	{
		VisionEquipmentDropDownItem visionEquipmentDropDownItem = new VisionEquipmentDropDownItem(uiItem);
		visionEquipmentDropDownItem.SetRoleId(this.RoleId);
		return visionEquipmentDropDownItem;
	}

	// Token: 0x060102C6 RID: 66246 RVA: 0x004B7827 File Offset: 0x004B5A27
	private VisionEquipmentMultiSelectDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new VisionEquipmentMultiSelectDropDownTitleItem(uiItem);
	}

	// Token: 0x060102C7 RID: 66247 RVA: 0x004B7830 File Offset: 0x004B5A30
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

	// Token: 0x060102C8 RID: 66248 RVA: 0x004B78C0 File Offset: 0x004B5AC0
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

	// Token: 0x060102C9 RID: 66249 RVA: 0x004B7973 File Offset: 0x004B5B73
	private CostTabItem TabItemProxyCreate(UUIItem uiItem, int index)
	{
		CostTabItem costTabItem = new CostTabItem(uiItem);
		costTabItem.Init();
		return costTabItem;
	}

	// Token: 0x060102CA RID: 66250 RVA: 0x004B7981 File Offset: 0x004B5B81
	private void ToggleCallBack(int index)
	{
		this.CurrentCost = this.CostArray[index];
		this.VisionEquipmentRecommendItem.ChangeCost(this.CurrentCost, this.RoleId);
	}

	// Token: 0x060102CB RID: 66251 RVA: 0x004B79AC File Offset: 0x004B5BAC
	private void OnSimplyButtonClick(EToggleState toggleState)
	{
		PhantomBattleModel.Instance.SaveIfSimpleState(1, toggleState != EToggleState.ETT_Checked);
	}

	// Token: 0x060102CC RID: 66252 RVA: 0x004B79C0 File Offset: 0x004B5BC0
	private void OnMonsterSkinBtnClick()
	{
		VisionSkinViewOpenParam visionSkinViewOpenParam = new VisionSkinViewOpenParam();
		PhantomBattleData currentSelectPhantomData = this.CurrentSelectPhantomData;
		visionSkinViewOpenParam.UniqueId = ((currentSelectPhantomData != null) ? new int?(currentSelectPhantomData.GetUniqueId()) : null);
		visionSkinViewOpenParam.ShowItemIdList = null;
		IVisionSkinViewOpenParam param = visionSkinViewOpenParam;
		UiManager.Instance.OpenView(EUiViewName.VisionSkinView, param, null);
	}

	// Token: 0x060102CD RID: 66253 RVA: 0x004B7A10 File Offset: 0x004B5C10
	private void OnCameraFinish(UiCameraDefine.IFinishData finishData)
	{
		if (finishData.ToHandleData.GetViewName() != EUiViewName.VisionEquipmentView)
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

	// Token: 0x060102CE RID: 66254 RVA: 0x004B7A70 File Offset: 0x004B5C70
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

	// Token: 0x060102CF RID: 66255 RVA: 0x004B7A98 File Offset: 0x004B5C98
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

	// Token: 0x060102D0 RID: 66256 RVA: 0x004B7B14 File Offset: 0x004B5D14
	private void TryUnbindConfirmButtonRedDot()
	{
		if (this.CurrentConfirmButtonRedDotUniqueId > 0)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.VisionIdentifyTab, base.GetItem(28), this.CurrentConfirmButtonRedDotUniqueId);
			this.CurrentConfirmButtonRedDotUniqueId = 0;
		}
	}

	// Token: 0x060102D1 RID: 66257 RVA: 0x004B7B40 File Offset: 0x004B5D40
	private void RefreshConfirmButtonRedDot()
	{
		this.TryUnbindConfirmButtonRedDot();
		if (this.CurrentSelectPhantomData != null)
		{
			this.CurrentConfirmButtonRedDotUniqueId = this.CurrentSelectPhantomData.GetUniqueId();
			RedDotController.Instance.BindRedDot(ERedDotName.VisionIdentifyTab, base.GetItem(28), null, this.CurrentConfirmButtonRedDotUniqueId);
		}
	}

	// Token: 0x060102D2 RID: 66258 RVA: 0x004B7B7C File Offset: 0x004B5D7C
	private void ShowDefaultElement()
	{
		this.RefreshView(this.CurrentSelectPhantomData);
		this.RefreshMesh((this.CurrentSelectPhantomData != null) ? this.CurrentSelectPhantomData.GetUniqueId() : 0, false);
		this.RefreshPhantomClickState();
	}

	// Token: 0x060102D3 RID: 66259 RVA: 0x004B7BB0 File Offset: 0x004B5DB0
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

	// Token: 0x060102D4 RID: 66260 RVA: 0x004B7C5D File Offset: 0x004B5E5D
	private void SetPressItemAlpha(float alpha)
	{
		base.GetItem(18).SetAlpha(alpha);
		this.LongPressItemAlpha = alpha;
	}

	// Token: 0x060102D5 RID: 66261 RVA: 0x004B7C74 File Offset: 0x004B5E74
	private void SetPressItemShowState(bool state)
	{
		base.GetItem(18).SetUIActive(state);
	}

	// Token: 0x060102D6 RID: 66262 RVA: 0x004B7C84 File Offset: 0x004B5E84
	private void DoEquip(PhantomBattleData phantomData, int targetIndex, Action doFunction)
	{
		if (!this.CheckCost(phantomData, targetIndex))
		{
			this.ResetVisionPosition(true);
			return;
		}
		this.TryEquip(phantomData, targetIndex, doFunction);
	}

	// Token: 0x060102D7 RID: 66263 RVA: 0x004B7CA4 File Offset: 0x004B5EA4
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

	// Token: 0x060102D8 RID: 66264 RVA: 0x004B7DA0 File Offset: 0x004B5FA0
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

	// Token: 0x060102D9 RID: 66265 RVA: 0x004B7E10 File Offset: 0x004B6010
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

	// Token: 0x060102DA RID: 66266 RVA: 0x004B802C File Offset: 0x004B622C
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

	// Token: 0x060102DB RID: 66267 RVA: 0x004B8080 File Offset: 0x004B6280
	private void OnClickJumpVisionRecoveryButton()
	{
		this.PreSelectMeshId = this.CurrentMeshId;
		this.DestroyVisionHandle();
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
	}

	// Token: 0x060102DC RID: 66268 RVA: 0x004B80A4 File Offset: 0x004B62A4
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

	// Token: 0x060102DD RID: 66269 RVA: 0x004B80DF File Offset: 0x004B62DF
	private void OnClickCompareButton()
	{
		if (base.GetExtendToggle(34).GetToggleState() == EToggleState.ETT_Checked)
		{
			base.GetExtendToggle(34).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.VisionEquipmentRecommendItem.Hide(null);
		}
		this.OnCompareButtonClicked();
	}

	// Token: 0x060102DE RID: 66270 RVA: 0x004B8118 File Offset: 0x004B6318
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

	// Token: 0x060102DF RID: 66271 RVA: 0x004B8224 File Offset: 0x004B6424
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

	// Token: 0x060102E0 RID: 66272 RVA: 0x004B82DF File Offset: 0x004B64DF
	private void RefreshUiBlur(bool state)
	{
		if (this.UiBlur != null)
		{
			this.UiBlur.SetEnableUiBlur(state);
		}
	}

	// Token: 0x060102E1 RID: 66273 RVA: 0x004B82F8 File Offset: 0x004B64F8
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

	// Token: 0x060102E2 RID: 66274 RVA: 0x004B8371 File Offset: 0x004B6571
	private void OnItemRefresh(VisionMediumItemGrid item)
	{
		if (item.CheckSelectedState(this.CurrentSelectPhantomData))
		{
			this.LoopScrollView.DeselectCurrentGridProxy(false);
			this.LoopScrollView.SelectGridProxy(item.GridIndex, false);
		}
	}

	// Token: 0x060102E3 RID: 66275 RVA: 0x004B839F File Offset: 0x004B659F
	private void SetCurrentSelectPhantomData(PhantomBattleData data)
	{
		this.CurrentSelectPhantomData = data;
		this.RefreshSwitchButtonText();
		this.RefreshCostText();
		this.RefreshConfirmButtonRedDot();
	}

	// Token: 0x060102E4 RID: 66276 RVA: 0x004B83BA File Offset: 0x004B65BA
	private void ClearPhantomClickTick()
	{
		if (this.PhantomClickTick != -1)
		{
			TickSystem.Instance.Remove(this.PhantomClickTick);
			this.PhantomClickTick = -1;
		}
	}

	// Token: 0x060102E5 RID: 66277 RVA: 0x004B83E0 File Offset: 0x004B65E0
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

	// Token: 0x060102E6 RID: 66278 RVA: 0x004B84B8 File Offset: 0x004B66B8
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

	// Token: 0x060102E7 RID: 66279 RVA: 0x004B8580 File Offset: 0x004B6780
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

	// Token: 0x060102E8 RID: 66280 RVA: 0x004B85DD File Offset: 0x004B67DD
	private void ClearScrollerMoveTick()
	{
		if (this.ScrollerTickId != -1)
		{
			TickSystem.Instance.Remove(this.ScrollerTickId);
			this.ScrollerTickId = -1;
		}
	}

	// Token: 0x060102E9 RID: 66281 RVA: 0x004B8600 File Offset: 0x004B6800
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

	// Token: 0x060102EA RID: 66282 RVA: 0x004B87BC File Offset: 0x004B69BC
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

	// Token: 0x060102EB RID: 66283 RVA: 0x004B883C File Offset: 0x004B6A3C
	private void ClearScrollerItemMoveTick()
	{
		if (this.PhantomScrollerItemPositionTick != -1)
		{
			TickSystem.Instance.Remove(this.PhantomScrollerItemPositionTick);
			this.PhantomScrollerItemPositionTick = -1;
		}
	}

	// Token: 0x060102EC RID: 66284 RVA: 0x004B8860 File Offset: 0x004B6A60
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

	// Token: 0x060102ED RID: 66285 RVA: 0x004B88D0 File Offset: 0x004B6AD0
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

	// Token: 0x060102EE RID: 66286 RVA: 0x004B8940 File Offset: 0x004B6B40
	private void UnEquip(int index)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		PhantomBattleController.Instance.SendPhantomPutOnRequest(0, roleInstanceById.GetRoleId(), index, index, false);
	}

	// Token: 0x060102EF RID: 66287 RVA: 0x004B8974 File Offset: 0x004B6B74
	private void CheckIfCanEquip(PhantomBattleData phantomData, int index, Action call)
	{
		int? equipRole = PhantomBattleController.Instance.GetEquipRole(phantomData.GetUniqueId());
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (equipRole != null && equipRole.Value != roleInstanceById.GetRoleId())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomEquipRoleTip);
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(equipRole.Value);
			string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				roleName
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

	// Token: 0x060102F0 RID: 66288 RVA: 0x004B8A53 File Offset: 0x004B6C53
	protected void OnClickFailVision(int index)
	{
		this.ResetVisionPosition(true);
	}

	// Token: 0x060102F1 RID: 66289 RVA: 0x004B8A60 File Offset: 0x004B6C60
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

	// Token: 0x060102F2 RID: 66290 RVA: 0x004B8AE4 File Offset: 0x004B6CE4
	private void SetCurrentSelectIndex(int index)
	{
		if (this.CurrentSelectIndex == (EPhantomItemIndex)index)
		{
			return;
		}
		this.CurrentSelectIndex = (EPhantomItemIndex)index;
		PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = index;
	}

	// Token: 0x060102F3 RID: 66291 RVA: 0x004B8B02 File Offset: 0x004B6D02
	private void RefreshVisionBySelectIndex(bool meshChangeGoldEffect = false, bool needResetScrollerWhenUniqueIdZero = true, bool needScrollToItem = true)
	{
		this.RefreshScrollByCurrentUniqueId(needResetScrollerWhenUniqueIdZero, needScrollToItem);
		this.RefreshVisionBySelectPhantomData(meshChangeGoldEffect);
	}

	// Token: 0x060102F4 RID: 66292 RVA: 0x004B8B14 File Offset: 0x004B6D14
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

	// Token: 0x060102F5 RID: 66293 RVA: 0x004B8BA4 File Offset: 0x004B6DA4
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

	// Token: 0x060102F6 RID: 66294 RVA: 0x004B8BF8 File Offset: 0x004B6DF8
	private void SetClickStateUnCheck()
	{
		int count = this.RoleVisionItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.RoleVisionItem[i].SetToggleState(EToggleState.ETT_UnChecked, false, true);
		}
	}

	// Token: 0x060102F7 RID: 66295 RVA: 0x004B8C34 File Offset: 0x004B6E34
	private void RefreshPhantomClickState()
	{
		int count = this.RoleVisionItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.RoleVisionItem[i].SetToggleState((this.CurrentSelectIndex == (EPhantomItemIndex)i) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false);
		}
	}

	// Token: 0x060102F8 RID: 66296 RVA: 0x004B8C7C File Offset: 0x004B6E7C
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

	// Token: 0x060102F9 RID: 66297 RVA: 0x004B8CDA File Offset: 0x004B6EDA
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

	// Token: 0x060102FA RID: 66298 RVA: 0x004B8D14 File Offset: 0x004B6F14
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

	// Token: 0x060102FB RID: 66299 RVA: 0x004B8D58 File Offset: 0x004B6F58
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

	// Token: 0x060102FC RID: 66300 RVA: 0x004B8DF8 File Offset: 0x004B6FF8
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

	// Token: 0x060102FD RID: 66301 RVA: 0x004B8F04 File Offset: 0x004B7104
	private void RefreshFilterList()
	{
		if (PhantomBattleModel.Instance.CurrentSelectedFetter != null)
		{
			PhantomBattleModel.Instance.CurrentSelectedFetter = null;
		}
	}

	// Token: 0x060102FE RID: 66302 RVA: 0x004B8F38 File Offset: 0x004B7138
	private void UpdateFilterComponent()
	{
		MultiSelectDropDown<int, int> multiSelectDropDown = this.MultiSelectDropDown;
		IReadOnlySet<int> readOnlySet = (multiSelectDropDown != null) ? multiSelectDropDown.GetSelectedIndices() : null;
		IPhantomItemData[] collection;
		if (readOnlySet == null || readOnlySet.Contains(0) || readOnlySet.Count == 0)
		{
			collection = PhantomBattleModel.Instance.GetVisionSortUseDataList(0, this.CurrentCost);
		}
		else
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int index in readOnlySet)
			{
				hashSet.Add(this.FetterSuitFilterArray[index]);
			}
			collection = PhantomBattleModel.Instance.GetVisionSortUseDataListByMultiGroup(hashSet, this.CurrentCost);
		}
		MultiSelectDropDown<int, int> multiSelectDropDown2 = this.MultiSelectDropDown;
		if (multiSelectDropDown2 != null)
		{
			multiSelectDropDown2.RefreshAllDropDownItem();
		}
		this.FilterEntrance.UpdateDataWithConfig(this.UseWayId, EFilterSortConfigId.VisionEquipment, new List<IPhantomItemData>(collection), this.RoleId.ToString(), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateDataWithConfig(this.UseWayId, EFilterSortConfigId.VisionEquipment, new List<IPhantomItemData>(collection), this.RoleId.ToString(), new object[]
		{
			this.RoleId
		});
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(this.UseWayId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x060102FF RID: 66303 RVA: 0x004B90A4 File Offset: 0x004B72A4
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

	// Token: 0x06010300 RID: 66304 RVA: 0x004B9130 File Offset: 0x004B7330
	protected override void OnAfterHide()
	{
		this.ResetVisionPosition(true);
		UiLayer.Instance.SetShowMaskLayer("playBackToStartPositionAnimation", false);
		UiLayer.Instance.SetShowMaskLayer("OnEquipVision", false);
	}

	// Token: 0x06010301 RID: 66305 RVA: 0x004B915C File Offset: 0x004B735C
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

	// Token: 0x06010302 RID: 66306 RVA: 0x004B91D8 File Offset: 0x004B73D8
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

	// Token: 0x06010303 RID: 66307 RVA: 0x004B9234 File Offset: 0x004B7434
	[NullableContext(2)]
	private void RefreshView(PhantomBattleData data)
	{
		this.RefreshPhantomHead();
		this.RefreshCostText();
		this.RefreshSkinButton();
		this.ScrollToUniqueItem((data != null) ? data.GetUniqueId() : 0, true);
	}

	// Token: 0x06010304 RID: 66308 RVA: 0x004B925C File Offset: 0x004B745C
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

	// Token: 0x06010305 RID: 66309 RVA: 0x004B92E4 File Offset: 0x004B74E4
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

	// Token: 0x06010306 RID: 66310 RVA: 0x004B934B File Offset: 0x004B754B
	private void OnItemFuncValueChange(int _)
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06010307 RID: 66311 RVA: 0x004B9358 File Offset: 0x004B7558
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

	// Token: 0x06010308 RID: 66312 RVA: 0x004B93D4 File Offset: 0x004B75D4
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

	// Token: 0x06010309 RID: 66313 RVA: 0x004B945C File Offset: 0x004B765C
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

	// Token: 0x0601030A RID: 66314 RVA: 0x004B94B0 File Offset: 0x004B76B0
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

	// Token: 0x0601030B RID: 66315 RVA: 0x004B9548 File Offset: 0x004B7748
	protected void OnPointerDownCallBack(int index)
	{
		base.GetItem(15).SetRaycastTarget(true);
		int count = this.VisionDragItem.Count;
		for (int i = 0; i < count; i++)
		{
			this.VisionDragItem[i].StartClickCheckTimer();
		}
	}

	// Token: 0x0601030C RID: 66316 RVA: 0x004B958C File Offset: 0x004B778C
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

	// Token: 0x0601030D RID: 66317 RVA: 0x004B9600 File Offset: 0x004B7800
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

	// Token: 0x0601030E RID: 66318 RVA: 0x004B964C File Offset: 0x004B784C
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

	// Token: 0x0601030F RID: 66319 RVA: 0x004B9697 File Offset: 0x004B7897
	private void ClearFailAnimationTick()
	{
		if (this.FailAnimationTick != -1)
		{
			TickSystem.Instance.Remove(this.FailAnimationTick);
			this.FailAnimationTick = -1;
		}
	}

	// Token: 0x06010310 RID: 66320 RVA: 0x004B96BC File Offset: 0x004B78BC
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

	// Token: 0x06010311 RID: 66321 RVA: 0x004B9707 File Offset: 0x004B7907
	private void SetIndexVisionMoveState(int index, bool state)
	{
		if (index >= 0)
		{
			this.VisionDragItem[index].SetMovingState(state);
		}
	}

	// Token: 0x06010312 RID: 66322 RVA: 0x004B971F File Offset: 0x004B791F
	private void SetIndexVisionAnimateState(int index, bool state)
	{
		if (index >= 0)
		{
			this.RoleVisionItem[index].SetAnimationState(state);
		}
	}

	// Token: 0x06010313 RID: 66323 RVA: 0x004B9737 File Offset: 0x004B7937
	protected void OnEquipError()
	{
		this.ResetVisionPosition(true);
	}

	// Token: 0x06010314 RID: 66324 RVA: 0x004B9744 File Offset: 0x004B7944
	private void RefreshEmptyItem()
	{
		int count = this.CurrentShowingDataList.Count;
		base.GetItem(35).SetUIActive(count == 0);
	}

	// Token: 0x06010315 RID: 66325 RVA: 0x004B976E File Offset: 0x004B796E
	protected void OnPhantomEquip()
	{
		this.RefreshVisionDetailCompare();
	}

	// Token: 0x06010316 RID: 66326 RVA: 0x004B9776 File Offset: 0x004B7976
	private void OnAddPhantomItemList(IReadOnlyList<Aki.Protocol.PhantomItem> phantomItemList, bool isCatch)
	{
		this.SuppressScrollOnRebuild = true;
		this.UpdateFilterComponent();
		this.SuppressScrollOnRebuild = false;
	}

	// Token: 0x06010317 RID: 66327 RVA: 0x004B978C File Offset: 0x004B798C
	private void OnRemovePhantomItem(IReadOnlyList<int> uniqueIdList)
	{
		this.SuppressScrollOnRebuild = true;
		this.UpdateFilterComponent();
		this.SuppressScrollOnRebuild = false;
	}

	// Token: 0x06010318 RID: 66328 RVA: 0x004B97A4 File Offset: 0x004B79A4
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

	// Token: 0x06010319 RID: 66329 RVA: 0x004B97DF File Offset: 0x004B79DF
	protected void OnVisionFilterMonster()
	{
		this.RefreshFilterList();
	}

	// Token: 0x0601031A RID: 66330 RVA: 0x004B97E8 File Offset: 0x004B79E8
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

	// Token: 0x0601031B RID: 66331 RVA: 0x004B98AC File Offset: 0x004B7AAC
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

	// Token: 0x0601031C RID: 66332 RVA: 0x004B998C File Offset: 0x004B7B8C
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

	// Token: 0x0601031D RID: 66333 RVA: 0x004B9B20 File Offset: 0x004B7D20
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

	// Token: 0x0601031E RID: 66334 RVA: 0x004B9B6C File Offset: 0x004B7D6C
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

	// Token: 0x0601031F RID: 66335 RVA: 0x004B9C04 File Offset: 0x004B7E04
	private UniTask DoCeaseAnimationAndResetView()
	{
		VisionEquipmentView.<DoCeaseAnimationAndResetView>d__172 <DoCeaseAnimationAndResetView>d__;
		<DoCeaseAnimationAndResetView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoCeaseAnimationAndResetView>d__.<>4__this = this;
		<DoCeaseAnimationAndResetView>d__.<>1__state = -1;
		<DoCeaseAnimationAndResetView>d__.<>t__builder.Start<VisionEquipmentView.<DoCeaseAnimationAndResetView>d__172>(ref <DoCeaseAnimationAndResetView>d__);
		return <DoCeaseAnimationAndResetView>d__.<>t__builder.Task;
	}

	// Token: 0x06010320 RID: 66336 RVA: 0x004B9C47 File Offset: 0x004B7E47
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

	// Token: 0x06010321 RID: 66337 RVA: 0x004B9C75 File Offset: 0x004B7E75
	private void ClearAnimationTick()
	{
		if (this.MoveAnimationTick != -1)
		{
			TickSystem.Instance.Remove(this.MoveAnimationTick);
			this.MoveAnimationTick = -1;
		}
	}

	// Token: 0x06010322 RID: 66338 RVA: 0x004B9C98 File Offset: 0x004B7E98
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010323 RID: 66339 RVA: 0x004B9CA1 File Offset: 0x004B7EA1
	private int GetCostMax()
	{
		return PhantomBattleModel.Instance.GetMaxCost();
	}

	// Token: 0x06010324 RID: 66340 RVA: 0x004B9CAD File Offset: 0x004B7EAD
	private void CheckAndCreateVisionHandle()
	{
		if (!UiSceneManager.Instance.HasVisionSkeletalHandle())
		{
			UiSceneManager.Instance.InitVisionSkeletalHandle();
		}
		this.VisionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
	}

	// Token: 0x06010325 RID: 66341 RVA: 0x004B9CD5 File Offset: 0x004B7ED5
	private void DestroyVisionHandle()
	{
		UiSceneManager.Instance.DestroyVisionSkeletalHandle();
		this.VisionSkeletalHandle = null;
		this.CurrentMeshId = 0;
	}

	// Token: 0x06010326 RID: 66342 RVA: 0x004B9CEF File Offset: 0x004B7EEF
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

	// Token: 0x06010327 RID: 66343 RVA: 0x004B9D2C File Offset: 0x004B7F2C
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

	// Token: 0x06010328 RID: 66344 RVA: 0x004B9D4C File Offset: 0x004B7F4C
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

	// Token: 0x06010329 RID: 66345 RVA: 0x004B9DB4 File Offset: 0x004B7FB4
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
				using (Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>.ValueCollection.Enumerator enumerator = selectRuleDataMap.Values.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						Dictionary<int, string> dictionary = enumerator.Current;
						if (dictionary == null || dictionary.Count > 1 || !dictionary.ContainsKey(num2.Value))
						{
							result = true;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0601032A RID: 66346 RVA: 0x004B9E80 File Offset: 0x004B8080
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

	// Token: 0x0601032B RID: 66347 RVA: 0x004B9F5C File Offset: 0x004B815C
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

	// Token: 0x0601032C RID: 66348 RVA: 0x004BA060 File Offset: 0x004B8260
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

	// Token: 0x0601032D RID: 66349 RVA: 0x004BA188 File Offset: 0x004B8388
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

	// Token: 0x04008F84 RID: 36740
	private const int ANIMATIONTIME = 300;

	// Token: 0x04008F85 RID: 36741
	private const int INVALIDINDEX = 999;

	// Token: 0x04008F86 RID: 36742
	private readonly EFilterSortGroupId UseWayId = EFilterSortGroupId.PhantomEquip;

	// Token: 0x04008F87 RID: 36743
	[Nullable(2)]
	private CustomPromise<bool> FailAnimationPromise;

	// Token: 0x04008F88 RID: 36744
	private int MoveAnimationTick = -1;

	// Token: 0x04008F89 RID: 36745
	private int PhantomClickTick = -1;

	// Token: 0x04008F8A RID: 36746
	private int FailAnimationTick = -1;

	// Token: 0x04008F8B RID: 36747
	private int PhantomScrollerItemPositionTick = -1;

	// Token: 0x04008F8C RID: 36748
	private int RoleId;

	// Token: 0x04008F8D RID: 36749
	private int CurrentAnimationSourceIndex;

	// Token: 0x04008F8E RID: 36750
	private int CurrentAnimationTargetIndex;

	// Token: 0x04008F8F RID: 36751
	private float CurrentRunningTime;

	// Token: 0x04008F90 RID: 36752
	private ERoleViewSource Source;

	// Token: 0x04008F91 RID: 36753
	private readonly List<RoleVisionCommonItem> RoleVisionItem = new List<RoleVisionCommonItem>();

	// Token: 0x04008F92 RID: 36754
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008F93 RID: 36755
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<VisionMediumItemGrid, PhantomBattleData> LoopScrollView;

	// Token: 0x04008F94 RID: 36756
	private List<PhantomBattleData> CurrentShowingDataList = new List<PhantomBattleData>();

	// Token: 0x04008F95 RID: 36757
	[Nullable(2)]
	private PhantomBattleData CurrentSelectPhantomData;

	// Token: 0x04008F96 RID: 36758
	[Nullable(2)]
	private VisionIntensifyViewPassData VisionIntensifyPassData;

	// Token: 0x04008F97 RID: 36759
	private EPhantomItemIndex CurrentSelectIndex;

	// Token: 0x04008F98 RID: 36760
	[Nullable(2)]
	private VisionDetailComponent VisionDetailComponent;

	// Token: 0x04008F99 RID: 36761
	[Nullable(2)]
	private VisionDetailComponent VisionDetailComponentCompare;

	// Token: 0x04008F9A RID: 36762
	private int CurrentMeshId;

	// Token: 0x04008F9B RID: 36763
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<IPhantomItemData> FilterEntrance;

	// Token: 0x04008F9C RID: 36764
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<IPhantomItemData> SortEntrance;

	// Token: 0x04008F9D RID: 36765
	[Nullable(2)]
	private LevelSequencePlayer RootLevelSequence;

	// Token: 0x04008F9E RID: 36766
	private int CurrentDragIndex = 999;

	// Token: 0x04008F9F RID: 36767
	private bool SuppressScrollOnRebuild;

	// Token: 0x04008FA0 RID: 36768
	private float PressTime;

	// Token: 0x04008FA1 RID: 36769
	private float FillPressTime;

	// Token: 0x04008FA2 RID: 36770
	private bool CheckState;

	// Token: 0x04008FA3 RID: 36771
	private bool AfterLongPressState;

	// Token: 0x04008FA4 RID: 36772
	private float OnPressPositionX;

	// Token: 0x04008FA5 RID: 36773
	private float OnPressPositionY;

	// Token: 0x04008FA6 RID: 36774
	private int ScrollerTickId = -1;

	// Token: 0x04008FA7 RID: 36775
	[Nullable(2)]
	private VisionMediumItemGrid CurrentPressItem;

	// Token: 0x04008FA8 RID: 36776
	[Nullable(2)]
	protected VisionEquipmentDragItem VisionEquipmentDragItem;

	// Token: 0x04008FA9 RID: 36777
	private readonly List<VisionCommonDragItem> VisionDragItem = new List<VisionCommonDragItem>();

	// Token: 0x04008FAA RID: 36778
	[Nullable(2)]
	private VisionCommonDragItem ScrollVisionDragItem;

	// Token: 0x04008FAB RID: 36779
	private float LongPressTime;

	// Token: 0x04008FAC RID: 36780
	private float BeforeLongPressTime;

	// Token: 0x04008FAD RID: 36781
	private float LongPressItemAlpha;

	// Token: 0x04008FAE RID: 36782
	private float ScrollerMoveDistance;

	// Token: 0x04008FAF RID: 36783
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StaticTabComponent<CostTabItem> StaticTabComponent;

	// Token: 0x04008FB0 RID: 36784
	private int CurrentCost;

	// Token: 0x04008FB1 RID: 36785
	private readonly List<int> CostArray = new List<int>();

	// Token: 0x04008FB2 RID: 36786
	[Nullable(2)]
	private MultiSelectDropDown<int, int> MultiSelectDropDown;

	// Token: 0x04008FB3 RID: 36787
	private readonly List<int> FetterSuitFilterArray = new List<int>();

	// Token: 0x04008FB4 RID: 36788
	private readonly Dictionary<int, int> FetterSortIdMap = new Dictionary<int, int>();

	// Token: 0x04008FB5 RID: 36789
	private bool DropDownDirty;

	// Token: 0x04008FB6 RID: 36790
	private bool InitState;

	// Token: 0x04008FB7 RID: 36791
	private bool CurrentCompareState;

	// Token: 0x04008FB8 RID: 36792
	private bool CurrentAnimationState;

	// Token: 0x04008FB9 RID: 36793
	private int CurrentConfirmButtonRedDotUniqueId;

	// Token: 0x04008FBA RID: 36794
	private bool CameraState = true;

	// Token: 0x04008FBB RID: 36795
	private bool IfPlayingCostBlinkAnimate;

	// Token: 0x04008FBC RID: 36796
	private int PreSelectMeshId;

	// Token: 0x04008FBD RID: 36797
	[Nullable(2)]
	private VisionEquipmentRecommendItem VisionEquipmentRecommendItem;

	// Token: 0x04008FBE RID: 36798
	private int PresetSelectIndexInternal;

	// Token: 0x04008FBF RID: 36799
	[Nullable(2)]
	private TsUiBlur UiBlur;

	// Token: 0x04008FC0 RID: 36800
	[Nullable(2)]
	private VisionEquipmentRecommendFetterGroupView VisionEquipmentRecommendFetterGroupView;

	// Token: 0x04008FC1 RID: 36801
	[Nullable(2)]
	private SkeletalObserverHandle VisionSkeletalHandle;

	// Token: 0x02007BC0 RID: 31680
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028121 RID: 164129
		MainVisionItem,
		// Token: 0x04028122 RID: 164130
		SubVisionItem1,
		// Token: 0x04028123 RID: 164131
		SubVisionItem2,
		// Token: 0x04028124 RID: 164132
		SubVisionItem3,
		// Token: 0x04028125 RID: 164133
		SubVisionItem4,
		// Token: 0x04028126 RID: 164134
		CostTextBack,
		// Token: 0x04028127 RID: 164135
		Scroller,
		// Token: 0x04028128 RID: 164136
		CaptionItem,
		// Token: 0x04028129 RID: 164137
		LoopItem,
		// Token: 0x0402812A RID: 164138
		FilterItem,
		// Token: 0x0402812B RID: 164139
		AttributePanelOne,
		// Token: 0x0402812C RID: 164140
		AttributePanelTwo,
		// Token: 0x0402812D RID: 164141
		Filter,
		// Token: 0x0402812E RID: 164142
		Sort,
		// Token: 0x0402812F RID: 164143
		BgBlack,
		// Token: 0x04028130 RID: 164144
		DragPanel,
		// Token: 0x04028131 RID: 164145
		DragItem,
		// Token: 0x04028132 RID: 164146
		HeadListLayout,
		// Token: 0x04028133 RID: 164147
		LongPressItem,
		// Token: 0x04028134 RID: 164148
		LongPressBar,
		// Token: 0x04028135 RID: 164149
		SwitchCostTab,
		// Token: 0x04028136 RID: 164150
		SimplyToggle,
		// Token: 0x04028137 RID: 164151
		SuitFilter,
		// Token: 0x04028138 RID: 164152
		TabItem1,
		// Token: 0x04028139 RID: 164153
		TabItem2,
		// Token: 0x0402813A RID: 164154
		TabItem3,
		// Token: 0x0402813B RID: 164155
		TabItem4,
		// Token: 0x0402813C RID: 164156
		MonsterSkinBtn,
		// Token: 0x0402813D RID: 164157
		ButtonRedDot,
		// Token: 0x0402813E RID: 164158
		CompareButton,
		// Token: 0x0402813F RID: 164159
		CostTextFront,
		// Token: 0x04028140 RID: 164160
		MonsterSkinBtnRedDot,
		// Token: 0x04028141 RID: 164161
		JumpVisionRecoveryButton,
		// Token: 0x04028142 RID: 164162
		RecommendPanel,
		// Token: 0x04028143 RID: 164163
		RecommendToggle,
		// Token: 0x04028144 RID: 164164
		EmptyItem,
		// Token: 0x04028145 RID: 164165
		PnlRoleVisionPrefabInfo,
		// Token: 0x04028146 RID: 164166
		PnlCurrentElement
	}
}
