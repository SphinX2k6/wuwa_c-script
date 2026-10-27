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

// Token: 0x02001669 RID: 5737
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsMissionView : UiViewBase
{
	// Token: 0x0600A1AB RID: 41387 RVA: 0x0023AD46 File Offset: 0x00238F46
	public WuWuLogisticsMissionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A1AC RID: 41388 RVA: 0x0023AD58 File Offset: 0x00238F58
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

	// Token: 0x0600A1AD RID: 41389 RVA: 0x0023AE94 File Offset: 0x00239094
	protected override UniTask OnBeforeStartAsync()
	{
		WuWuLogisticsMissionView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WuWuLogisticsMissionView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1AE RID: 41390 RVA: 0x0023AED8 File Offset: 0x002390D8
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

	// Token: 0x0600A1AF RID: 41391 RVA: 0x0023AF98 File Offset: 0x00239198
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

	// Token: 0x0600A1B0 RID: 41392 RVA: 0x0023B006 File Offset: 0x00239206
	protected override void OnBeforeDestroy()
	{
		this.StopUnlockTimeTimer();
	}

	// Token: 0x0600A1B1 RID: 41393 RVA: 0x0023B00E File Offset: 0x0023920E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WuWuLogisticsTaskUpdate, new Action(this.UpdateCurSelectedContent));
	}

	// Token: 0x0600A1B2 RID: 41394 RVA: 0x0023B02C File Offset: 0x0023922C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WuWuLogisticsTaskUpdate, new Action(this.UpdateCurSelectedContent));
	}

	// Token: 0x0600A1B3 RID: 41395 RVA: 0x0023B04A File Offset: 0x0023924A
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

	// Token: 0x0600A1B4 RID: 41396 RVA: 0x0023B074 File Offset: 0x00239274
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

	// Token: 0x0600A1B5 RID: 41397 RVA: 0x0023B0D2 File Offset: 0x002392D2
	private WuWuLogisticsPackItem InitPackItem()
	{
		WuWuLogisticsPackItem wuWuLogisticsPackItem = new WuWuLogisticsPackItem();
		wuWuLogisticsPackItem.SetClickCallback(new Action<int>(this.OnClickPackItem));
		return wuWuLogisticsPackItem;
	}

	// Token: 0x0600A1B6 RID: 41398 RVA: 0x0023B0EB File Offset: 0x002392EB
	private WuWuLogisticsMissionItem InitMissionItem()
	{
		WuWuLogisticsMissionItem wuWuLogisticsMissionItem = new WuWuLogisticsMissionItem();
		wuWuLogisticsMissionItem.SetClickCallback(new Action<int>(this.OnClickMissionItem));
		return wuWuLogisticsMissionItem;
	}

	// Token: 0x0600A1B7 RID: 41399 RVA: 0x0023B104 File Offset: 0x00239304
	private WuWuLogisticsInfoItem InitInfoItem()
	{
		return new WuWuLogisticsInfoItem();
	}

	// Token: 0x0600A1B8 RID: 41400 RVA: 0x0023B10C File Offset: 0x0023930C
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

	// Token: 0x0600A1B9 RID: 41401 RVA: 0x0023B168 File Offset: 0x00239368
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

	// Token: 0x0600A1BA RID: 41402 RVA: 0x0023B1B8 File Offset: 0x002393B8
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

	// Token: 0x0600A1BB RID: 41403 RVA: 0x0023B21C File Offset: 0x0023941C
	private void OnClickMissionItem(int taskId)
	{
		WuWuLogisticsActivityData data = this.Data;
		List<int> list = (data != null) ? data.GetTargetPackCanReceiveTaskIds(this.CurSelectedPackCfgId) : null;
		if (list != null && list.Count > 0)
		{
			WuWuLogisticsActivityController.Instance.RequestTaskReward(list);
		}
	}

	// Token: 0x0600A1BC RID: 41404 RVA: 0x0023B259 File Offset: 0x00239459
	private void UpdateCurSelectedContent()
	{
		this.UpdatePackLayout();
		this.UpdateMissionInfo();
		this.UpdateInfoScroll();
		this.UpdatePackRewardPanel();
		this.SetCurIndexIcon();
	}

	// Token: 0x0600A1BD RID: 41405 RVA: 0x0023B27C File Offset: 0x0023947C
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

	// Token: 0x0600A1BE RID: 41406 RVA: 0x0023B470 File Offset: 0x00239670
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

	// Token: 0x0600A1BF RID: 41407 RVA: 0x0023B504 File Offset: 0x00239704
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

	// Token: 0x0600A1C0 RID: 41408 RVA: 0x0023B650 File Offset: 0x00239850
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

	// Token: 0x0600A1C1 RID: 41409 RVA: 0x0023B6DA File Offset: 0x002398DA
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

	// Token: 0x0600A1C2 RID: 41410 RVA: 0x0023B70C File Offset: 0x0023990C
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

	// Token: 0x0600A1C3 RID: 41411 RVA: 0x0023B780 File Offset: 0x00239980
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

	// Token: 0x0600A1C4 RID: 41412 RVA: 0x0023B7F0 File Offset: 0x002399F0
	private void StartUnlockTimeTimer(long unlockTime)
	{
		this.RefreshUnlockTimeText(unlockTime);
		this.TickHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
		{
			this.RefreshUnlockTimeText(unlockTime);
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600A1C5 RID: 41413 RVA: 0x0023B846 File Offset: 0x00239A46
	private void StopUnlockTimeTimer()
	{
		if (this.TickHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TickHandle);
			this.TickHandle = null;
		}
	}

	// Token: 0x0600A1C6 RID: 41414 RVA: 0x0023B868 File Offset: 0x00239A68
	private void SetCurIndexIcon()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_NumA0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurSelectedPackCfgId);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(11), false, null, null);
	}

	// Token: 0x0400499B RID: 18843
	[Nullable(2)]
	protected WuWuLogisticsActivityData Data;

	// Token: 0x0400499C RID: 18844
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400499D RID: 18845
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WuWuLogisticsPackItem, int> PackLayout;

	// Token: 0x0400499E RID: 18846
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WuWuLogisticsMissionItem, int> MissionScrollView;

	// Token: 0x0400499F RID: 18847
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WuWuLogisticsInfoItem, IWuWuLogisticsInfoItemData> LogisiticsInfoScrollView;

	// Token: 0x040049A0 RID: 18848
	[Nullable(2)]
	private WuWuLogisticsRewardPreviewPanel PackRewardPanel;

	// Token: 0x040049A1 RID: 18849
	private int CurSelectedPackCfgId = 1;

	// Token: 0x040049A2 RID: 18850
	[Nullable(2)]
	protected TimerHandle TickHandle;

	// Token: 0x040049A3 RID: 18851
	[Nullable(2)]
	private UUIInturnAnimController AnimationController;
}
