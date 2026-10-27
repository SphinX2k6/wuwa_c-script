using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001008 RID: 4104
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingLevelDetailView : UiViewBase
{
	// Token: 0x06006941 RID: 26945 RVA: 0x0014F809 File Offset: 0x0014DA09
	public GolemHackingLevelDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006942 RID: 26946 RVA: 0x0014F82C File Offset: 0x0014DA2C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickedBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006943 RID: 26947 RVA: 0x0014FA00 File Offset: 0x0014DC00
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingLevelDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingLevelDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006944 RID: 26948 RVA: 0x0014FA44 File Offset: 0x0014DC44
	protected override void OnBeforeShow()
	{
		bool flag = this.EasyItem.RefreshState(false);
		this.HardItem.RefreshState(false);
		if (this.NeedRefreshAfterPlay)
		{
			this.EasyItem.SetSelected(!flag);
			this.HardItem.SetSelected(flag);
			if (flag)
			{
				this.HardItem.SetFocusGamepad();
			}
		}
		else if (this.IsInitShow)
		{
			this.IsInitShow = false;
			this.EasyItem.SetSelected(true);
			this.HardItem.SetSelected(false);
		}
		if (this.CurLevelId != 0)
		{
			this.OnClickedToggle(this.CurLevelId, this.IsHardMode);
		}
	}

	// Token: 0x06006945 RID: 26949 RVA: 0x0014FADF File Offset: 0x0014DCDF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06006946 RID: 26950 RVA: 0x0014FB19 File Offset: 0x0014DD19
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06006947 RID: 26951 RVA: 0x0014FB53 File Offset: 0x0014DD53
	private CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = new Func<TItem, bool>(this.CheckLevelFinished)
		};
	}

	// Token: 0x06006948 RID: 26952 RVA: 0x0014FB6C File Offset: 0x0014DD6C
	private bool CheckLevelFinished(TItem data)
	{
		return GolemHackingController.Instance.GetActivityData().GetLevelInfo(this.CurLevelId).State == GolemCrackState.GolemCrackFinished;
	}

	// Token: 0x06006949 RID: 26953 RVA: 0x0014FB8C File Offset: 0x0014DD8C
	private void OnClickedBtn()
	{
		if (!GolemHackingController.Instance.GetActivityData().CheckIfInOpenTime())
		{
			GolemHackingController.Instance.CloseActivityView(new HashSet<int>(), true);
			return;
		}
		GolemHackingController.Instance.OpenGameplayView(new List<int>(this.CurLevelConfigId), new Action<bool>(this.OnGameplayEnd), false, new TOpenViewCallBack(this.OpenLogReport));
	}

	// Token: 0x0600694A RID: 26954 RVA: 0x0014FBEC File Offset: 0x0014DDEC
	private void OpenLogReport(bool success, int _)
	{
		GolemHackingController.Instance.IsActivityOpen = true;
		int activityOpenTime = (int)TimeUtil.Instance.GetServerTime();
		GolemHackingController.Instance.ActivityOpenTime = activityOpenTime;
		GolemHackingController.Instance.CacheLevelId = this.CurLevelId;
		GolemHackingController.Instance.CacheHardMode = this.IsHardMode;
		GolemHackingStartEvent golemHackingStartEvent = new GolemHackingStartEvent();
		golemHackingStartEvent.i_id = this.CurLevelId;
		golemHackingStartEvent.i_type = (this.IsHardMode ? 2 : 1);
		golemHackingStartEvent.s_trace_id = activityOpenTime.ToString();
		bool flag = GolemHackingController.Instance.GetActivityData().GetLevelInfo(this.CurLevelId).State == GolemCrackState.GolemCrackFinished;
		golemHackingStartEvent.i_first_pass = ((!flag) ? 1 : 0);
		LogReportController.Instance.LogReport(golemHackingStartEvent);
	}

	// Token: 0x0600694B RID: 26955 RVA: 0x0014FCA0 File Offset: 0x0014DEA0
	private void OnCloseRewardView()
	{
		if (!this.NeedRefreshAfterPlay)
		{
			return;
		}
		EventSystem.Instance.Emit(EEventName.OnGolemHackingLevelStateUpdate);
		if (this.IsHardMode)
		{
			GolemHackingController.Instance.CacheRewardFocus = true;
			base.CloseMe(null);
			return;
		}
		bool flag = this.EasyItem.RefreshState(false);
		this.HardItem.RefreshState(false);
		this.EasyItem.SetSelected(!flag);
		this.HardItem.SetSelected(flag);
		if (flag)
		{
			this.HardItem.SetFocusGamepad();
		}
	}

	// Token: 0x0600694C RID: 26956 RVA: 0x0014FD24 File Offset: 0x0014DF24
	private void OnClickedToggle(int levelId, bool isHard)
	{
		this.IsHardMode = isHard;
		GolemHackingLevelInfo levelInfo = GolemHackingController.Instance.GetActivityData().GetLevelInfo(levelId);
		this.NeedRefreshAfterPlay = (levelInfo.State == GolemCrackState.GolemCrackUnlocked);
		bool flag = levelInfo.State == GolemCrackState.GolemCrackLocked;
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(!flag);
		}
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		this.CurLevelId = levelId;
		GolemCrack value = ConfigGolemCrackById.GetConfig(levelId, true).Value;
		int[] array = new int[value.ConfigIdsLength];
		for (int i = 0; i < value.ConfigIdsLength; i++)
		{
			array[i] = value.ConfigIds(i);
		}
		this.CurLevelConfigId = array;
		string text;
		if (levelId < 10)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(levelId);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(levelId);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string newText = text;
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetText(newText, true);
		}
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			text3.ShowTextNew(value.Title);
		}
		UUIText text4 = base.GetText(6);
		if (text4 != null)
		{
			text4.ShowTextNew(value.Desc);
		}
		UUIText text5 = base.GetText(5);
		if (text5 != null)
		{
			text5.SetUIActive(true);
		}
		string key = isHard ? "PrefabTextItem_3863107273_Text" : "PrefabTextItem_126203885_Text";
		UUIText text6 = base.GetText(5);
		if (text6 != null)
		{
			text6.ShowTextNew(key);
		}
		if (this.EasyItem.LevelId != levelId)
		{
			this.EasyItem.SetSelected(false);
		}
		else
		{
			this.HardItem.SetSelected(false);
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.DropId);
		this.RewardListComponent.RefreshItemLayout(dropPackagePreviewItemList, null);
		GolemHackingActivityData activityData = GolemHackingController.Instance.GetActivityData();
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(activityData.CheckLevelRedDot(levelId));
		}
		this.DoAnimLogic();
	}

	// Token: 0x0600694D RID: 26957 RVA: 0x0014FF24 File Offset: 0x0014E124
	protected void DoAnimLogic()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Switch_ToRed"))
		{
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.StopSequenceByKey("Switch_ToRed", false, false);
			}
		}
		LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
		if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("Switch_ToBlue"))
		{
			LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
			if (sequencePlayer4 != null)
			{
				sequencePlayer4.StopSequenceByKey("Switch_ToBlue", false, false);
			}
		}
		string sequenceName = this.IsHardMode ? "Switch_ToRed" : "Switch_ToBlue";
		LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
		if (sequencePlayer5 == null)
		{
			return;
		}
		sequencePlayer5.PlayOrReplaySequenceByName(sequenceName, false, null);
	}

	// Token: 0x0600694E RID: 26958 RVA: 0x0014FFC3 File Offset: 0x0014E1C3
	private void OnGameplayEnd(bool isSuccess)
	{
		GolemHackingController.Instance.IsActivityOpen = false;
		if (!GolemHackingController.Instance.GetActivityData().CheckIfInOpenTime())
		{
			return;
		}
		if (isSuccess)
		{
			GolemHackingController.Instance.RequestGolemCrackUpdate(this.CurLevelId).Forget<bool>();
		}
	}

	// Token: 0x0600694F RID: 26959 RVA: 0x0014FFFA File Offset: 0x0014E1FA
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		GolemHackingController.Instance.CloseActivityView(closeActivities, false);
	}

	// Token: 0x0400307D RID: 12413
	protected PopupCaptionItem CaptionItem;

	// Token: 0x0400307E RID: 12414
	protected GolemHackingLevelDetailToggle EasyItem;

	// Token: 0x0400307F RID: 12415
	protected GolemHackingLevelDetailToggleHard HardItem;

	// Token: 0x04003080 RID: 12416
	protected int CurLevelId;

	// Token: 0x04003081 RID: 12417
	protected int[] CurLevelConfigId = Array.Empty<int>();

	// Token: 0x04003082 RID: 12418
	protected bool IsInitShow = true;

	// Token: 0x04003083 RID: 12419
	protected bool IsHardMode;

	// Token: 0x04003084 RID: 12420
	protected bool NeedRefreshAfterPlay = true;

	// Token: 0x04003085 RID: 12421
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x04003086 RID: 12422
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x02007602 RID: 30210
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026FCC RID: 159692
		CaptionItem,
		// Token: 0x04026FCD RID: 159693
		PanelEasy,
		// Token: 0x04026FCE RID: 159694
		PanelHard,
		// Token: 0x04026FCF RID: 159695
		TxtLevelCode,
		// Token: 0x04026FD0 RID: 159696
		TxtName,
		// Token: 0x04026FD1 RID: 159697
		TxtHardModelTitle,
		// Token: 0x04026FD2 RID: 159698
		TxtDesc,
		// Token: 0x04026FD3 RID: 159699
		RewardItem,
		// Token: 0x04026FD4 RID: 159700
		Btn,
		// Token: 0x04026FD5 RID: 159701
		LockItem,
		// Token: 0x04026FD6 RID: 159702
		RedDotItem
	}
}
