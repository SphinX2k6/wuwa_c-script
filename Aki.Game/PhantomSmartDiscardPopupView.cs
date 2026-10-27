using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FE2 RID: 8162
[NullableContext(1)]
[Nullable(0)]
public class PhantomSmartDiscardPopupView : UiViewBase
{
	// Token: 0x0600FFCC RID: 65484 RVA: 0x003E4A6B File Offset: 0x003E2C6B
	public PhantomSmartDiscardPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FFCD RID: 65485 RVA: 0x003E4A98 File Offset: 0x003E2C98
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickHelpBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickChoose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleUserFilter));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleRecommendFilter));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FFCE RID: 65486 RVA: 0x003E4C70 File Offset: 0x003E2E70
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomSmartDiscardPopupView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomSmartDiscardPopupView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FFCF RID: 65487 RVA: 0x003E4CB3 File Offset: 0x003E2EB3
	protected override void OnBeforeShow()
	{
		this.InitPlanList();
		this.UpdateUserFilterToggleInteractive();
		this.UpdateDiscardFilter();
	}

	// Token: 0x0600FFD0 RID: 65488 RVA: 0x003E4CC8 File Offset: 0x003E2EC8
	private void UpdateDiscardFilter()
	{
		this.DiscardPhantomList = this.CalculateDiscardList();
		int count = this.DiscardPhantomList.Count;
		int stackUnitCountByDataList = PhantomStackUtil.GetStackUnitCountByDataList(this.DiscardPhantomList);
		UUIText text = base.GetText(5);
		LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_1413403477_Text", new <>z__ReadOnlySingleElementList<object>(stackUnitCountByDataList));
		base.GetButton(6).SetSelfInteractive(count > 0);
	}

	// Token: 0x0600FFD1 RID: 65489 RVA: 0x003E4D2C File Offset: 0x003E2F2C
	private void InitPlanList()
	{
		this.DiscardPhantomRecommendList = this.ConfigData.GetPhantomSmartDiscardRecommendPlan();
		this.DiscardPhantomUserPlanList = this.ConfigData.GetPhantomSmartDiscardUserPlan();
	}

	// Token: 0x0600FFD2 RID: 65490 RVA: 0x003E4D50 File Offset: 0x003E2F50
	private void UpdateUserFilterToggleInteractive()
	{
		Dictionary<int, bool> isUsingMap = this.ConfigData.IsUsingMap;
		bool flag = false;
		foreach (KeyValuePair<int, bool> keyValuePair in isUsingMap)
		{
			if (keyValuePair.Value)
			{
				flag = true;
				break;
			}
		}
		this.HasUserOnPlan = flag;
		this.ActivatePanel.SetUiActive(!flag);
		if (!flag)
		{
			this.UseUserFilter = false;
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600FFD3 RID: 65491 RVA: 0x003E4DE8 File Offset: 0x003E2FE8
	private List<PhantomItemData> CalculateDiscardList()
	{
		HashSet<PhantomItemData> hashSet = new HashSet<PhantomItemData>();
		if (this.UseRecommendFilter)
		{
			foreach (PhantomItemData item in this.DiscardPhantomRecommendList)
			{
				hashSet.Add(item);
			}
		}
		if (this.UseUserFilter)
		{
			foreach (PhantomItemData item2 in this.DiscardPhantomUserPlanList)
			{
				hashSet.Add(item2);
			}
		}
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItemData item3 in hashSet)
		{
			list.Add(item3);
		}
		return list;
	}

	// Token: 0x0600FFD4 RID: 65492 RVA: 0x003E4EE0 File Offset: 0x003E30E0
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(532);
	}

	// Token: 0x0600FFD5 RID: 65493 RVA: 0x003E4EF4 File Offset: 0x003E30F4
	private void OnClickChoose()
	{
		HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.PhantomDiscardPlanRecycleSet, null);
		if (player == null || !player.Contains(2))
		{
			HashSet<int> hashSet = player ?? new HashSet<int>();
			hashSet.Add(2);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.PhantomDiscardPlanRecycleSet, hashSet);
			PhantomDiscardPlanSmartDiscardReport phantomDiscardPlanSmartDiscardReport = new PhantomDiscardPlanSmartDiscardReport();
			phantomDiscardPlanSmartDiscardReport.i_type = 2;
			LogReportController.Instance.LogReport(phantomDiscardPlanSmartDiscardReport);
		}
		InventoryController.Instance.OpenManageConfigNewView();
	}

	// Token: 0x0600FFD6 RID: 65494 RVA: 0x003E4F5C File Offset: 0x003E315C
	private void OnToggleUserFilter(EToggleState state)
	{
		bool flag = FunctionModel.Instance.IsOpen(10096);
		if (!flag || !this.HasUserOnPlan)
		{
			string textId = flag ? "PrefabTextItem_18455432_Text" : "PhantomManagementLocked_Tips";
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
			return;
		}
		this.UseUserFilter = (state == EToggleState.ETT_Checked);
		this.UpdateDiscardFilter();
		HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.PhantomDiscardPlanRecycleSet, null);
		if (player == null || !player.Contains(3))
		{
			HashSet<int> hashSet = player ?? new HashSet<int>();
			hashSet.Add(3);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.PhantomDiscardPlanRecycleSet, hashSet);
			PhantomDiscardPlanSmartDiscardReport phantomDiscardPlanSmartDiscardReport = new PhantomDiscardPlanSmartDiscardReport();
			phantomDiscardPlanSmartDiscardReport.i_type = 3;
			LogReportController.Instance.LogReport(phantomDiscardPlanSmartDiscardReport);
		}
	}

	// Token: 0x0600FFD7 RID: 65495 RVA: 0x003E5020 File Offset: 0x003E3220
	private void OnToggleRecommendFilter(EToggleState state)
	{
		HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.PhantomDiscardPlanRecycleSet, null);
		if (player == null || !player.Contains(1))
		{
			HashSet<int> hashSet = player ?? new HashSet<int>();
			hashSet.Add(1);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.PhantomDiscardPlanRecycleSet, hashSet);
			PhantomDiscardPlanSmartDiscardReport phantomDiscardPlanSmartDiscardReport = new PhantomDiscardPlanSmartDiscardReport();
			phantomDiscardPlanSmartDiscardReport.i_type = 1;
			LogReportController.Instance.LogReport(phantomDiscardPlanSmartDiscardReport);
		}
		this.UseRecommendFilter = (state == EToggleState.ETT_Checked);
		this.UpdateDiscardFilter();
	}

	// Token: 0x0600FFD8 RID: 65496 RVA: 0x003E508C File Offset: 0x003E328C
	private void OnClickConfirmBtn()
	{
		if (this.DiscardPhantomList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("NoPhantomDiscarded_Tips", Array.Empty<object>());
			return;
		}
		this.ShowConfirmPopup();
	}

	// Token: 0x0600FFD9 RID: 65497 RVA: 0x003E50B8 File Offset: 0x003E32B8
	private void ShowConfirmPopup()
	{
		PhantomDiscardPlanSmartDiscardConfirmReport logData = new PhantomDiscardPlanSmartDiscardConfirmReport();
		List<int> list = new List<int>();
		foreach (PhantomItemData phantomItemData in this.DiscardPhantomList)
		{
			list.Add(phantomItemData.GetUniqueId());
		}
		Action<bool> <>9__2;
		PhantomConfirmPopupViewData param = new PhantomConfirmPopupViewData
		{
			Title = "PhantomFilterDiscardConfirmTitle",
			SubTitle = "PhantomFilterDiscardDisplayTips",
			PhantomUniqueIdList = list,
			OnMiddle = delegate
			{
				logData.i_type = 1;
				LogReportController.Instance.LogReport(logData);
				this.ExecuteBatchDiscard();
			},
			OnRight = delegate
			{
				logData.i_type = 2;
				LogReportController.Instance.LogReport(logData);
				List<int> list2 = new List<int>();
				foreach (PhantomItemData phantomItemData2 in this.DiscardPhantomList)
				{
					list2.Add(phantomItemData2.GetUniqueId());
				}
				UniTask<bool> task = InventoryController.Instance.ShowPhantomDiscardFusionTip(list2.ToArray());
				Action<bool> continuationFunction;
				if ((continuationFunction = <>9__2) == null)
				{
					continuationFunction = (<>9__2 = delegate(bool value)
					{
						if (value)
						{
							ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Warning07", Array.Empty<object>());
							this.CloseMe(null);
						}
					});
				}
				task.ContinueWith(continuationFunction);
			},
			MiddleTxtKey = "PhantomFilterButtonText_Confirm",
			RightTxtKey = "PhantomFilterButtonText_Merge"
		};
		UiManager.Instance.OpenView(EUiViewName.PhantomBatchConfirmPopupView, param, null);
	}

	// Token: 0x0600FFDA RID: 65498 RVA: 0x003E51A0 File Offset: 0x003E33A0
	private UniTask ExecuteBatchDiscard()
	{
		PhantomSmartDiscardPopupView.<ExecuteBatchDiscard>d__25 <ExecuteBatchDiscard>d__;
		<ExecuteBatchDiscard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteBatchDiscard>d__.<>4__this = this;
		<ExecuteBatchDiscard>d__.<>1__state = -1;
		<ExecuteBatchDiscard>d__.<>t__builder.Start<PhantomSmartDiscardPopupView.<ExecuteBatchDiscard>d__25>(ref <ExecuteBatchDiscard>d__);
		return <ExecuteBatchDiscard>d__.<>t__builder.Task;
	}

	// Token: 0x04007655 RID: 30293
	private const int HELP_ID = 532;

	// Token: 0x04007656 RID: 30294
	[Nullable(2)]
	private IPhantomSmartDiscardViewData ViewData;

	// Token: 0x04007657 RID: 30295
	protected PhantomManagerConfigData ConfigData;

	// Token: 0x04007658 RID: 30296
	private bool UseUserFilter;

	// Token: 0x04007659 RID: 30297
	private bool UseRecommendFilter;

	// Token: 0x0400765A RID: 30298
	private List<PhantomItemData> DiscardPhantomRecommendList = new List<PhantomItemData>();

	// Token: 0x0400765B RID: 30299
	private List<PhantomItemData> DiscardPhantomUserPlanList = new List<PhantomItemData>();

	// Token: 0x0400765C RID: 30300
	private List<PhantomItemData> DiscardPhantomList = new List<PhantomItemData>();

	// Token: 0x0400765D RID: 30301
	private bool HasUserOnPlan;

	// Token: 0x0400765E RID: 30302
	private PhantomSmartDiscardPopupActivatePanel ActivatePanel;

	// Token: 0x020085F3 RID: 34291
	[NullableContext(0)]
	private enum EPhantomSmartDiscardComp
	{
		// Token: 0x0402B991 RID: 178577
		BtnHelpInfo,
		// Token: 0x0402B992 RID: 178578
		TogRecommendFilter,
		// Token: 0x0402B993 RID: 178579
		BtnChoose,
		// Token: 0x0402B994 RID: 178580
		TogUserFilter,
		// Token: 0x0402B995 RID: 178581
		PanelEmptyTips,
		// Token: 0x0402B996 RID: 178582
		TxtDiscardNumber,
		// Token: 0x0402B997 RID: 178583
		BtnConfirmA
	}
}
