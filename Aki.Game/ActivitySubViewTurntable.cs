using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009EA RID: 2538
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewTurntable : ActivitySubViewBase
{
	// Token: 0x06006EBE RID: 28350 RVA: 0x00221BC0 File Offset: 0x0021FDC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006EBF RID: 28351 RVA: 0x00221DDD File Offset: 0x0021FFDD
	protected override void OnSetData()
	{
		this.ActivityTurntableData = (this.ActivityBaseData as ActivityTurntableData);
	}

	// Token: 0x06006EC0 RID: 28352 RVA: 0x00221DF0 File Offset: 0x0021FFF0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTurntable.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTurntable.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006EC1 RID: 28353 RVA: 0x00221E34 File Offset: 0x00220034
	protected override void OnStart()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		this.FunctionalArea.FunctionButton.SetFunction(new Action(this.OnClickedTurntableRun));
		this.FunctionalArea.SetFunctionRedDotVisible(true);
		this.TurntableAnim.SetActive(false);
		this.TurntableAnim.Activate = false;
		this.InitTitleSprite();
	}

	// Token: 0x06006EC2 RID: 28354 RVA: 0x00221EB0 File Offset: 0x002200B0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.TurntableStartRun, new Action<int>(this.OnTurntableStartRun));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06006EC3 RID: 28355 RVA: 0x00221F14 File Offset: 0x00220114
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TurntableStartRun, new Action<int>(this.OnTurntableStartRun));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06006EC4 RID: 28356 RVA: 0x00221F78 File Offset: 0x00220178
	protected override void OnRefreshView()
	{
		this.RefreshPanel();
		this.RefreshToggleItem();
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new <>z__ReadOnlySingleElementList<int>(this.ActivityTurntableData.TurntableCostConfigId));
		if (this.ActivityTurntableData.IsUnLock())
		{
			this.ActivityTurntableData.SaveUnlockRedDot();
		}
		if (this.ActivityTurntableData.TurntableType == ETurntableType.Daily)
		{
			this.ActivityTurntableData.SaveDailyRedDot();
		}
	}

	// Token: 0x06006EC5 RID: 28357 RVA: 0x00221FE2 File Offset: 0x002201E2
	protected override void OnBeforeDestroy()
	{
		this.SpriteLoaderList.Clear();
		this.SpritePathList.Clear();
	}

	// Token: 0x06006EC6 RID: 28358 RVA: 0x00221FFA File Offset: 0x002201FA
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06006EC7 RID: 28359 RVA: 0x00222002 File Offset: 0x00220202
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id != this.ActivityTurntableData.Id)
		{
			return;
		}
		if (this.ActivityTurntableData.TurntableType == ETurntableType.Quest)
		{
			this.RefreshQuestRedDot();
		}
	}

	// Token: 0x06006EC8 RID: 28360 RVA: 0x00222028 File Offset: 0x00220228
	private void OnActivityCrossDayRefresh()
	{
		this.RefreshPanel();
		if (!this.ActivityTurntableData.CheckIfInShowTime())
		{
			return;
		}
		if (this.ActivityTurntableData.TurntableType != ETurntableType.Daily)
		{
			return;
		}
		if (this.InTurntableRun)
		{
			return;
		}
		if (!this.ActivityTurntableData.IsActivityUnFinished())
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DailyTurntableRefresh);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06006EC9 RID: 28361 RVA: 0x00222086 File Offset: 0x00220286
	private void RefreshPanel()
	{
		if (this.ActivityTurntableData.TurntableType == ETurntableType.Quest)
		{
			this.RefreshQuest();
			return;
		}
		if (this.ActivityTurntableData.TurntableType == ETurntableType.Daily)
		{
			this.RefreshDaily();
		}
	}

	// Token: 0x06006ECA RID: 28362 RVA: 0x002220B4 File Offset: 0x002202B4
	private void RefreshQuestRedDot()
	{
		bool redDot = this.ActivityTurntableData.IsHasNewQuestRedDot();
		ActivityTurntableQuestItem questItem = this.QuestItem;
		if (questItem == null)
		{
			return;
		}
		questItem.SetRedDot(redDot);
	}

	// Token: 0x06006ECB RID: 28363 RVA: 0x002220E0 File Offset: 0x002202E0
	private void RefreshQuest()
	{
		this.IsQuestLockTimeShow = false;
		int currentQuestProgress = this.ActivityTurntableData.GetCurrentQuestProgress();
		int count = this.ActivityTurntableData.QuestList.Count;
		base.GetItem(2).SetUIActive(currentQuestProgress < count);
		this.QuestItem.SetActive(currentQuestProgress < count);
		if (currentQuestProgress == count)
		{
			return;
		}
		this.QuestItem.SetTitle("TurntableActivity_Progress", new string[]
		{
			currentQuestProgress.ToString(),
			count.ToString()
		});
		int currentQuestIndex = this.ActivityTurntableData.GetCurrentQuestIndex();
		int num = this.ActivityTurntableData.QuestList[currentQuestIndex];
		ITurntableQuestInfo turntableQuestInfo = this.ActivityTurntableData.QuestStateMap[num];
		IQuest questConfig = QuestNewModel.Instance.GetQuestConfig(num);
		int? num2 = (questConfig != null) ? questConfig.RewardId : null;
		int? num3 = num2;
		int num4 = 0;
		if (num3.GetValueOrDefault() == num4 & num3 != null)
		{
			return;
		}
		List<TItem> previewReward = this.ActivityTurntableData.GetPreviewReward(num2);
		if (previewReward.Count < 1)
		{
			return;
		}
		bool isFinished = false;
		num4 = turntableQuestInfo.QuestState;
		if (num4 - 1 > 1)
		{
			if (num4 == 3)
			{
				isFinished = true;
				this.IsQuestLockTimeShow = true;
				int key = this.ActivityTurntableData.QuestList[currentQuestIndex + 1];
				ITurntableQuestInfo turntableQuestInfo2 = this.ActivityTurntableData.QuestStateMap[key];
				this.QuestLockTime = turntableQuestInfo2.QuestUnlockStamp;
				this.RefreshTimerText();
			}
		}
		else
		{
			string text = (questConfig != null) ? questConfig.TidName : null;
			string txt = (text != null) ? PublicUtil.Instance.GetConfigTextByKey(text) : "";
			this.QuestItem.SetTxt(txt);
		}
		this.QuestItem.Refresh(isFinished, previewReward[0], num, this.ActivityTurntableData.Id);
		this.RefreshQuestRedDot();
	}

	// Token: 0x06006ECC RID: 28364 RVA: 0x002222AC File Offset: 0x002204AC
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
		if (this.IsQuestLockTimeShow)
		{
			this.QuestItem.SetTxtById("TurntableActivity_TaskDesc", new string[]
			{
				this.GetRemainQuestUnlockTimeText(this.QuestLockTime)
			});
		}
	}

	// Token: 0x06006ECD RID: 28365 RVA: 0x00222314 File Offset: 0x00220514
	private string GetRemainQuestUnlockTimeText(long endTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)endTime - serverTime, 1.0);
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> questLockTimeTypeData = this.GetQuestLockTimeTypeData(num);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(questLockTimeTypeData.Item1), new CommonDefine.ETimeType?(questLockTimeTypeData.Item2)).CountDownText ?? "";
	}

	// Token: 0x06006ECE RID: 28366 RVA: 0x00222378 File Offset: 0x00220578
	[NullableContext(0)]
	private ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> GetQuestLockTimeTypeData(double remainTime)
	{
		if (remainTime > 86400.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Day, CommonDefine.ETimeType.Hour);
		}
		if (remainTime > 3600.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Hour, CommonDefine.ETimeType.Minute);
		}
		if (remainTime > 60.0)
		{
			return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Minute, CommonDefine.ETimeType.Second);
		}
		return new ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType>(CommonDefine.ETimeType.Second, CommonDefine.ETimeType.Second);
	}

	// Token: 0x06006ECF RID: 28367 RVA: 0x002223C8 File Offset: 0x002205C8
	private void RefreshDaily()
	{
		bool flag = this.ActivityTurntableData.IsActivityUnFinished();
		this.DailyPanel.SetActive(flag);
		if (!flag)
		{
			return;
		}
		this.DailyPanel.Refresh();
	}

	// Token: 0x06006ED0 RID: 28368 RVA: 0x002223FC File Offset: 0x002205FC
	private void RefreshFunctionState()
	{
		bool flag = this.ActivityTurntableData.GetCurrentRoundId() == this.CurrentSelectRoundId;
		bool flag2 = this.ActivityTurntableData.IsRoundUnFinished(this.CurrentSelectRoundId);
		bool flag3 = this.ActivityTurntableData.IsHasRewardRedDot();
		if (!flag2)
		{
			this.RefreshFunctionalFinished();
			return;
		}
		if (!flag)
		{
			this.RefreshFunctionalLock("TurntableActivity_ForbidTips02");
			return;
		}
		if (flag3)
		{
			this.RefreshFunctionalRun();
			return;
		}
		this.RefreshFunctionalLock("TurntableActivity_ForbidTips01");
	}

	// Token: 0x06006ED1 RID: 28369 RVA: 0x00222467 File Offset: 0x00220667
	private void RefreshFunctionalFinished()
	{
		this.FunctionalArea.FunctionButton.SetActive(false);
		this.FunctionalArea.SetPanelConditionVisible(false);
		this.FunctionalArea.SetActivatePanelConditionVisible(true);
	}

	// Token: 0x06006ED2 RID: 28370 RVA: 0x00222492 File Offset: 0x00220692
	private void RefreshFunctionalLock(string textId)
	{
		this.FunctionalArea.FunctionButton.SetActive(false);
		this.FunctionalArea.SetPanelConditionVisible(true);
		this.FunctionalArea.SetLockTextByTextId(textId, Array.Empty<string>());
		this.FunctionalArea.SetActivatePanelConditionVisible(false);
	}

	// Token: 0x06006ED3 RID: 28371 RVA: 0x002224CE File Offset: 0x002206CE
	private void RefreshFunctionalRun()
	{
		this.FunctionalArea.FunctionButton.SetActive(true);
		this.FunctionalArea.SetPanelConditionVisible(false);
		this.FunctionalArea.SetActivatePanelConditionVisible(false);
	}

	// Token: 0x06006ED4 RID: 28372 RVA: 0x002224F9 File Offset: 0x002206F9
	private ActivityTurntableToggleGroupItem InitToggleItem()
	{
		return new ActivityTurntableToggleGroupItem
		{
			ToggleCallBack = new Action<int, bool>(this.ToggleCallBack)
		};
	}

	// Token: 0x06006ED5 RID: 28373 RVA: 0x00222514 File Offset: 0x00220714
	private void ToggleCallBack(int roundId, bool state)
	{
		if (!state)
		{
			return;
		}
		if (this.CurrentSelectRoundId >= 0 && this.CurrentSelectRoundId != roundId)
		{
			this.ToggleLayout.GetLayoutItemByIndex(this.CurrentSelectRoundId).SetToggleState(false, false);
		}
		this.RefreshRound(roundId, this.CurrentSelectRoundId, true).Forget();
		this.RefreshFunctionState();
	}

	// Token: 0x06006ED6 RID: 28374 RVA: 0x00222568 File Offset: 0x00220768
	private void RefreshToggleItem()
	{
		this.ToggleLayout.RefreshByData(this.ActivityTurntableData.RoundIdList, delegate
		{
			int currentRoundId = this.ActivityTurntableData.GetCurrentRoundId();
			List<ActivityTurntableToggleGroupItem> layoutItemList = this.ToggleLayout.GetLayoutItemList();
			for (int i = 0; i < this.ActivityTurntableData.RoundIdList.Count; i++)
			{
				int num = this.ActivityTurntableData.RoundIdList[i];
				bool flag = this.ActivityTurntableData.IsRoundUnFinished(num);
				layoutItemList[i].SetToggleDisable(!flag);
				bool bSelectOn = num == currentRoundId;
				layoutItemList[i].SetToggleState(bSelectOn, false);
			}
			this.RefreshRound(currentRoundId, this.CurrentSelectRoundId, false).Forget();
			this.RefreshFunctionState();
		}, false);
	}

	// Token: 0x06006ED7 RID: 28375 RVA: 0x0022258D File Offset: 0x0022078D
	private void OnClickedTurntableRun()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.ActivityTurntableData.GetActivityCurrencyCount() >= this.ActivityTurntableData.TurntableCostCount)
			{
				ActivityTurntableController.RequestTurntableRun(this.ActivityTurntableData.Id);
			}
		});
	}

	// Token: 0x06006ED8 RID: 28376 RVA: 0x002225AC File Offset: 0x002207AC
	private void InitTitleSprite()
	{
		ValueTuple<int, int, bool>[] array = new ValueTuple<int, int, bool>[]
		{
			new ValueTuple<int, int, bool>(9, 0, true),
			new ValueTuple<int, int, bool>(10, 0, false),
			new ValueTuple<int, int, bool>(11, 1, true),
			new ValueTuple<int, int, bool>(12, 2, true),
			new ValueTuple<int, int, bool>(13, 0, true)
		};
		foreach (int[] array2 in this.TitleIdNameList)
		{
			List<string> list = new List<string>();
			foreach (int value in array2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("SP_TurntableTitleRound");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
				list.Add(resourcePath);
			}
			this.SpritePathList.Add(list.ToArray());
		}
		foreach (ValueTuple<int, int, bool> valueTuple in array)
		{
			UUISprite sprite = base.GetSprite(valueTuple.Item1);
			ActivitySubViewTurntable.SpriteLoader item = new ActivitySubViewTurntable.SpriteLoader
			{
				Sprite = sprite,
				Index = valueTuple.Item2,
				IsCurrent = valueTuple.Item3
			};
			this.SpriteLoaderList.Add(item);
		}
	}

	// Token: 0x06006ED9 RID: 28377 RVA: 0x002226FC File Offset: 0x002208FC
	private UniTask RefreshTitle(int roundId, int lastRoundId)
	{
		ActivitySubViewTurntable.<RefreshTitle>d__45 <RefreshTitle>d__;
		<RefreshTitle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTitle>d__.<>4__this = this;
		<RefreshTitle>d__.roundId = roundId;
		<RefreshTitle>d__.lastRoundId = lastRoundId;
		<RefreshTitle>d__.<>1__state = -1;
		<RefreshTitle>d__.<>t__builder.Start<ActivitySubViewTurntable.<RefreshTitle>d__45>(ref <RefreshTitle>d__);
		return <RefreshTitle>d__.<>t__builder.Task;
	}

	// Token: 0x06006EDA RID: 28378 RVA: 0x00222750 File Offset: 0x00220950
	private UniTask RefreshRound(int roundId, int lastRoundId, bool needAnim = true)
	{
		ActivitySubViewTurntable.<RefreshRound>d__46 <RefreshRound>d__;
		<RefreshRound>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRound>d__.<>4__this = this;
		<RefreshRound>d__.roundId = roundId;
		<RefreshRound>d__.lastRoundId = lastRoundId;
		<RefreshRound>d__.needAnim = needAnim;
		<RefreshRound>d__.<>1__state = -1;
		<RefreshRound>d__.<>t__builder.Start<ActivitySubViewTurntable.<RefreshRound>d__46>(ref <RefreshRound>d__);
		return <RefreshRound>d__.<>t__builder.Task;
	}

	// Token: 0x06006EDB RID: 28379 RVA: 0x002227AC File Offset: 0x002209AC
	private UniTask RefreshTurntable(int roundId, ActivityTurntableComponent turntable)
	{
		ActivitySubViewTurntable.<RefreshTurntable>d__47 <RefreshTurntable>d__;
		<RefreshTurntable>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTurntable>d__.<>4__this = this;
		<RefreshTurntable>d__.roundId = roundId;
		<RefreshTurntable>d__.turntable = turntable;
		<RefreshTurntable>d__.<>1__state = -1;
		<RefreshTurntable>d__.<>t__builder.Start<ActivitySubViewTurntable.<RefreshTurntable>d__47>(ref <RefreshTurntable>d__);
		return <RefreshTurntable>d__.<>t__builder.Task;
	}

	// Token: 0x06006EDC RID: 28380 RVA: 0x00222800 File Offset: 0x00220A00
	public override void OnCommonViewStateChange(bool show)
	{
		string sequenceName = show ? "TurnTableOut" : "TurnTableIn";
		this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, true, null, false);
	}

	// Token: 0x06006EDD RID: 28381 RVA: 0x00222834 File Offset: 0x00220A34
	private void OnTurntableStartRun(int rewardId)
	{
		int currentRoundId = this.ActivityTurntableData.GetCurrentRoundId();
		int lastSelectRoundId = this.CurrentSelectRoundId;
		this.InTurntableRun = true;
		EventSystem.Instance.Emit<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, false, EActivityViewState.Global, new bool?(true));
		Action <>9__1;
		this.Turntable.RunTurntableByRewardId(rewardId, delegate
		{
			List<TItem> runResult = this.ActivityTurntableData.GetRunResult();
			Action onCloseCallback;
			if ((onCloseCallback = <>9__1) == null)
			{
				onCloseCallback = (<>9__1 = delegate()
				{
					EventSystem.Instance.Emit<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, true, EActivityViewState.Global, new bool?(true));
					this.InTurntableRun = false;
					if (currentRoundId != lastSelectRoundId)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("TurntableActivity_Tips01", Array.Empty<object>());
					}
				});
			}
			ActivityTurntableController.ShowTurntableItemObtain(runResult, onCloseCallback);
			this.RefreshPanel();
			this.RefreshToggleItem();
		});
	}

	// Token: 0x040044B9 RID: 17593
	[Nullable(2)]
	protected ActivityTurntableData ActivityTurntableData;

	// Token: 0x040044BA RID: 17594
	[Nullable(2)]
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040044BB RID: 17595
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionalArea;

	// Token: 0x040044BC RID: 17596
	[Nullable(2)]
	private ActivityTurntableQuestItem QuestItem;

	// Token: 0x040044BD RID: 17597
	[Nullable(2)]
	private ActivityTurntableDailyPanel DailyPanel;

	// Token: 0x040044BE RID: 17598
	[Nullable(2)]
	private ActivityTurntableComponent Turntable;

	// Token: 0x040044BF RID: 17599
	[Nullable(2)]
	private ActivityTurntableComponent TurntableAnim;

	// Token: 0x040044C0 RID: 17600
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityTurntableToggleGroupItem, int> ToggleLayout;

	// Token: 0x040044C1 RID: 17601
	private int CurrentSelectRoundId = -1;

	// Token: 0x040044C2 RID: 17602
	private bool IsQuestLockTimeShow;

	// Token: 0x040044C3 RID: 17603
	private long QuestLockTime;

	// Token: 0x040044C4 RID: 17604
	private bool InTurntableRun;

	// Token: 0x040044C5 RID: 17605
	private int[][] TitleIdNameList = new int[][]
	{
		new int[]
		{
			1,
			2,
			3
		},
		new int[]
		{
			2,
			1,
			3
		},
		new int[]
		{
			3,
			1,
			2
		}
	};

	// Token: 0x040044C6 RID: 17606
	private readonly List<ActivitySubViewTurntable.ISpriteLoader> SpriteLoaderList = new List<ActivitySubViewTurntable.ISpriteLoader>();

	// Token: 0x040044C7 RID: 17607
	private readonly List<string[]> SpritePathList = new List<string[]>();

	// Token: 0x02006CE7 RID: 27879
	private interface ISpriteLoader
	{
		// Token: 0x170077CC RID: 30668
		// (get) Token: 0x0603FAD6 RID: 260822
		// (set) Token: 0x0603FAD7 RID: 260823
		UUISprite Sprite { get; set; }

		// Token: 0x170077CD RID: 30669
		// (get) Token: 0x0603FAD8 RID: 260824
		// (set) Token: 0x0603FAD9 RID: 260825
		int Index { get; set; }

		// Token: 0x170077CE RID: 30670
		// (get) Token: 0x0603FADA RID: 260826
		// (set) Token: 0x0603FADB RID: 260827
		bool IsCurrent { get; set; }
	}

	// Token: 0x02006CE8 RID: 27880
	[Nullable(0)]
	private class SpriteLoader : ActivitySubViewTurntable.ISpriteLoader
	{
		// Token: 0x170077CF RID: 30671
		// (get) Token: 0x0603FADC RID: 260828 RVA: 0x012A1372 File Offset: 0x0129F572
		// (set) Token: 0x0603FADD RID: 260829 RVA: 0x012A137A File Offset: 0x0129F57A
		public UUISprite Sprite { get; set; }

		// Token: 0x170077D0 RID: 30672
		// (get) Token: 0x0603FADE RID: 260830 RVA: 0x012A1383 File Offset: 0x0129F583
		// (set) Token: 0x0603FADF RID: 260831 RVA: 0x012A138B File Offset: 0x0129F58B
		public int Index { get; set; }

		// Token: 0x170077D1 RID: 30673
		// (get) Token: 0x0603FAE0 RID: 260832 RVA: 0x012A1394 File Offset: 0x0129F594
		// (set) Token: 0x0603FAE1 RID: 260833 RVA: 0x012A139C File Offset: 0x0129F59C
		public bool IsCurrent { get; set; }
	}

	// Token: 0x02006CE9 RID: 27881
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023C47 RID: 146503
		public const int PanelItem = 0;

		// Token: 0x04023C48 RID: 146504
		public const int TitleItem = 1;

		// Token: 0x04023C49 RID: 146505
		public const int PanelQuest = 2;

		// Token: 0x04023C4A RID: 146506
		public const int QuestItem = 3;

		// Token: 0x04023C4B RID: 146507
		public const int ToggleLayout = 4;

		// Token: 0x04023C4C RID: 146508
		public const int Turntable = 5;

		// Token: 0x04023C4D RID: 146509
		public const int Toggle = 6;

		// Token: 0x04023C4E RID: 146510
		public const int FunctionArea = 7;

		// Token: 0x04023C4F RID: 146511
		public const int TurntableAnim = 8;

		// Token: 0x04023C50 RID: 146512
		public const int Sprite01A = 9;

		// Token: 0x04023C51 RID: 146513
		public const int Sprite01B = 10;

		// Token: 0x04023C52 RID: 146514
		public const int Sprite02A = 11;

		// Token: 0x04023C53 RID: 146515
		public const int Sprite03A = 12;

		// Token: 0x04023C54 RID: 146516
		public const int SpriteIndex = 13;

		// Token: 0x04023C55 RID: 146517
		public const int PanelDaily = 14;
	}
}
