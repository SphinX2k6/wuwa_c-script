using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000B21 RID: 2849
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsMissionView : UiViewBase
{
	// Token: 0x06007589 RID: 30089 RVA: 0x00244BE2 File Offset: 0x00242DE2
	public WuWuLogisticsMissionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600758A RID: 30090 RVA: 0x00244BF4 File Offset: 0x00242DF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUISprite)),
			new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout))
		};
	}

	// Token: 0x0600758B RID: 30091 RVA: 0x00244D30 File Offset: 0x00242F30
	protected override UniTask OnBeforeStartAsync()
	{
		WuWuLogisticsMissionView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WuWuLogisticsMissionView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600758C RID: 30092 RVA: 0x00244D74 File Offset: 0x00242F74
	protected override void OnStart()
	{
		this.InitCaption();
		this.PackLayout = new GenericLayout<WuWuLogisticsPackItem, int>(base.GetVerticalLayout(1), new Func<WuWuLogisticsPackItem>(this.InitPackItem), null, false, true);
		this.MissionScrollView = new GenericScrollViewNew<WuWuLogisticsMissionItem, int>(base.GetScrollViewWithScrollbar(4), new Func<WuWuLogisticsMissionItem>(this.InitMissionItem), null, false, null);
		this.LogisiticsInfoScrollView = new GenericScrollViewNew<WuWuLogisticsInfoItem, IWuWuLogisticsInfoItemData>(base.GetScrollViewWithScrollbar(7), new Func<WuWuLogisticsInfoItem>(this.InitInfoItem), null, false, null);
		this.AnimationController = (base.GetVerticalLayout(12).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
	}

	// Token: 0x0600758D RID: 30093 RVA: 0x00244E34 File Offset: 0x00243034
	protected override void OnBeforeShow()
	{
		this.Data = WuWuLogisticsActivityController.Instance.GetActivityData();
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			WuWuLogisticsActivityData data = this.Data;
			captionItem.SetTitle((data != null) ? data.GetTitle() : null);
		}
		WuWuLogisticsActivityData data2 = this.Data;
		this.CurSelectedPackCfgId = ((data2 != null) ? data2.GetDefaultOpenPackCfgId() : 0);
		this.UpdateCurSelectedContent();
		WuWuLogisticsActivityData data3 = this.Data;
		if (data3 == null)
		{
			return;
		}
		data3.SetFirstUnlockPack();
	}

	// Token: 0x0600758E RID: 30094 RVA: 0x00244EA2 File Offset: 0x002430A2
	protected override void OnBeforeDestroy()
	{
		this.StopUnlockTimeTimer();
	}

	// Token: 0x0600758F RID: 30095 RVA: 0x00244EAA File Offset: 0x002430AA
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WuWuLogisticsTaskUpdate, new Action(this.UpdateCurSelectedContent));
	}

	// Token: 0x06007590 RID: 30096 RVA: 0x00244EC8 File Offset: 0x002430C8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WuWuLogisticsTaskUpdate, new Action(this.UpdateCurSelectedContent));
	}

	// Token: 0x06007591 RID: 30097 RVA: 0x00244EE6 File Offset: 0x002430E6
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Switch")
		{
			this.UpdateMissionInfo();
			this.UpdateInfoScroll();
			this.UpdatePackRewardPanel();
			this.SetCurIndexIcon();
		}
	}

	// Token: 0x06007592 RID: 30098 RVA: 0x00244F10 File Offset: 0x00243110
	private void InitCaption()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			this.CaptionItem = new PopupCaptionItem(item);
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.CaptionItem.SetHelpCallBack(delegate
			{
				if (this.Data == null)
				{
					return;
				}
				HelpController.Instance.OpenHelpById(this.Data.LocalConfig.Value.HelpId);
			});
			this.CaptionItem.SetCloseBtnActive(true);
		}
	}

	// Token: 0x06007593 RID: 30099 RVA: 0x00244F6E File Offset: 0x0024316E
	private WuWuLogisticsPackItem InitPackItem()
	{
		WuWuLogisticsPackItem wuWuLogisticsPackItem = new WuWuLogisticsPackItem();
		wuWuLogisticsPackItem.SetClickCallback(new Action<int>(this.OnClickPackItem));
		return wuWuLogisticsPackItem;
	}

	// Token: 0x06007594 RID: 30100 RVA: 0x00244F87 File Offset: 0x00243187
	private WuWuLogisticsMissionItem InitMissionItem()
	{
		WuWuLogisticsMissionItem wuWuLogisticsMissionItem = new WuWuLogisticsMissionItem();
		wuWuLogisticsMissionItem.SetClickCallback(new Action<int>(this.OnClickMissionItem));
		return wuWuLogisticsMissionItem;
	}

	// Token: 0x06007595 RID: 30101 RVA: 0x00244FA0 File Offset: 0x002431A0
	private WuWuLogisticsInfoItem InitInfoItem()
	{
		return new WuWuLogisticsInfoItem();
	}

	// Token: 0x06007596 RID: 30102 RVA: 0x00244FA8 File Offset: 0x002431A8
	private void OnClickPackItem(int cfgId)
	{
		if (cfgId == this.CurSelectedPackCfgId)
		{
			return;
		}
		this.CurSelectedPackCfgId = cfgId;
		this.SetOtherPackTogglesInteractive(cfgId, false);
		this.UpdatePackLayout();
		base.PlaySequence("Switch", delegate
		{
			this.SetAllPackTogglesInteractive(true);
		}, false);
		UUIInturnAnimController animationController = this.AnimationController;
		if (animationController == null)
		{
			return;
		}
		animationController.Play("Start", -1, false);
	}

	// Token: 0x06007597 RID: 30103 RVA: 0x00245004 File Offset: 0x00243204
	private void SetOtherPackTogglesInteractive(int clickedCfgId, bool interactive)
	{
		GenericLayout<WuWuLogisticsPackItem, int> packLayout = this.PackLayout;
		if (packLayout == null)
		{
			return;
		}
		IReadOnlyList<int> datas = packLayout.GetDatas();
		List<WuWuLogisticsPackItem> layoutItemList = packLayout.GetLayoutItemList();
		for (int i = 0; i < layoutItemList.Count; i++)
		{
			if (datas[i] != clickedCfgId)
			{
				layoutItemList[i].SetPackToggleInteractive(interactive);
			}
		}
	}

	// Token: 0x06007598 RID: 30104 RVA: 0x00245054 File Offset: 0x00243254
	private void SetAllPackTogglesInteractive(bool interactive)
	{
		GenericLayout<WuWuLogisticsPackItem, int> packLayout = this.PackLayout;
		List<WuWuLogisticsPackItem> list = (packLayout != null) ? packLayout.GetLayoutItemList() : null;
		if (list == null)
		{
			return;
		}
		foreach (WuWuLogisticsPackItem wuWuLogisticsPackItem in list)
		{
			wuWuLogisticsPackItem.SetPackToggleInteractive(interactive);
		}
	}

	// Token: 0x06007599 RID: 30105 RVA: 0x002450B8 File Offset: 0x002432B8
	private void OnClickMissionItem(int taskId)
	{
		WuWuLogisticsActivityData data = this.Data;
		List<int> list = (data != null) ? data.GetTargetPackCanReceiveTaskIds(this.CurSelectedPackCfgId) : null;
		if (list != null && list.Count > 0)
		{
			WuWuLogisticsActivityController.Instance.RequestTaskReward(list);
		}
	}

	// Token: 0x0600759A RID: 30106 RVA: 0x002450F5 File Offset: 0x002432F5
	private void UpdateCurSelectedContent()
	{
		this.UpdatePackLayout();
		this.UpdateMissionInfo();
		this.UpdateInfoScroll();
		this.UpdatePackRewardPanel();
		this.SetCurIndexIcon();
	}

	// Token: 0x0600759B RID: 30107 RVA: 0x00245118 File Offset: 0x00243318
	private void UpdateInfoScroll()
	{
		WuWuLogisticsMissionView.<>c__DisplayClass27_0 CS$<>8__locals1 = new WuWuLogisticsMissionView.<>c__DisplayClass27_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.Data == null || this.CurSelectedPackCfgId == 0)
		{
			return;
		}
		WuWuTaskPackage? taskPackageById = WuWuLogisticsConfig.Instance.GetTaskPackageById(this.CurSelectedPackCfgId);
		if (taskPackageById == null)
		{
			return;
		}
		IReadOnlyList<WuWuLogisticsDesc> descListByGroupId = WuWuLogisticsConfig.Instance.GetDescListByGroupId(taskPackageById.Value.DescGroupId);
		if (descListByGroupId == null)
		{
			return;
		}
		CS$<>8__locals1.infoDataList = new List<IWuWuLogisticsInfoItemData>();
		WuWuTaskPackData taskPackById = this.Data.GetTaskPackById(this.CurSelectedPackCfgId);
		if (taskPackById == null)
		{
			return;
		}
		WuWuLogisticsActivityData activityData = WuWuLogisticsActivityController.Instance.GetActivityData();
		if (activityData == null)
		{
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		foreach (WuWuLogisticsDesc wuWuLogisticsDesc in descListByGroupId)
		{
			long num = (long)(wuWuLogisticsDesc.UnlockTime * TimeUtil.Instance.OneDaySeconds) + activityData.BeginOpenTime;
			if (serverTime >= (double)num)
			{
				CS$<>8__locals1.infoDataList.Add(new WuWuLogisticsInfoItemData
				{
					CfgId = wuWuLogisticsDesc.Id,
					IsToday = false,
					Content = null
				});
			}
		}
		if (activityData.IsPackUnlocked(this.CurSelectedPackCfgId))
		{
			WuWuLogisticsInfoItemData item = new WuWuLogisticsInfoItemData
			{
				CfgId = 0,
				IsToday = false,
				Content = "Express_Delivery_Unlock"
			};
			CS$<>8__locals1.infoDataList.Add(item);
		}
		if (taskPackById.HadReward)
		{
			WuWuLogisticsInfoItemData item2 = new WuWuLogisticsInfoItemData
			{
				CfgId = 0,
				IsToday = false,
				Content = "Express_Delivery_Finished"
			};
			CS$<>8__locals1.infoDataList.Add(item2);
		}
		if (CS$<>8__locals1.infoDataList.Count > 0)
		{
			CS$<>8__locals1.infoDataList[CS$<>8__locals1.infoDataList.Count - 1].IsToday = true;
		}
		GenericScrollViewNew<WuWuLogisticsInfoItem, IWuWuLogisticsInfoItemData> logisiticsInfoScrollView = this.LogisiticsInfoScrollView;
		if (logisiticsInfoScrollView == null)
		{
			return;
		}
		logisiticsInfoScrollView.RefreshByData(CS$<>8__locals1.infoDataList, delegate
		{
			WuWuLogisticsMissionView.<>c__DisplayClass27_1 CS$<>8__locals2 = new WuWuLogisticsMissionView.<>c__DisplayClass27_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			WuWuLogisticsMissionView.<>c__DisplayClass27_1 CS$<>8__locals3 = CS$<>8__locals2;
			GenericScrollViewNew<WuWuLogisticsInfoItem, IWuWuLogisticsInfoItemData> logisiticsInfoScrollView2 = CS$<>8__locals1.<>4__this.LogisiticsInfoScrollView;
			CS$<>8__locals3.lastItem = ((logisiticsInfoScrollView2 != null) ? logisiticsInfoScrollView2.GetItemByIndex(CS$<>8__locals1.infoDataList.Count - 1) : null);
			if (CS$<>8__locals2.lastItem != null)
			{
				TimerSystem.GameplayTimeInstance.Delay(delegate(float delta)
				{
					GenericScrollViewNew<WuWuLogisticsInfoItem, IWuWuLogisticsInfoItemData> logisiticsInfoScrollView3 = CS$<>8__locals2.CS$<>8__locals1.<>4__this.LogisiticsInfoScrollView;
					if (logisiticsInfoScrollView3 == null)
					{
						return;
					}
					logisiticsInfoScrollView3.LateScrollTo(CS$<>8__locals2.lastItem, null, false);
				}, 100f, null, null, true, 1f);
			}
		}, false);
	}

	// Token: 0x0600759C RID: 30108 RVA: 0x0024530C File Offset: 0x0024350C
	private void UpdatePackLayout()
	{
		IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
		if (allTaskPackage == null)
		{
			return;
		}
		List<int> list = new List<int>();
		int selectedIndex = 0;
		for (int i = 0; i < allTaskPackage.Count; i++)
		{
			WuWuTaskPackage wuWuTaskPackage = allTaskPackage[i];
			if (wuWuTaskPackage.Id == this.CurSelectedPackCfgId)
			{
				selectedIndex = i;
			}
			list.Add(wuWuTaskPackage.Id);
		}
		GenericLayout<WuWuLogisticsPackItem, int> packLayout = this.PackLayout;
		if (packLayout == null)
		{
			return;
		}
		packLayout.RefreshByData(list, delegate
		{
			GenericLayout<WuWuLogisticsPackItem, int> packLayout2 = this.PackLayout;
			if (packLayout2 == null)
			{
				return;
			}
			packLayout2.SelectGridProxy(selectedIndex, false);
		}, false);
	}

	// Token: 0x0600759D RID: 30109 RVA: 0x002453A0 File Offset: 0x002435A0
	private void UpdateMissionInfo()
	{
		if (this.Data == null || this.CurSelectedPackCfgId == 0)
		{
			return;
		}
		if (this.Data.GetTaskPackById(this.CurSelectedPackCfgId) == null)
		{
			return;
		}
		bool flag = this.Data.IsPackUnlocked(this.CurSelectedPackCfgId);
		base.GetScrollViewWithScrollbar(4).RootUIComp.Get().SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		base.GetText(3).SetUIActive(flag);
		base.GetScrollViewWithScrollbar(4).RootUIComp.Get().SetUIActive(flag);
		this.SetLockTips();
		if (!flag)
		{
			return;
		}
		List<int> list = new List<int>();
		IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(this.CurSelectedPackCfgId);
		if (weekTaskByWrapId != null)
		{
			int num = 0;
			foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
			{
				list.Add(wuWuWeekTask.Id);
				WuWuTaskData taskById = this.Data.GetTaskById(wuWuWeekTask.Id);
				if (taskById != null && taskById.IsRewarded)
				{
					num++;
				}
			}
			this.UpdateCurProgressTitle(num, weekTaskByWrapId.Count);
		}
		GenericScrollViewNew<WuWuLogisticsMissionItem, int> missionScrollView = this.MissionScrollView;
		if (missionScrollView == null)
		{
			return;
		}
		missionScrollView.RefreshByData(list, null, false);
	}

	// Token: 0x0600759E RID: 30110 RVA: 0x002454EC File Offset: 0x002436EC
	private void UpdateCurProgressTitle(int finishCount, int allMission)
	{
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Express_Delivery_Task_Progress");
		string[] array = new string[2];
		int num = 0;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#ffa200>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(finishCount);
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
		int num2 = 1;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(allMission);
		array[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
		string newText = StringUtils.Format(multiTextByKey, array);
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x0600759F RID: 30111 RVA: 0x00245576 File Offset: 0x00243776
	private void UpdatePackRewardPanel()
	{
		WuWuLogisticsRewardPreviewPanel packRewardPanel = this.PackRewardPanel;
		if (packRewardPanel != null)
		{
			packRewardPanel.SetPackConfigId(this.CurSelectedPackCfgId, this.Data);
		}
		WuWuLogisticsRewardPreviewPanel packRewardPanel2 = this.PackRewardPanel;
		if (packRewardPanel2 == null)
		{
			return;
		}
		packRewardPanel2.RefreshConfirmButtonRedPoint();
	}

	// Token: 0x060075A0 RID: 30112 RVA: 0x002455A8 File Offset: 0x002437A8
	private void SetLockTips()
	{
		this.StopUnlockTimeTimer();
		WuWuTaskPackData taskPackById = this.Data.GetTaskPackById(this.CurSelectedPackCfgId);
		if (taskPackById == null)
		{
			return;
		}
		bool isUnlock = taskPackById.IsUnlock;
		bool flag = this.Data.IsPackUnlocked(this.CurSelectedPackCfgId);
		if (isUnlock && flag)
		{
			return;
		}
		if (!isUnlock)
		{
			this.StartUnlockTimeTimer(taskPackById.UnlockTime);
			return;
		}
		if (!flag)
		{
			UUIText text = base.GetText(10);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("Express_Delivery_Delivered");
		}
	}

	// Token: 0x060075A1 RID: 30113 RVA: 0x0024561C File Offset: 0x0024381C
	private void RefreshUnlockTimeText(long unlockTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		if ((double)unlockTime - serverTime <= 0.0)
		{
			this.UpdateCurSelectedContent();
			this.StopUnlockTimeTimer();
			return;
		}
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Activity_Anniversary2_04_Time");
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(unlockTime, multiTextByKey);
		if (string.IsNullOrEmpty(remainTimeText))
		{
			return;
		}
		UUIText text = base.GetText(10);
		if (text == null)
		{
			return;
		}
		text.SetText(remainTimeText, true);
	}

	// Token: 0x060075A2 RID: 30114 RVA: 0x0024568C File Offset: 0x0024388C
	private void StartUnlockTimeTimer(long unlockTime)
	{
		this.RefreshUnlockTimeText(unlockTime);
		this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
		{
			this.RefreshUnlockTimeText(unlockTime);
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x060075A3 RID: 30115 RVA: 0x002456E2 File Offset: 0x002438E2
	private void StopUnlockTimeTimer()
	{
		if (this.TickHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
			this.TickHandle = null;
		}
	}

	// Token: 0x060075A4 RID: 30116 RVA: 0x00245704 File Offset: 0x00243904
	private void SetCurIndexIcon()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_NumA0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurSelectedPackCfgId);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(11), false, null, null);
	}

	// Token: 0x04004A41 RID: 19009
	[Nullable(2)]
	protected WuWuLogisticsActivityData Data;

	// Token: 0x04004A42 RID: 19010
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004A43 RID: 19011
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WuWuLogisticsPackItem, int> PackLayout;

	// Token: 0x04004A44 RID: 19012
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WuWuLogisticsMissionItem, int> MissionScrollView;

	// Token: 0x04004A45 RID: 19013
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WuWuLogisticsInfoItem, IWuWuLogisticsInfoItemData> LogisiticsInfoScrollView;

	// Token: 0x04004A46 RID: 19014
	[Nullable(2)]
	private WuWuLogisticsRewardPreviewPanel PackRewardPanel;

	// Token: 0x04004A47 RID: 19015
	private int CurSelectedPackCfgId = 1;

	// Token: 0x04004A48 RID: 19016
	[Nullable(2)]
	protected TimerHandle TickHandle;

	// Token: 0x04004A49 RID: 19017
	[Nullable(2)]
	private UUIInturnAnimController AnimationController;
}
