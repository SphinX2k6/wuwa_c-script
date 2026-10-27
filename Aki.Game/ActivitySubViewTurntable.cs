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

// Token: 0x02001532 RID: 5426
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewTurntable : ActivitySubViewBase
{
	// Token: 0x06009AE0 RID: 39648 RVA: 0x00217E20 File Offset: 0x00216020
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

	// Token: 0x06009AE1 RID: 39649 RVA: 0x0021803D File Offset: 0x0021623D
	protected override void OnSetData()
	{
		this.ActivityTurntableData = (this.ActivityBaseData as ActivityTurntableData);
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x00218050 File Offset: 0x00216250
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTurntable.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTurntable.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x00218094 File Offset: 0x00216294
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

	// Token: 0x06009AE4 RID: 39652 RVA: 0x00218110 File Offset: 0x00216310
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.TurntableStartRun, new Action<int>(this.OnTurntableStartRun));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06009AE5 RID: 39653 RVA: 0x00218174 File Offset: 0x00216374
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TurntableStartRun, new Action<int>(this.OnTurntableStartRun));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
	}

	// Token: 0x06009AE6 RID: 39654 RVA: 0x002181D8 File Offset: 0x002163D8
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

	// Token: 0x06009AE7 RID: 39655 RVA: 0x00218242 File Offset: 0x00216442
	protected override void OnBeforeDestroy()
	{
		this.SpriteLoaderList.Clear();
		this.SpritePathList.Clear();
	}

	// Token: 0x06009AE8 RID: 39656 RVA: 0x0021825A File Offset: 0x0021645A
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06009AE9 RID: 39657 RVA: 0x00218262 File Offset: 0x00216462
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

	// Token: 0x06009AEA RID: 39658 RVA: 0x00218288 File Offset: 0x00216488
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

	// Token: 0x06009AEB RID: 39659 RVA: 0x002182E6 File Offset: 0x002164E6
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

	// Token: 0x06009AEC RID: 39660 RVA: 0x00218314 File Offset: 0x00216514
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

	// Token: 0x06009AED RID: 39661 RVA: 0x00218340 File Offset: 0x00216540
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

	// Token: 0x06009AEE RID: 39662 RVA: 0x0021850C File Offset: 0x0021670C
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

	// Token: 0x06009AEF RID: 39663 RVA: 0x00218574 File Offset: 0x00216774
	private string GetRemainQuestUnlockTimeText(long endTime)
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = Math.Max((double)endTime - serverTime, 1.0);
		ValueTuple<CommonDefine.ETimeType, CommonDefine.ETimeType> questLockTimeTypeData = this.GetQuestLockTimeTypeData(num);
		return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?(questLockTimeTypeData.Item1), new CommonDefine.ETimeType?(questLockTimeTypeData.Item2)).CountDownText ?? "";
	}

	// Token: 0x06009AF0 RID: 39664 RVA: 0x002185D8 File Offset: 0x002167D8
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

	// Token: 0x06009AF1 RID: 39665 RVA: 0x00218628 File Offset: 0x00216828
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

	// Token: 0x06009AF2 RID: 39666 RVA: 0x0021865C File Offset: 0x0021685C
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

	// Token: 0x06009AF3 RID: 39667 RVA: 0x002186C7 File Offset: 0x002168C7
	private void RefreshFunctionalFinished()
	{
		this.FunctionalArea.FunctionButton.SetActive(false);
		this.FunctionalArea.SetPanelConditionVisible(false);
		this.FunctionalArea.SetActivatePanelConditionVisible(true);
	}

	// Token: 0x06009AF4 RID: 39668 RVA: 0x002186F2 File Offset: 0x002168F2
	private void RefreshFunctionalLock(string textId)
	{
		this.FunctionalArea.FunctionButton.SetActive(false);
		this.FunctionalArea.SetPanelConditionVisible(true);
		this.FunctionalArea.SetLockTextByTextId(textId, Array.Empty<string>());
		this.FunctionalArea.SetActivatePanelConditionVisible(false);
	}

	// Token: 0x06009AF5 RID: 39669 RVA: 0x0021872E File Offset: 0x0021692E
	private void RefreshFunctionalRun()
	{
		this.FunctionalArea.FunctionButton.SetActive(true);
		this.FunctionalArea.SetPanelConditionVisible(false);
		this.FunctionalArea.SetActivatePanelConditionVisible(false);
	}

	// Token: 0x06009AF6 RID: 39670 RVA: 0x00218759 File Offset: 0x00216959
	private ActivityTurntableToggleGroupItem InitToggleItem()
	{
		return new ActivityTurntableToggleGroupItem
		{
			ToggleCallBack = new Action<int, bool>(this.ToggleCallBack)
		};
	}

	// Token: 0x06009AF7 RID: 39671 RVA: 0x00218774 File Offset: 0x00216974
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

	// Token: 0x06009AF8 RID: 39672 RVA: 0x002187C8 File Offset: 0x002169C8
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

	// Token: 0x06009AF9 RID: 39673 RVA: 0x002187ED File Offset: 0x002169ED
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

	// Token: 0x06009AFA RID: 39674 RVA: 0x0021880C File Offset: 0x00216A0C
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

	// Token: 0x06009AFB RID: 39675 RVA: 0x0021895C File Offset: 0x00216B5C
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

	// Token: 0x06009AFC RID: 39676 RVA: 0x002189B0 File Offset: 0x00216BB0
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

	// Token: 0x06009AFD RID: 39677 RVA: 0x00218A0C File Offset: 0x00216C0C
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

	// Token: 0x06009AFE RID: 39678 RVA: 0x00218A60 File Offset: 0x00216C60
	public override void OnCommonViewStateChange(bool show)
	{
		string sequenceName = show ? "TurnTableOut" : "TurnTableIn";
		this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, true, null, false);
	}

	// Token: 0x06009AFF RID: 39679 RVA: 0x00218A94 File Offset: 0x00216C94
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

	// Token: 0x04004413 RID: 17427
	[Nullable(2)]
	protected ActivityTurntableData ActivityTurntableData;

	// Token: 0x04004414 RID: 17428
	[Nullable(2)]
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004415 RID: 17429
	[Nullable(2)]
	private ActivityFunctionalTypeA FunctionalArea;

	// Token: 0x04004416 RID: 17430
	[Nullable(2)]
	private ActivityTurntableQuestItem QuestItem;

	// Token: 0x04004417 RID: 17431
	[Nullable(2)]
	private ActivityTurntableDailyPanel DailyPanel;

	// Token: 0x04004418 RID: 17432
	[Nullable(2)]
	private ActivityTurntableComponent Turntable;

	// Token: 0x04004419 RID: 17433
	[Nullable(2)]
	private ActivityTurntableComponent TurntableAnim;

	// Token: 0x0400441A RID: 17434
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<ActivityTurntableToggleGroupItem, int> ToggleLayout;

	// Token: 0x0400441B RID: 17435
	private int CurrentSelectRoundId = -1;

	// Token: 0x0400441C RID: 17436
	private bool IsQuestLockTimeShow;

	// Token: 0x0400441D RID: 17437
	private long QuestLockTime;

	// Token: 0x0400441E RID: 17438
	private bool InTurntableRun;

	// Token: 0x0400441F RID: 17439
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

	// Token: 0x04004420 RID: 17440
	private readonly List<ActivitySubViewTurntable.ISpriteLoader> SpriteLoaderList = new List<ActivitySubViewTurntable.ISpriteLoader>();

	// Token: 0x04004421 RID: 17441
	private readonly List<string[]> SpritePathList = new List<string[]>();

	// Token: 0x02007B5C RID: 31580
	private interface ISpriteLoader
	{
		// Token: 0x1700A02E RID: 41006
		// (get) Token: 0x060496AF RID: 300719
		// (set) Token: 0x060496B0 RID: 300720
		UUISprite Sprite { get; set; }

		// Token: 0x1700A02F RID: 41007
		// (get) Token: 0x060496B1 RID: 300721
		// (set) Token: 0x060496B2 RID: 300722
		int Index { get; set; }

		// Token: 0x1700A030 RID: 41008
		// (get) Token: 0x060496B3 RID: 300723
		// (set) Token: 0x060496B4 RID: 300724
		bool IsCurrent { get; set; }
	}

	// Token: 0x02007B5D RID: 31581
	[Nullable(0)]
	private class SpriteLoader : ActivitySubViewTurntable.ISpriteLoader
	{
		// Token: 0x1700A031 RID: 41009
		// (get) Token: 0x060496B5 RID: 300725 RVA: 0x012FE05A File Offset: 0x012FC25A
		// (set) Token: 0x060496B6 RID: 300726 RVA: 0x012FE062 File Offset: 0x012FC262
		public UUISprite Sprite { get; set; }

		// Token: 0x1700A032 RID: 41010
		// (get) Token: 0x060496B7 RID: 300727 RVA: 0x012FE06B File Offset: 0x012FC26B
		// (set) Token: 0x060496B8 RID: 300728 RVA: 0x012FE073 File Offset: 0x012FC273
		public int Index { get; set; }

		// Token: 0x1700A033 RID: 41011
		// (get) Token: 0x060496B9 RID: 300729 RVA: 0x012FE07C File Offset: 0x012FC27C
		// (set) Token: 0x060496BA RID: 300730 RVA: 0x012FE084 File Offset: 0x012FC284
		public bool IsCurrent { get; set; }
	}

	// Token: 0x02007B5E RID: 31582
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402890C RID: 166156
		public const int PanelItem = 0;

		// Token: 0x0402890D RID: 166157
		public const int TitleItem = 1;

		// Token: 0x0402890E RID: 166158
		public const int PanelQuest = 2;

		// Token: 0x0402890F RID: 166159
		public const int QuestItem = 3;

		// Token: 0x04028910 RID: 166160
		public const int ToggleLayout = 4;

		// Token: 0x04028911 RID: 166161
		public const int Turntable = 5;

		// Token: 0x04028912 RID: 166162
		public const int Toggle = 6;

		// Token: 0x04028913 RID: 166163
		public const int FunctionArea = 7;

		// Token: 0x04028914 RID: 166164
		public const int TurntableAnim = 8;

		// Token: 0x04028915 RID: 166165
		public const int Sprite01A = 9;

		// Token: 0x04028916 RID: 166166
		public const int Sprite01B = 10;

		// Token: 0x04028917 RID: 166167
		public const int Sprite02A = 11;

		// Token: 0x04028918 RID: 166168
		public const int Sprite03A = 12;

		// Token: 0x04028919 RID: 166169
		public const int SpriteIndex = 13;

		// Token: 0x0402891A RID: 166170
		public const int PanelDaily = 14;
	}
}
