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

// Token: 0x02002491 RID: 9361
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleView : UiViewBase
{
	// Token: 0x06012C92 RID: 76946 RVA: 0x004A25E0 File Offset: 0x004A07E0
	public VisionAssembleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012C93 RID: 76947 RVA: 0x004A2614 File Offset: 0x004A0814
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

	// Token: 0x06012C94 RID: 76948 RVA: 0x004A2878 File Offset: 0x004A0A78
	protected override UniTask OnCreateAsync()
	{
		VisionAssembleView.<OnCreateAsync>d__25 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<VisionAssembleView.<OnCreateAsync>d__25>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C95 RID: 76949 RVA: 0x004A28B4 File Offset: 0x004A0AB4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataUpdate, new Action(this.OnVisionGroupDataUpdate));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataAdd, new Action(this.OnVisionGroupDataAdd));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataDelete, new Action(this.OnVisionGroupDataDelete));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataToTop, new Action(this.OnVisionGroupDataToTop));
		EventSystem.Instance.Add(EEventName.OnVisionGroupDataChangeName, new Action(this.OnVisionGroupDataChangeName));
		EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
	}

	// Token: 0x06012C96 RID: 76950 RVA: 0x004A296C File Offset: 0x004A0B6C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataUpdate, new Action(this.OnVisionGroupDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataAdd, new Action(this.OnVisionGroupDataAdd));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataDelete, new Action(this.OnVisionGroupDataDelete));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataToTop, new Action(this.OnVisionGroupDataToTop));
		EventSystem.Instance.Remove(EEventName.OnVisionGroupDataChangeName, new Action(this.OnVisionGroupDataChangeName));
		EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(this.OnPhantomEquip));
	}

	// Token: 0x06012C97 RID: 76951 RVA: 0x004A2A24 File Offset: 0x004A0C24
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C98 RID: 76952 RVA: 0x004A2A68 File Offset: 0x004A0C68
	private UniTask InitDropDown()
	{
		VisionAssembleView.<InitDropDown>d__29 <InitDropDown>d__;
		<InitDropDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDropDown>d__.<>4__this = this;
		<InitDropDown>d__.<>1__state = -1;
		<InitDropDown>d__.<>t__builder.Start<VisionAssembleView.<InitDropDown>d__29>(ref <InitDropDown>d__);
		return <InitDropDown>d__.<>t__builder.Task;
	}

	// Token: 0x06012C99 RID: 76953 RVA: 0x004A2AAB File Offset: 0x004A0CAB
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

	// Token: 0x06012C9A RID: 76954 RVA: 0x004A2AE4 File Offset: 0x004A0CE4
	private void OnVisionGroupDataUpdate()
	{
		int count = VisionEquipGroupModel.Instance.GetVisionEquipGroupList().Count;
		if (this.CurrentSelectedIndex != 999 && this.CurrentSelectedIndex != -1 && this.CurrentSelectedIndex >= count)
		{
			this.CurrentSelectedIndex = ((count > 0) ? 0 : -1);
		}
		this.RefreshViewAfterChangeGroupData();
	}

	// Token: 0x06012C9B RID: 76955 RVA: 0x004A2B34 File Offset: 0x004A0D34
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

	// Token: 0x06012C9C RID: 76956 RVA: 0x004A2B9C File Offset: 0x004A0D9C
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

	// Token: 0x06012C9D RID: 76957 RVA: 0x004A2BC6 File Offset: 0x004A0DC6
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

	// Token: 0x06012C9E RID: 76958 RVA: 0x004A2C01 File Offset: 0x004A0E01
	private void OnVisionGroupDataChangeName()
	{
		this.RefreshCompareTopData();
		this.RefreshCurrentSelectDataInfo();
		this.RefreshScroller(true, false);
	}

	// Token: 0x06012C9F RID: 76959 RVA: 0x004A2C17 File Offset: 0x004A0E17
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

	// Token: 0x06012CA0 RID: 76960 RVA: 0x004A2C47 File Offset: 0x004A0E47
	private int GetDropDownTextId(int data)
	{
		return data;
	}

	// Token: 0x06012CA1 RID: 76961 RVA: 0x004A2C4A File Offset: 0x004A0E4A
	private void OnDropDownSelectCall(int index, int data)
	{
		this.CurrentSelectSuitIndex = index;
		this.UpdateFilterComponent();
	}

	// Token: 0x06012CA2 RID: 76962 RVA: 0x004A2C59 File Offset: 0x004A0E59
	private VisionAssembleDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
	{
		return new VisionAssembleDropDownItem(uiItem);
	}

	// Token: 0x06012CA3 RID: 76963 RVA: 0x004A2C61 File Offset: 0x004A0E61
	private VisionEquipmentDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new VisionEquipmentDropDownTitleItem(uiItem);
	}

	// Token: 0x06012CA4 RID: 76964 RVA: 0x004A2C6C File Offset: 0x004A0E6C
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

	// Token: 0x06012CA5 RID: 76965 RVA: 0x004A2D24 File Offset: 0x004A0F24
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

	// Token: 0x06012CA6 RID: 76966 RVA: 0x004A2D9B File Offset: 0x004A0F9B
	private bool CancelCompareMode()
	{
		if (!this.CompareMode)
		{
			return false;
		}
		this.OnCompareToggle(EToggleState.ETT_Checked);
		return true;
	}

	// Token: 0x06012CA7 RID: 76967 RVA: 0x004A2DB0 File Offset: 0x004A0FB0
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

	// Token: 0x06012CA8 RID: 76968 RVA: 0x004A2DE6 File Offset: 0x004A0FE6
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

	// Token: 0x06012CA9 RID: 76969 RVA: 0x004A2E28 File Offset: 0x004A1028
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

	// Token: 0x06012CAA RID: 76970 RVA: 0x004A2E74 File Offset: 0x004A1074
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

	// Token: 0x06012CAB RID: 76971 RVA: 0x004A2F74 File Offset: 0x004A1174
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

	// Token: 0x06012CAC RID: 76972 RVA: 0x004A3020 File Offset: 0x004A1220
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

	// Token: 0x06012CAD RID: 76973 RVA: 0x004A3098 File Offset: 0x004A1298
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

	// Token: 0x06012CAE RID: 76974 RVA: 0x004A311B File Offset: 0x004A131B
	private void OnClickedNotShowConfirm(bool toggleState)
	{
		VisionEquipGroupModel.Instance.SaveLocalTopTipState(toggleState);
	}

	// Token: 0x06012CAF RID: 76975 RVA: 0x004A3128 File Offset: 0x004A1328
	private void OnClickDeleteBtn()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.VisionGroupDelete);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			VisionEquipGroupController.Instance.RequestDeleteVisionEquipGroup(this.CurrentSelectedIndex);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06012CB0 RID: 76976 RVA: 0x004A3164 File Offset: 0x004A1364
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

	// Token: 0x06012CB1 RID: 76977 RVA: 0x004A31EC File Offset: 0x004A13EC
	private VisionAssembleScrollItem InitAssembleItem()
	{
		return new VisionAssembleScrollItem();
	}

	// Token: 0x06012CB2 RID: 76978 RVA: 0x004A31F3 File Offset: 0x004A13F3
	private VisionAssembleAttrScrollItem InitItem()
	{
		return new VisionAssembleAttrScrollItem();
	}

	// Token: 0x06012CB3 RID: 76979 RVA: 0x004A31FC File Offset: 0x004A13FC
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

	// Token: 0x06012CB4 RID: 76980 RVA: 0x004A324E File Offset: 0x004A144E
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012CB5 RID: 76981 RVA: 0x004A3258 File Offset: 0x004A1458
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

	// Token: 0x06012CB6 RID: 76982 RVA: 0x004A32D0 File Offset: 0x004A14D0
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

	// Token: 0x06012CB7 RID: 76983 RVA: 0x004A331F File Offset: 0x004A151F
	private void RefreshCurrentSuitInfo()
	{
		VisionAssembleStaticItem staticItem = this.StaticItem;
		if (staticItem == null)
		{
			return;
		}
		staticItem.Refresh(this.CurrentRoleId);
	}

	// Token: 0x06012CB8 RID: 76984 RVA: 0x004A3338 File Offset: 0x004A1538
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

	// Token: 0x06012CB9 RID: 76985 RVA: 0x004A3458 File Offset: 0x004A1658
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

	// Token: 0x06012CBA RID: 76986 RVA: 0x004A35A8 File Offset: 0x004A17A8
	private bool CheckIfCanSelect()
	{
		return true;
	}

	// Token: 0x06012CBB RID: 76987 RVA: 0x004A35AB File Offset: 0x004A17AB
	private void RefreshStaticItemSelectState()
	{
		VisionAssembleStaticItem staticItem = this.StaticItem;
		if (staticItem == null)
		{
			return;
		}
		staticItem.RefreshSelectState(this.CurrentSelectedIndex == -1, this.CompareMode);
	}

	// Token: 0x06012CBC RID: 76988 RVA: 0x004A35CC File Offset: 0x004A17CC
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

	// Token: 0x06012CBD RID: 76989 RVA: 0x004A3617 File Offset: 0x004A1817
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

	// Token: 0x06012CBE RID: 76990 RVA: 0x004A3654 File Offset: 0x004A1854
	private void RefreshOperationFunctionState()
	{
		VisionAssembleView.EOperation currentOperationState = this.GetCurrentOperationState();
		this.RefreshUseButtonByOperationState(currentOperationState);
	}

	// Token: 0x06012CBF RID: 76991 RVA: 0x004A3670 File Offset: 0x004A1870
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

	// Token: 0x06012CC0 RID: 76992 RVA: 0x004A36D4 File Offset: 0x004A18D4
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

	// Token: 0x06012CC1 RID: 76993 RVA: 0x004A3774 File Offset: 0x004A1974
	private void RefreshFunctionButtonState()
	{
		bool state = !this.CompareMode && this.CurrentSelectedIndex != -1 && this.CurrentSelectedIndex != 999;
		this.RefreshDeleteButtonState(state);
		this.RefreshTopButtonState(state);
	}

	// Token: 0x06012CC2 RID: 76994 RVA: 0x004A37B4 File Offset: 0x004A19B4
	private void RefreshDeleteButtonState(bool state)
	{
		base.GetButton(12).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06012CC3 RID: 76995 RVA: 0x004A37DC File Offset: 0x004A19DC
	private void RefreshTopButtonState(bool state)
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06012CC4 RID: 76996 RVA: 0x004A3804 File Offset: 0x004A1A04
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

	// Token: 0x06012CC5 RID: 76997 RVA: 0x004A3844 File Offset: 0x004A1A44
	[NullableContext(2)]
	private FilterResultData GetFilterData()
	{
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.UseWayId);
		return FilterModel.Instance.GetFilterResultData(uniqueIdByGroupId);
	}

	// Token: 0x06012CC6 RID: 76998 RVA: 0x004A3870 File Offset: 0x004A1A70
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

	// Token: 0x06012CC7 RID: 76999 RVA: 0x004A38DC File Offset: 0x004A1ADC
	private void RefreshMiddleEmptyItem()
	{
		bool uiactive = (this.GetFilterIfHaveSelect() && this.GetFilterDataList().Count == 0) || (this.CurrentSelectSuitIndex > 0 && this.GetFilterDataList().Count == 0);
		base.GetItem(18).SetUIActive(uiactive);
	}

	// Token: 0x06012CC8 RID: 77000 RVA: 0x004A392C File Offset: 0x004A1B2C
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

	// Token: 0x06012CC9 RID: 77001 RVA: 0x004A3A04 File Offset: 0x004A1C04
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

	// Token: 0x06012CCA RID: 77002 RVA: 0x004A3A60 File Offset: 0x004A1C60
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

	// Token: 0x06012CCB RID: 77003 RVA: 0x004A3AB8 File Offset: 0x004A1CB8
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

	// Token: 0x06012CCC RID: 77004 RVA: 0x004A3B78 File Offset: 0x004A1D78
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

	// Token: 0x06012CCD RID: 77005 RVA: 0x004A3BC4 File Offset: 0x004A1DC4
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

	// Token: 0x06012CCE RID: 77006 RVA: 0x004A3C70 File Offset: 0x004A1E70
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

	// Token: 0x06012CCF RID: 77007 RVA: 0x004A3DF0 File Offset: 0x004A1FF0
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

	// Token: 0x06012CD0 RID: 77008 RVA: 0x004A3F18 File Offset: 0x004A2118
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

	// Token: 0x04008D74 RID: 36212
	private const int EMPTYSELECTINDEX = 999;

	// Token: 0x04008D75 RID: 36213
	private const int STATICINDEX = -1;

	// Token: 0x04008D76 RID: 36214
	private readonly EFilterSortGroupId UseWayId = EFilterSortGroupId.VisionAssemble;

	// Token: 0x04008D77 RID: 36215
	private List<int> CurrentShowingGroupList = new List<int>();

	// Token: 0x04008D78 RID: 36216
	private int CurrentRoleId;

	// Token: 0x04008D79 RID: 36217
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008D7A RID: 36218
	[Nullable(2)]
	private VisionAssembleStaticItem StaticItem;

	// Token: 0x04008D7B RID: 36219
	[Nullable(2)]
	private VisionAssembleTopItem CompareTopItem;

	// Token: 0x04008D7C RID: 36220
	[Nullable(2)]
	private VisionAssembleTopItem CurrentTopItem;

	// Token: 0x04008D7D RID: 36221
	[Nullable(2)]
	private FilterEntrance<int> FilterEntrance;

	// Token: 0x04008D7E RID: 36222
	private readonly List<int> FetterSuitFilterArray = new List<int>();

	// Token: 0x04008D7F RID: 36223
	private int CurrentSelectSuitIndex;

	// Token: 0x04008D80 RID: 36224
	[Nullable(2)]
	private CommonDropDown<int, int> CommonDropDown;

	// Token: 0x04008D81 RID: 36225
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<VisionAssembleAttrScrollItem, VisionAssembleAttrData> AttributeLayout;

	// Token: 0x04008D82 RID: 36226
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<VisionAssembleScrollItem, VisionAssembleScrollItemData> AssembleListLayout;

	// Token: 0x04008D83 RID: 36227
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x04008D84 RID: 36228
	private int CurrentSelectedIndex = 999;

	// Token: 0x04008D85 RID: 36229
	private bool CompareMode;

	// Token: 0x04008D86 RID: 36230
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentR;

	// Token: 0x04008D87 RID: 36231
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentL;

	// Token: 0x04008D88 RID: 36232
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<VisionAssembleScrollItemData> ShowList;

	// Token: 0x02008A0C RID: 35340
	[NullableContext(0)]
	private enum EOperation
	{
		// Token: 0x0402CD4C RID: 183628
		Empty,
		// Token: 0x0402CD4D RID: 183629
		Save,
		// Token: 0x0402CD4E RID: 183630
		Use,
		// Token: 0x0402CD4F RID: 183631
		HasUsing
	}

	// Token: 0x02008A0D RID: 35341
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CD51 RID: 183633
		CaptionItem,
		// Token: 0x0402CD52 RID: 183634
		CurrentSuitItem,
		// Token: 0x0402CD53 RID: 183635
		SuitScroller,
		// Token: 0x0402CD54 RID: 183636
		SuitItem,
		// Token: 0x0402CD55 RID: 183637
		LeftDownItem,
		// Token: 0x0402CD56 RID: 183638
		FilterItem,
		// Token: 0x0402CD57 RID: 183639
		SuitFilterItem,
		// Token: 0x0402CD58 RID: 183640
		CurrentSaveText,
		// Token: 0x0402CD59 RID: 183641
		CurrentInfoItem,
		// Token: 0x0402CD5A RID: 183642
		CompareInfoItem,
		// Token: 0x0402CD5B RID: 183643
		AttributeScroller,
		// Token: 0x0402CD5C RID: 183644
		ToTopBtn,
		// Token: 0x0402CD5D RID: 183645
		DeleteBtn,
		// Token: 0x0402CD5E RID: 183646
		CompareToggle,
		// Token: 0x0402CD5F RID: 183647
		EmptyItem,
		// Token: 0x0402CD60 RID: 183648
		ConfirmButtonItem,
		// Token: 0x0402CD61 RID: 183649
		TextureMaskItem,
		// Token: 0x0402CD62 RID: 183650
		CompareMask,
		// Token: 0x0402CD63 RID: 183651
		MiddleEmptyItem,
		// Token: 0x0402CD64 RID: 183652
		TurnAnimationItem
	}
}
