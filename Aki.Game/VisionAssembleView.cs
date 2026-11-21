using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001978 RID: 6520
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleView : UiViewBase
{
	// Token: 0x06010153 RID: 65875 RVA: 0x004B00D0 File Offset: 0x004AE2D0
	public VisionAssembleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010154 RID: 65876 RVA: 0x004B0104 File Offset: 0x004AE304
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem))
		};
		int num = 3;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Delegate>(13, new Action<EToggleState>(this.OnCompareToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickToTopBtn));
		num2++;
		*span[num2] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickDeleteBtn));
		this.BtnBindInfo = list;
	}

	// Token: 0x06010155 RID: 65877 RVA: 0x004B0368 File Offset: 0x004AE568
	protected override UniTask OnCreateAsync()
	{
		VisionAssembleView.<OnCreateAsync>d__25 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<VisionAssembleView.<OnCreateAsync>d__25>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010156 RID: 65878 RVA: 0x004B03A4 File Offset: 0x004AE5A4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataUpdate, new Action(this.OnVisionGroupDataUpdate));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataAdd, new Action(this.OnVisionGroupDataAdd));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataDelete, new Action(this.OnVisionGroupDataDelete));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataToTop, new Action(this.OnVisionGroupDataToTop));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataChangeName, new Action(this.OnVisionGroupDataChangeName));
		EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
	}

	// Token: 0x06010157 RID: 65879 RVA: 0x004B045C File Offset: 0x004AE65C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataUpdate, new Action(this.OnVisionGroupDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataAdd, new Action(this.OnVisionGroupDataAdd));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataDelete, new Action(this.OnVisionGroupDataDelete));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataToTop, new Action(this.OnVisionGroupDataToTop));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataChangeName, new Action(this.OnVisionGroupDataChangeName));
		EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
	}

	// Token: 0x06010158 RID: 65880 RVA: 0x004B0514 File Offset: 0x004AE714
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010159 RID: 65881 RVA: 0x004B0558 File Offset: 0x004AE758
	private UniTask InitDropDown()
	{
		VisionAssembleView.<InitDropDown>d__29 <InitDropDown>d__;
		<InitDropDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDropDown>d__.<>4__this = this;
		<InitDropDown>d__.<>1__state = -1;
		<InitDropDown>d__.<>t__builder.Start<VisionAssembleView.<InitDropDown>d__29>(ref <InitDropDown>d__);
		return <InitDropDown>d__.<>t__builder.Task;
	}

	// Token: 0x0601015A RID: 65882 RVA: 0x004B059B File Offset: 0x004AE79B
	private void OnPhantomEquip()
	{
		this.RefreshCurrentSelectDataInfo();
		this.RefreshStaticItemSelectState();
		this.RefreshOperationFunctionState();
		this.RefreshFunctionButtonState();
		this.RefreshCompareTopData();
		this.RefreshCurrentSuitInfo();
		this.RefreshScroller(true, false);
		this.RefreshAttributeScroller(false, null);
	}

	// Token: 0x0601015B RID: 65883 RVA: 0x004B05D4 File Offset: 0x004AE7D4
	private void OnVisionGroupDataUpdate()
	{
		int count = VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count;
		if (this.CurrentSelectedIndex != 999 && this.CurrentSelectedIndex != -1 && this.CurrentSelectedIndex >= count)
		{
			this.CurrentSelectedIndex = ((count > 0) ? 0 : -1);
		}
		this.RefreshViewAfterChangeGroupData();
	}

	// Token: 0x0601015C RID: 65884 RVA: 0x004B0624 File Offset: 0x004AE824
	private void OnVisionGroupDataAdd()
	{
		this.UpdateFilterComponent();
		this.ClearFilter();
		this.CancelCompareMode();
		int count = VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count;
		this.CurrentSelectedIndex = count - 1;
		this.RefreshScroller(false, false);
		this.RefreshAttributeScroller(false, null);
		this.RefreshSaveText();
		this.RefreshOperationFunctionState();
		this.RefreshFunctionButtonState();
		this.RefreshCompareTopData();
		this.RefreshCompareToggleState();
	}

	// Token: 0x0601015D RID: 65885 RVA: 0x004B068C File Offset: 0x004AE88C
	private void OnVisionGroupDataDelete()
	{
		if (VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count > 0)
		{
			this.CurrentSelectedIndex = 0;
		}
		else
		{
			this.CurrentSelectedIndex = -1;
		}
		this.RefreshViewAfterChangeGroupData();
	}

	// Token: 0x0601015E RID: 65886 RVA: 0x004B06B6 File Offset: 0x004AE8B6
	private void OnVisionGroupDataToTop()
	{
		if (VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count > 0)
		{
			this.CurrentSelectedIndex = 0;
		}
		else
		{
			this.CurrentSelectedIndex = -1;
		}
		this.RefreshViewAfterChangeGroupData();
		EventSystem.Instance.Emit<bool>(EEventName.OnVisionAssembleNavigationRefresh, false);
	}

	// Token: 0x0601015F RID: 65887 RVA: 0x004B06F1 File Offset: 0x004AE8F1
	private void OnVisionGroupDataChangeName()
	{
		this.RefreshCompareTopData();
		this.RefreshCurrentSelectDataInfo();
		this.RefreshScroller(true, false);
	}

	// Token: 0x06010160 RID: 65888 RVA: 0x004B0707 File Offset: 0x004AE907
	private void RefreshViewAfterChangeGroupData()
	{
		this.RefreshScroller(false, false);
		this.RefreshAttributeScroller(false, null);
		this.RefreshSaveText();
		this.RefreshOperationFunctionState();
		this.RefreshFunctionButtonState();
		this.RefreshCompareTopData();
		this.UpdateFilterComponent();
	}

	// Token: 0x06010161 RID: 65889 RVA: 0x004B0737 File Offset: 0x004AE937
	private int GetDropDownTextId(int data)
	{
		return data;
	}

	// Token: 0x06010162 RID: 65890 RVA: 0x004B073A File Offset: 0x004AE93A
	private void OnDropDownSelectCall(int index, int data)
	{
		this.CurrentSelectSuitIndex = index;
		this.UpdateFilterComponent();
	}

	// Token: 0x06010163 RID: 65891 RVA: 0x004B0749 File Offset: 0x004AE949
	private VisionAssembleDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
	{
		return new VisionAssembleDropDownItem(uiItem);
	}

	// Token: 0x06010164 RID: 65892 RVA: 0x004B0751 File Offset: 0x004AE951
	private VisionEquipmentDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new VisionEquipmentDropDownTitleItem(uiItem);
	}

	// Token: 0x06010165 RID: 65893 RVA: 0x004B075C File Offset: 0x004AE95C
	private void OnCompareToggle(EToggleState toggleState)
	{
		this.CompareMode = !this.CompareMode;
		bool compareMode = this.CompareMode;
		this.RefreshAttributeScroller(compareMode, null);
		this.RefreshFunctionButtonState();
		this.RefreshStaticItemSelectState();
		UiNavigationModel.Instance.TrySetCursorActive(false);
		if (this.CompareMode)
		{
			this.RefreshCurrentSelectDataInfo();
			base.PlaySequence("Start_B", delegate
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnVisionAssembleNavigationRefresh, true);
			}, true);
		}
		else
		{
			this.RefreshCurrentSelectDataInfo();
			base.PlaySequence("Close_B", delegate
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnVisionAssembleNavigationRefresh, true);
			}, true);
		}
		this.AssembleScrollToSelectIndex(false);
	}

	// Token: 0x06010166 RID: 65894 RVA: 0x004B0814 File Offset: 0x004AEA14
	private void AssembleScrollToSelectIndex(bool playGridAnim = false)
	{
		if (this.CurrentSelectedIndex == -1)
		{
			return;
		}
		if (this.ShowList == null || this.ShowList.Count == 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < this.ShowList.Count; i++)
		{
			if (this.ShowList[i].CurrentSelectState)
			{
				num = i;
				break;
			}
		}
		int gridIndex = (num >= 0) ? num : 0;
		LoopScrollView<VisionAssembleScrollItem, VisionAssembleScrollItemData> assembleListLayout = this.AssembleListLayout;
		if (assembleListLayout == null)
		{
			return;
		}
		assembleListLayout.ScrollToGridIndex(gridIndex, playGridAnim);
	}

	// Token: 0x06010167 RID: 65895 RVA: 0x004B088B File Offset: 0x004AEA8B
	private bool CancelCompareMode()
	{
		if (!this.CompareMode)
		{
			return false;
		}
		this.OnCompareToggle(EToggleState.ETT_Checked);
		return true;
	}

	// Token: 0x06010168 RID: 65896 RVA: 0x004B08A0 File Offset: 0x004AEAA0
	private bool ClearFilter()
	{
		bool result = false;
		if (this.CurrentSelectSuitIndex != 0)
		{
			this.CommonDropDown.SetSelectedIndex(0, true);
			result = true;
		}
		if (this.FilterEntrance.TryClearData())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06010169 RID: 65897 RVA: 0x004B08D6 File Offset: 0x004AEAD6
	private void OnClickStaticItem()
	{
		if (this.CurrentSelectedIndex == -1)
		{
			this.CurrentSelectedIndex = 999;
		}
		else
		{
			this.CurrentSelectedIndex = -1;
		}
		this.OnChangeSelectIndex(true);
		this.RefreshFunctionButtonState();
		this.RefreshOperationFunctionState();
		this.RefreshAttributeScroller(false, null);
		this.RefreshCompareToggleState();
	}

	// Token: 0x0601016A RID: 65898 RVA: 0x004B0918 File Offset: 0x004AEB18
	private void OnClickConfirmButton(int _)
	{
		VisionAssembleView.EOperation currentOperationState = this.GetCurrentOperationState();
		if (currentOperationState == VisionAssembleView.EOperation.Use)
		{
			this.ApplyCurrentIndexGroup();
			this.CancelCompareMode();
			return;
		}
		if (currentOperationState == VisionAssembleView.EOperation.Save)
		{
			this.SaveCurrentIndexGroup();
			return;
		}
		if (currentOperationState == VisionAssembleView.EOperation.HasUsing)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("VisionAssembleHasUseTips", Array.Empty<object>());
		}
	}

	// Token: 0x0601016B RID: 65899 RVA: 0x004B0964 File Offset: 0x004AEB64
	private void SaveCurrentIndexGroup()
	{
		List<int> incrIdList = RoleModel.Instance.GetRoleInstanceById(this.CurrentRoleId).GetPhantomData().GetIncrIdList();
		bool flag = true;
		using (List<int>.Enumerator enumerator = incrIdList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current != 0)
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("VisionAssembleSaveNone", Array.Empty<object>());
			return;
		}
		int phantomEquipGroupCountMax = PhantomBattleConfig.Instance.GetPhantomEquipGroupCountMax();
		int count = VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count;
		if (count >= phantomEquipGroupCountMax)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionGroupMax);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = delegate([Nullable(1)] string input)
		{
			VisionAssembleView.<<SaveCurrentIndexGroup>b__47_0>d <<SaveCurrentIndexGroup>b__47_0>d;
			<<SaveCurrentIndexGroup>b__47_0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<<SaveCurrentIndexGroup>b__47_0>d.<>4__this = this;
			<<SaveCurrentIndexGroup>b__47_0>d.input = input;
			<<SaveCurrentIndexGroup>b__47_0>d.<>1__state = -1;
			<<SaveCurrentIndexGroup>b__47_0>d.<>t__builder.Start<VisionAssembleView.<<SaveCurrentIndexGroup>b__47_0>d>(ref <<SaveCurrentIndexGroup>b__47_0>d);
			return <<SaveCurrentIndexGroup>b__47_0>d.<>t__builder.Task;
		};
		string bottomText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("VisionAssembleCurrentIndex", null), new string[]
		{
			(count + 1).ToString()
		});
		CommonInputViewController.Instance.OpenSetVisionEquipGroupName(bottomText, callBack, "");
	}

	// Token: 0x0601016C RID: 65900 RVA: 0x004B0A64 File Offset: 0x004AEC64
	private void ApplyCurrentIndexGroup()
	{
		int[] visionUniqueIdList = VisionEquipGroupModel.Instance.GetVisionEquipGroupDataByIndex(this.CurrentSelectedIndex).GetVisionUniqueIdList();
		bool flag = false;
		foreach (int uniqueId in visionUniqueIdList)
		{
			int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(uniqueId);
			if (phantomEquipOnRoleId != null && phantomEquipOnRoleId.Value != this.CurrentRoleId)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionGroupOtherRoleUse);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				VisionEquipGroupController.Instance.RequestApplyVisionGroup(this.CurrentSelectedIndex, this.CurrentRoleId);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		VisionEquipGroupController.Instance.RequestApplyVisionGroup(this.CurrentSelectedIndex, this.CurrentRoleId);
	}

	// Token: 0x0601016D RID: 65901 RVA: 0x004B0B10 File Offset: 0x004AED10
	private void OnClickReNameBtn()
	{
		Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = delegate([Nullable(1)] string input)
		{
			VisionAssembleView.<<OnClickReNameBtn>b__49_0>d <<OnClickReNameBtn>b__49_0>d;
			<<OnClickReNameBtn>b__49_0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<<OnClickReNameBtn>b__49_0>d.<>4__this = this;
			<<OnClickReNameBtn>b__49_0>d.input = input;
			<<OnClickReNameBtn>b__49_0>d.<>1__state = -1;
			<<OnClickReNameBtn>b__49_0>d.<>t__builder.Start<VisionAssembleView.<<OnClickReNameBtn>b__49_0>d>(ref <<OnClickReNameBtn>b__49_0>d);
			return <<OnClickReNameBtn>b__49_0>d.<>t__builder.Task;
		};
		string bottomText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("VisionAssembleCurrentIndex", null), new string[]
		{
			(this.CurrentSelectedIndex + 1).ToString()
		});
		VisionEquipGroupData visionEquipGroupDataByIndex = VisionEquipGroupModel.Instance.GetVisionEquipGroupDataByIndex(this.CurrentSelectedIndex);
		string text = (visionEquipGroupDataByIndex != null) ? visionEquipGroupDataByIndex.GetName() : null;
		CommonInputViewController.Instance.OpenSetVisionEquipGroupName(bottomText, callBack, text ?? "");
	}

	// Token: 0x0601016E RID: 65902 RVA: 0x004B0B88 File Offset: 0x004AED88
	private void OnClickToTopBtn()
	{
		if (!VisionEquipGroupModel.Instance.GetLocalTipsState())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionGroupToTop);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = ConfigMultiTextLang.GetLocalTextNew("VisionAssembleTopNeverTips", null);
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnClickedNotShowConfirm));
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				VisionEquipGroupController.Instance.RequestPutVisionGroupToTop(this.CurrentSelectedIndex);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		VisionEquipGroupController.Instance.RequestPutVisionGroupToTop(this.CurrentSelectedIndex);
	}

	// Token: 0x0601016F RID: 65903 RVA: 0x004B0C0B File Offset: 0x004AEE0B
	private void OnClickedNotShowConfirm(bool toggleState)
	{
		VisionEquipGroupModel.Instance.SaveLocalTopTipState(toggleState);
	}

	// Token: 0x06010170 RID: 65904 RVA: 0x004B0C18 File Offset: 0x004AEE18
	private void OnClickDeleteBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionGroupDelete);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			VisionEquipGroupController.Instance.RequestDeleteVisionEquipGroup(this.CurrentSelectedIndex);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06010171 RID: 65905 RVA: 0x004B0C54 File Offset: 0x004AEE54
	private void UpdateFilterComponent()
	{
		List<VisionEquipGroupData> visionEquipGroupList = VisionEquipGroupModel.Instance.GetVisionEquipGroupList();
		List<int> list = new List<int>();
		foreach (VisionEquipGroupData visionEquipGroupData in visionEquipGroupList)
		{
			list.Add(visionEquipGroupData.GetIndex());
		}
		this.FilterEntrance.UpdateData(this.UseWayId, list, new object[]
		{
			this.CurrentRoleId
		});
	}

	// Token: 0x06010172 RID: 65906 RVA: 0x004B0CDC File Offset: 0x004AEEDC
	private VisionAssembleScrollItem InitAssembleItem()
	{
		return new VisionAssembleScrollItem();
	}

	// Token: 0x06010173 RID: 65907 RVA: 0x004B0CE3 File Offset: 0x004AEEE3
	private VisionAssembleAttrScrollItem InitItem()
	{
		return new VisionAssembleAttrScrollItem();
	}

	// Token: 0x06010174 RID: 65908 RVA: 0x004B0CEC File Offset: 0x004AEEEC
	private void OnFilterRefresh(List<int> list, bool ifOutSideChange, EFilterSortType type)
	{
		this.CurrentShowingGroupList = list;
		List<VisionEquipGroupData> filterDataList = this.GetFilterDataList();
		if (filterDataList.Count == 0)
		{
			this.CurrentSelectedIndex = -1;
		}
		else
		{
			this.CurrentSelectedIndex = filterDataList[0].GetIndex();
		}
		this.OnChangeSelectIndex(false);
		this.RefreshMiddleEmptyItem();
		this.CancelCompareMode();
	}

	// Token: 0x06010175 RID: 65909 RVA: 0x004B0D3E File Offset: 0x004AEF3E
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010176 RID: 65910 RVA: 0x004B0D48 File Offset: 0x004AEF48
	protected override void OnBeforeShow()
	{
		this.UpdateFilterComponent();
		this.CurrentSelectedIndex = -1;
		this.RefreshScroller(false, true);
		this.InitCurrentShowingGroupList();
		this.RefreshCurrentSuitInfo();
		this.RefreshCurrentSelectDataInfo();
		this.RefreshAttributeScroller(false, delegate
		{
			GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> attributeLayout = this.AttributeLayout;
			List<VisionAssembleAttrScrollItem> list = (attributeLayout != null) ? attributeLayout.GetScrollItemList() : null;
			if (list != null)
			{
				foreach (VisionAssembleAttrScrollItem visionAssembleAttrScrollItem in list)
				{
					visionAssembleAttrScrollItem.SetRightItemAlpha(0f);
				}
			}
			UUIInturnAnimController attributeTurnAniComponentR = this.AttributeTurnAniComponentR;
			if (attributeTurnAniComponentR == null)
			{
				return;
			}
			attributeTurnAniComponentR.Play("", -1, false);
		});
		this.RefreshSaveText();
		this.RefreshStaticItemSelectState();
		this.RefreshOperationFunctionState();
		this.RefreshFunctionButtonState();
		this.RefreshCompareTopData();
		this.RefreshCompareToggleState();
		this.RefreshMiddleEmptyItem();
		this.TryPlayInfoSequence();
	}

	// Token: 0x06010177 RID: 65911 RVA: 0x004B0DC0 File Offset: 0x004AEFC0
	private void InitCurrentShowingGroupList()
	{
		List<VisionEquipGroupData> visionEquipGroupList = VisionEquipGroupModel.Instance.GetVisionEquipGroupList();
		int count = visionEquipGroupList.Count;
		this.CurrentShowingGroupList = new List<int>();
		for (int i = 0; i < count; i++)
		{
			VisionEquipGroupData visionEquipGroupData = visionEquipGroupList[i];
			this.CurrentShowingGroupList.Add(visionEquipGroupData.GetIndex());
		}
	}

	// Token: 0x06010178 RID: 65912 RVA: 0x004B0E0F File Offset: 0x004AF00F
	private void RefreshCurrentSuitInfo()
	{
		VisionAssembleStaticItem staticItem = this.StaticItem;
		if (staticItem == null)
		{
			return;
		}
		staticItem.Refresh(this.CurrentRoleId);
	}

	// Token: 0x06010179 RID: 65913 RVA: 0x004B0E28 File Offset: 0x004AF028
	private List<VisionEquipGroupData> GetFilterDataList()
	{
		List<VisionEquipGroupData> visionEquipGroupList = VisionEquipGroupModel.Instance.GetVisionEquipGroupList();
		List<VisionEquipGroupData> list = new List<VisionEquipGroupData>();
		int num = (this.CurrentSelectSuitIndex > 0) ? this.FetterSuitFilterArray[this.CurrentSelectSuitIndex] : 0;
		int count = visionEquipGroupList.Count;
		bool filterIfHaveSelect = this.GetFilterIfHaveSelect();
		for (int i = 0; i < count; i++)
		{
			VisionEquipGroupData visionEquipGroupData = visionEquipGroupList[i];
			bool flag = false;
			if (num > 0)
			{
				List<VisionFetterData> visionFetterDataByIncIdList = VisionEquipGroupModel.Instance.GetVisionFetterDataByIncIdList(new List<int>(visionEquipGroupData.GetVisionUniqueIdList()));
				bool flag2 = false;
				using (List<VisionFetterData>.Enumerator enumerator = visionFetterDataByIncIdList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.FetterGroupId == num)
						{
							flag2 = true;
							break;
						}
					}
				}
				if (flag2)
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			bool flag3 = !filterIfHaveSelect;
			if (this.CurrentShowingGroupList.Count > 0)
			{
				flag3 = this.CurrentShowingGroupList.Contains(visionEquipGroupData.GetIndex());
			}
			else if (!filterIfHaveSelect)
			{
				flag3 = true;
			}
			if (flag && flag3)
			{
				list.Add(visionEquipGroupData);
			}
		}
		return list;
	}

	// Token: 0x0601017A RID: 65914 RVA: 0x004B0F48 File Offset: 0x004AF148
	private void RefreshScroller(bool keepPosition = false, bool needAnimation = false)
	{
		bool flag = this.GetFilterIfHaveSelect() || this.CurrentSelectSuitIndex > 0;
		List<VisionEquipGroupData> filterDataList = this.GetFilterDataList();
		int count = filterDataList.Count;
		VisionEquipGroupModel.Instance.FilterDataLength = count;
		int num = PhantomBattleConfig.Instance.GetPhantomEquipGroupCountMax();
		List<VisionAssembleScrollItemData> list = new List<VisionAssembleScrollItemData>();
		num = (flag ? filterDataList.Count : num);
		for (int i = 0; i < num; i++)
		{
			VisionAssembleScrollItemData visionAssembleScrollItemData = new VisionAssembleScrollItemData();
			VisionEquipGroupData visionEquipGroupData = (i < count) ? filterDataList[i] : null;
			visionAssembleScrollItemData.GroupIndex = i;
			visionAssembleScrollItemData.ClickCallback = new Action<VisionEquipGroupData>(this.OnClickScrollItem);
			VisionAssembleScrollItemData visionAssembleScrollItemData2 = visionAssembleScrollItemData;
			int? num2 = (visionEquipGroupData != null) ? new int?(visionEquipGroupData.GetIndex()) : null;
			int currentSelectedIndex = this.CurrentSelectedIndex;
			visionAssembleScrollItemData2.CurrentSelectState = (num2.GetValueOrDefault() == currentSelectedIndex & num2 != null);
			visionAssembleScrollItemData.VisionEquipGroupData = visionEquipGroupData;
			visionAssembleScrollItemData.CheckIfCanSelect = new Func<bool>(this.CheckIfCanSelect);
			list.Add(visionAssembleScrollItemData);
		}
		this.ShowList = list;
		LoopScrollView<VisionAssembleScrollItem, VisionAssembleScrollItemData> assembleListLayout = this.AssembleListLayout;
		if (assembleListLayout == null)
		{
			return;
		}
		assembleListLayout.RefreshByData(list, keepPosition, delegate
		{
			if (!keepPosition)
			{
				this.AssembleScrollToSelectIndex(needAnimation);
				return;
			}
			if (needAnimation)
			{
				LoopScrollView<VisionAssembleScrollItem, VisionAssembleScrollItemData> assembleListLayout2 = this.AssembleListLayout;
				if (assembleListLayout2 == null)
				{
					return;
				}
				UUIInturnAnimController uiAnimController = assembleListLayout2.GetUiAnimController();
				if (uiAnimController == null)
				{
					return;
				}
				uiAnimController.Play("", -1, false);
			}
		}, false);
	}

	// Token: 0x0601017B RID: 65915 RVA: 0x004B1098 File Offset: 0x004AF298
	private bool CheckIfCanSelect()
	{
		return true;
	}

	// Token: 0x0601017C RID: 65916 RVA: 0x004B109B File Offset: 0x004AF29B
	private void RefreshStaticItemSelectState()
	{
		VisionAssembleStaticItem staticItem = this.StaticItem;
		if (staticItem == null)
		{
			return;
		}
		staticItem.RefreshSelectState(this.CurrentSelectedIndex == -1, this.CompareMode);
	}

	// Token: 0x0601017D RID: 65917 RVA: 0x004B10BC File Offset: 0x004AF2BC
	private void OnClickScrollItem(VisionEquipGroupData data)
	{
		int index = data.GetIndex();
		if (index == this.CurrentSelectedIndex)
		{
			this.CurrentSelectedIndex = 999;
			this.CompareMode = false;
		}
		else
		{
			this.CurrentSelectedIndex = index;
		}
		this.OnChangeSelectIndex(true);
		this.RefreshCompareToggleState();
		this.RefreshCurrentSelectDataInfo();
	}

	// Token: 0x0601017E RID: 65918 RVA: 0x004B1107 File Offset: 0x004AF307
	private void OnChangeSelectIndex(bool keepPosition = true)
	{
		this.RefreshScroller(keepPosition, false);
		this.RefreshStaticItemSelectState();
		this.RefreshCompareTopData();
		this.RefreshOperationFunctionState();
		this.RefreshFunctionButtonState();
		this.RefreshCompareToggleState();
		this.RefreshAttributeScroller(false, delegate
		{
			GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> attributeLayout = this.AttributeLayout;
			List<VisionAssembleAttrScrollItem> list = (attributeLayout != null) ? attributeLayout.GetScrollItemList() : null;
			if (list != null)
			{
				foreach (VisionAssembleAttrScrollItem visionAssembleAttrScrollItem in list)
				{
					visionAssembleAttrScrollItem.SetRightItemAlpha(0f);
				}
			}
			UUIInturnAnimController attributeTurnAniComponentR = this.AttributeTurnAniComponentR;
			if (attributeTurnAniComponentR == null)
			{
				return;
			}
			attributeTurnAniComponentR.Play("", -1, false);
		});
	}

	// Token: 0x0601017F RID: 65919 RVA: 0x004B1144 File Offset: 0x004AF344
	private void RefreshOperationFunctionState()
	{
		VisionAssembleView.EOperation currentOperationState = this.GetCurrentOperationState();
		this.RefreshUseButtonByOperationState(currentOperationState);
	}

	// Token: 0x06010180 RID: 65920 RVA: 0x004B1160 File Offset: 0x004AF360
	private void RefreshUseButtonByOperationState(VisionAssembleView.EOperation state)
	{
		bool flag = state == VisionAssembleView.EOperation.Use || state == VisionAssembleView.EOperation.Save || state == VisionAssembleView.EOperation.HasUsing;
		this.ConfirmButtonItem.SetActive(flag);
		if (flag)
		{
			string showText;
			if (state == VisionAssembleView.EOperation.Use)
			{
				showText = "VisionAssembleUse";
			}
			else if (state == VisionAssembleView.EOperation.HasUsing)
			{
				showText = "VisionAssembleUse";
			}
			else
			{
				showText = "VisionAssembleSave";
			}
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.SetShowText(showText);
		}
	}

	// Token: 0x06010181 RID: 65921 RVA: 0x004B11C4 File Offset: 0x004AF3C4
	private VisionAssembleView.EOperation GetCurrentOperationState()
	{
		if (this.CurrentSelectedIndex == 999)
		{
			return VisionAssembleView.EOperation.Empty;
		}
		if (this.CurrentSelectedIndex == -1)
		{
			return VisionAssembleView.EOperation.Save;
		}
		int[] visionUniqueIdList = VisionEquipGroupModel.Instance.GetVisionEquipGroupDataByIndex(this.CurrentSelectedIndex).GetVisionUniqueIdList();
		List<int> incrIdList = RoleModel.Instance.GetRoleInstanceById(this.CurrentRoleId).GetPhantomData().GetIncrIdList();
		bool flag = true;
		int[] array = visionUniqueIdList;
		List<int> list = incrIdList;
		int num = (array.Length < list.Count) ? array.Length : list.Count;
		for (int i = 0; i < num; i++)
		{
			if (array[i] != list[i])
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			return VisionAssembleView.EOperation.HasUsing;
		}
		return VisionAssembleView.EOperation.Use;
	}

	// Token: 0x06010182 RID: 65922 RVA: 0x004B1264 File Offset: 0x004AF464
	private void RefreshFunctionButtonState()
	{
		bool state = !this.CompareMode && this.CurrentSelectedIndex != -1 && this.CurrentSelectedIndex != 999;
		this.RefreshDeleteButtonState(state);
		this.RefreshTopButtonState(state);
	}

	// Token: 0x06010183 RID: 65923 RVA: 0x004B12A4 File Offset: 0x004AF4A4
	private void RefreshDeleteButtonState(bool state)
	{
		base.GetButton(12).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06010184 RID: 65924 RVA: 0x004B12CC File Offset: 0x004AF4CC
	private void RefreshTopButtonState(bool state)
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06010185 RID: 65925 RVA: 0x004B12F4 File Offset: 0x004AF4F4
	private void RefreshCurrentSelectDataInfo()
	{
		bool compareMode = this.CompareMode;
		VisionAssembleTopItem currentTopItem = this.CurrentTopItem;
		if (currentTopItem != null)
		{
			currentTopItem.SetActive(compareMode);
		}
		if (compareMode)
		{
			VisionAssembleTopItem currentTopItem2 = this.CurrentTopItem;
			if (currentTopItem2 == null)
			{
				return;
			}
			currentTopItem2.Refresh(this.GetCurrentTopData());
		}
	}

	// Token: 0x06010186 RID: 65926 RVA: 0x004B1334 File Offset: 0x004AF534
	[NullableContext(2)]
	private FilterResultData GetFilterData()
	{
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.UseWayId);
		return FilterModel.Instance.GetFilterResultData(uniqueIdByGroupId);
	}

	// Token: 0x06010187 RID: 65927 RVA: 0x004B1360 File Offset: 0x004AF560
	private bool GetFilterIfHaveSelect()
	{
		FilterResultData filterData = this.GetFilterData();
		if (filterData != null)
		{
			using (Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>.ValueCollection.Enumerator enumerator = filterData.GetSelectRuleData().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Count > 0)
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06010188 RID: 65928 RVA: 0x004B13CC File Offset: 0x004AF5CC
	private void RefreshMiddleEmptyItem()
	{
		bool uiactive = (this.GetFilterIfHaveSelect() && this.GetFilterDataList().Count == 0) || (this.CurrentSelectSuitIndex > 0 && this.GetFilterDataList().Count == 0);
		base.GetItem(18).SetUIActive(uiactive);
	}

	// Token: 0x06010189 RID: 65929 RVA: 0x004B141C File Offset: 0x004AF61C
	[NullableContext(2)]
	private void RefreshAttributeScroller(bool needAnimation = false, Action finishCall = null)
	{
		if (this.CurrentSelectedIndex == 999)
		{
			base.GetScrollViewWithScrollbar(10).RootUIComp.Get().SetUIActive(false);
			base.GetItem(14).SetUIActive(true);
			return;
		}
		bool compareIncIdListIfEmpty = this.GetCompareIncIdListIfEmpty();
		base.GetScrollViewWithScrollbar(10).RootUIComp.Get().SetUIActive(!compareIncIdListIfEmpty);
		base.GetItem(14).SetUIActive(compareIncIdListIfEmpty);
		List<VisionAssembleAttrData> dataList = VisionEquipGroupModel.Instance.GetVisionAssembleViewAttrData(this.CurrentSelectedIndex, this.CompareMode, this.CurrentRoleId);
		GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> attributeLayout = this.AttributeLayout;
		if (attributeLayout == null)
		{
			return;
		}
		attributeLayout.RefreshByData(dataList, delegate
		{
			if (dataList.Count > 0)
			{
				GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> attributeLayout2 = this.AttributeLayout;
				if (attributeLayout2 != null)
				{
					attributeLayout2.ScrollToTop(0);
				}
			}
			Action finishCall2 = finishCall;
			if (finishCall2 != null)
			{
				finishCall2();
			}
			if (needAnimation)
			{
				GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> attributeLayout3 = this.AttributeLayout;
				List<VisionAssembleAttrScrollItem> list = (attributeLayout3 != null) ? attributeLayout3.GetScrollItemList() : null;
				if (list != null)
				{
					foreach (VisionAssembleAttrScrollItem visionAssembleAttrScrollItem in list)
					{
						visionAssembleAttrScrollItem.SetLeftItemAlpha(0f);
					}
				}
				UUIInturnAnimController attributeTurnAniComponentL = this.AttributeTurnAniComponentL;
				if (attributeTurnAniComponentL == null)
				{
					return;
				}
				attributeTurnAniComponentL.Play("", -1, false);
			}
		}, false);
	}

	// Token: 0x0601018A RID: 65930 RVA: 0x004B14F4 File Offset: 0x004AF6F4
	private void RefreshSaveText()
	{
		int count = VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count;
		int phantomEquipGroupCountMax = PhantomBattleConfig.Instance.GetPhantomEquipGroupCountMax();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "VisionAssembleHasSave", new <>z__ReadOnlyArray<object>(new object[]
		{
			count,
			phantomEquipGroupCountMax
		}));
	}

	// Token: 0x0601018B RID: 65931 RVA: 0x004B1550 File Offset: 0x004AF750
	private void TryPlayInfoSequence()
	{
		if (true)
		{
			base.PlaySequence("Start_InfR", null, true);
			UUIInturnAnimController attributeTurnAniComponentR = this.AttributeTurnAniComponentR;
			if (attributeTurnAniComponentR != null)
			{
				attributeTurnAniComponentR.OnFinish.Bind(delegate()
				{
					UUIInturnAnimController attributeTurnAniComponentR3 = this.AttributeTurnAniComponentR;
					if (attributeTurnAniComponentR3 == null)
					{
						return;
					}
					attributeTurnAniComponentR3.SetItemDefaultAlphaZero(false);
				});
			}
			UUIInturnAnimController attributeTurnAniComponentR2 = this.AttributeTurnAniComponentR;
			if (attributeTurnAniComponentR2 == null)
			{
				return;
			}
			attributeTurnAniComponentR2.Play("Start_R", -1, false);
		}
	}

	// Token: 0x0601018C RID: 65932 RVA: 0x004B15A8 File Offset: 0x004AF7A8
	private void RefreshCompareTopData()
	{
		VisionAssembleTopItem compareTopItem = this.CompareTopItem;
		bool? flag = (compareTopItem != null) ? new bool?(compareTopItem.GetActive()) : null;
		bool showState = true;
		VisionAssembleTopItem compareTopItem2 = this.CompareTopItem;
		if (compareTopItem2 != null)
		{
			compareTopItem2.Refresh(this.GetCompareTopData());
		}
		bool? flag2 = flag;
		bool showState2 = showState;
		if (!(flag2.GetValueOrDefault() == showState2 & flag2 != null))
		{
			if (showState)
			{
				VisionAssembleTopItem compareTopItem3 = this.CompareTopItem;
				if (compareTopItem3 != null)
				{
					compareTopItem3.SetActive(showState);
				}
				this.RefreshAttributeScroller(false, null);
				base.PlaySequence("Start_InfR", null, true);
				return;
			}
			base.PlaySequence("Close_InfR", delegate
			{
				VisionAssembleTopItem compareTopItem4 = this.CompareTopItem;
				if (compareTopItem4 != null)
				{
					compareTopItem4.SetActive(showState);
				}
				this.RefreshAttributeScroller(false, null);
			}, true);
		}
	}

	// Token: 0x0601018D RID: 65933 RVA: 0x004B1668 File Offset: 0x004AF868
	private void RefreshCompareToggleState()
	{
		bool uiactive = this.CurrentSelectedIndex != 999 && this.CurrentSelectedIndex != -1;
		UUIExtendToggle extendToggle = base.GetExtendToggle(13);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0601018E RID: 65934 RVA: 0x004B16B4 File Offset: 0x004AF8B4
	private bool GetCompareIncIdListIfEmpty()
	{
		if (this.CurrentSelectedIndex == 999)
		{
			return true;
		}
		if (this.CurrentSelectedIndex == -1)
		{
			using (List<int>.Enumerator enumerator = RoleModel.Instance.GetRoleDataById(this.CurrentRoleId, true).GetPhantomData().GetIncrIdList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != 0)
					{
						return false;
					}
				}
				return true;
			}
		}
		int[] visionUniqueIdList = VisionEquipGroupModel.Instance.GetVisionEquipGroupDataByIndex(this.CurrentSelectedIndex).GetVisionUniqueIdList();
		for (int i = 0; i < visionUniqueIdList.Length; i++)
		{
			if (visionUniqueIdList[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601018F RID: 65935 RVA: 0x004B1760 File Offset: 0x004AF960
	[NullableContext(2)]
	private VisionAssembleTopData GetCompareTopData()
	{
		if (this.CurrentSelectedIndex == 999)
		{
			return null;
		}
		List<int> list = new List<int>();
		VisionAssembleTopData visionAssembleTopData = new VisionAssembleTopData();
		if (this.CurrentSelectedIndex == -1)
		{
			visionAssembleTopData.Name = ConfigMultiTextLang.GetLocalTextNew("VisionAssembleCurrentEquip", null);
			list = new List<int>(RoleModel.Instance.GetRoleDataById(this.CurrentRoleId, true).GetPhantomData().GetIncrIdList());
		}
		else
		{
			VisionEquipGroupData visionEquipGroupDataByIndex = VisionEquipGroupModel.Instance.GetVisionEquipGroupDataByIndex(this.CurrentSelectedIndex);
			visionAssembleTopData.Name = visionEquipGroupDataByIndex.GetName();
			list = new List<int>(visionEquipGroupDataByIndex.GetVisionUniqueIdList());
		}
		visionAssembleTopData.Index = ((this.CurrentSelectedIndex == -1) ? -1 : this.CurrentSelectedIndex);
		int num = 0;
		List<VisionFetterData> list2 = this.FilterSameFetterData(VisionEquipGroupModel.Instance.GetVisionFetterDataByIncIdList(list));
		foreach (int uniqueId in list)
		{
			PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
			if (phantomDataBase != null)
			{
				num += phantomDataBase.GetCost();
			}
		}
		visionAssembleTopData.Cost = num;
		List<VisionAssembleSuitItemData> list3 = new List<VisionAssembleSuitItemData>();
		foreach (VisionFetterData data in list2)
		{
			VisionAssembleSuitItemData visionAssembleSuitItemData = new VisionAssembleSuitItemData();
			visionAssembleSuitItemData.Phrase(data);
			list3.Add(visionAssembleSuitItemData);
		}
		visionAssembleTopData.SuitList = list3;
		return visionAssembleTopData;
	}

	// Token: 0x06010190 RID: 65936 RVA: 0x004B18E0 File Offset: 0x004AFAE0
	private VisionAssembleTopData GetCurrentTopData()
	{
		VisionAssembleTopData visionAssembleTopData = new VisionAssembleTopData();
		visionAssembleTopData.Name = ConfigMultiTextLang.GetLocalTextNew("VisionAssembleCurrentEquip", null);
		visionAssembleTopData.Index = -1;
		int num = 0;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.CurrentRoleId, true);
		foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in roleDataById.GetPhantomData().GetDataMap())
		{
			PhantomDataBase value = keyValuePair.Value;
			if (value != null)
			{
				num += value.GetCost();
			}
		}
		visionAssembleTopData.Cost = num;
		List<int> incrIdList = roleDataById.GetPhantomData().GetIncrIdList();
		List<VisionFetterData> list = this.FilterSameFetterData(VisionEquipGroupModel.Instance.GetVisionFetterDataByIncIdList(new List<int>(incrIdList)));
		List<VisionAssembleSuitItemData> list2 = new List<VisionAssembleSuitItemData>();
		foreach (VisionFetterData data in list)
		{
			VisionAssembleSuitItemData visionAssembleSuitItemData = new VisionAssembleSuitItemData();
			visionAssembleSuitItemData.Phrase(data);
			list2.Add(visionAssembleSuitItemData);
		}
		visionAssembleTopData.SuitList = list2;
		return visionAssembleTopData;
	}

	// Token: 0x06010191 RID: 65937 RVA: 0x004B1A08 File Offset: 0x004AFC08
	private List<VisionFetterData> FilterSameFetterData(List<VisionFetterData> dataList)
	{
		List<VisionFetterData> list = new List<VisionFetterData>();
		Dictionary<int, VisionFetterData> dictionary = new Dictionary<int, VisionFetterData>();
		foreach (VisionFetterData visionFetterData in dataList)
		{
			dictionary[visionFetterData.FetterGroupId] = visionFetterData;
		}
		foreach (VisionFetterData item in dictionary.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x04008EBD RID: 36541
	private const int EMPTYSELECTINDEX = 999;

	// Token: 0x04008EBE RID: 36542
	private const int STATICINDEX = -1;

	// Token: 0x04008EBF RID: 36543
	private readonly EFilterSortGroupId UseWayId = EFilterSortGroupId.VisionAssemble;

	// Token: 0x04008EC0 RID: 36544
	private List<int> CurrentShowingGroupList = new List<int>();

	// Token: 0x04008EC1 RID: 36545
	private int CurrentRoleId;

	// Token: 0x04008EC2 RID: 36546
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008EC3 RID: 36547
	[Nullable(2)]
	private VisionAssembleStaticItem StaticItem;

	// Token: 0x04008EC4 RID: 36548
	[Nullable(2)]
	private VisionAssembleTopItem CompareTopItem;

	// Token: 0x04008EC5 RID: 36549
	[Nullable(2)]
	private VisionAssembleTopItem CurrentTopItem;

	// Token: 0x04008EC6 RID: 36550
	[Nullable(2)]
	private FilterEntrance<int> FilterEntrance;

	// Token: 0x04008EC7 RID: 36551
	private readonly List<int> FetterSuitFilterArray = new List<int>();

	// Token: 0x04008EC8 RID: 36552
	private int CurrentSelectSuitIndex;

	// Token: 0x04008EC9 RID: 36553
	[Nullable(2)]
	private CommonDropDown<int, int> CommonDropDown;

	// Token: 0x04008ECA RID: 36554
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> AttributeLayout;

	// Token: 0x04008ECB RID: 36555
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<VisionAssembleScrollItem, VisionAssembleScrollItemData> AssembleListLayout;

	// Token: 0x04008ECC RID: 36556
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x04008ECD RID: 36557
	private int CurrentSelectedIndex = 999;

	// Token: 0x04008ECE RID: 36558
	private bool CompareMode;

	// Token: 0x04008ECF RID: 36559
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentR;

	// Token: 0x04008ED0 RID: 36560
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentL;

	// Token: 0x04008ED1 RID: 36561
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<VisionAssembleScrollItemData> ShowList;

	// Token: 0x02007B96 RID: 31638
	[NullableContext(0)]
	private enum EOperation
	{
		// Token: 0x0402806C RID: 163948
		Empty,
		// Token: 0x0402806D RID: 163949
		Save,
		// Token: 0x0402806E RID: 163950
		Use,
		// Token: 0x0402806F RID: 163951
		HasUsing
	}

	// Token: 0x02007B97 RID: 31639
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04028071 RID: 163953
		CaptionItem,
		// Token: 0x04028072 RID: 163954
		CurrentSuitItem,
		// Token: 0x04028073 RID: 163955
		SuitScroller,
		// Token: 0x04028074 RID: 163956
		SuitItem,
		// Token: 0x04028075 RID: 163957
		LeftDownItem,
		// Token: 0x04028076 RID: 163958
		FilterItem,
		// Token: 0x04028077 RID: 163959
		SuitFilterItem,
		// Token: 0x04028078 RID: 163960
		CurrentSaveText,
		// Token: 0x04028079 RID: 163961
		CurrentInfoItem,
		// Token: 0x0402807A RID: 163962
		CompareInfoItem,
		// Token: 0x0402807B RID: 163963
		AttributeScroller,
		// Token: 0x0402807C RID: 163964
		ToTopBtn,
		// Token: 0x0402807D RID: 163965
		DeleteBtn,
		// Token: 0x0402807E RID: 163966
		CompareToggle,
		// Token: 0x0402807F RID: 163967
		EmptyItem,
		// Token: 0x04028080 RID: 163968
		ConfirmButtonItem,
		// Token: 0x04028081 RID: 163969
		TextureMaskItem,
		// Token: 0x04028082 RID: 163970
		CompareMask,
		// Token: 0x04028083 RID: 163971
		MiddleEmptyItem,
		// Token: 0x04028084 RID: 163972
		TurnAnimationItem
	}
}
