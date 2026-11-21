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

// Token: 0x020004BC RID: 1212
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingLevelDetailView : UiViewBase
{
	// Token: 0x06003CD6 RID: 15574 RVA: 0x00158131 File Offset: 0x00156331
	public GolemHackingLevelDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06003CD7 RID: 15575 RVA: 0x00158154 File Offset: 0x00156354
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

	// Token: 0x06003CD8 RID: 15576 RVA: 0x00158328 File Offset: 0x00156528
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingLevelDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingLevelDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003CD9 RID: 15577 RVA: 0x0015836C File Offset: 0x0015656C
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

	// Token: 0x06003CDA RID: 15578 RVA: 0x00158407 File Offset: 0x00156607
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06003CDB RID: 15579 RVA: 0x00158441 File Offset: 0x00156641
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.OnCloseRewardView));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06003CDC RID: 15580 RVA: 0x0015847B File Offset: 0x0015667B
	private CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = new Func<TItem, bool>(this.CheckLevelFinished)
		};
	}

	// Token: 0x06003CDD RID: 15581 RVA: 0x00158494 File Offset: 0x00156694
	private bool CheckLevelFinished(TItem data)
	{
		return GolemHackingController.Instance.GetActivityData().GetLevelInfo(this.CurLevelId).State == GolemCrackState.GolemCrackFinished;
	}

	// Token: 0x06003CDE RID: 15582 RVA: 0x001584B4 File Offset: 0x001566B4
	private void OnClickedBtn()
	{
		if (!GolemHackingController.Instance.GetActivityData().CheckIfInOpenTime())
		{
			GolemHackingController.Instance.CloseActivityView(new HashSet<int>(), true);
			return;
		}
		GolemHackingController.Instance.OpenGameplayView(new List<int>(this.CurLevelConfigId), new Action<bool>(this.OnGameplayEnd), false, new TOpenViewCallBack(this.OpenLogReport));
	}

	// Token: 0x06003CDF RID: 15583 RVA: 0x00158514 File Offset: 0x00156714
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

	// Token: 0x06003CE0 RID: 15584 RVA: 0x001585C8 File Offset: 0x001567C8
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

	// Token: 0x06003CE1 RID: 15585 RVA: 0x0015864C File Offset: 0x0015684C
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

	// Token: 0x06003CE2 RID: 15586 RVA: 0x0015884C File Offset: 0x00156A4C
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

	// Token: 0x06003CE3 RID: 15587 RVA: 0x001588EB File Offset: 0x00156AEB
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

	// Token: 0x06003CE4 RID: 15588 RVA: 0x00158922 File Offset: 0x00156B22
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		GolemHackingController.Instance.CloseActivityView(closeActivities, false);
	}

	// Token: 0x04003116 RID: 12566
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003117 RID: 12567
	protected GolemHackingLevelDetailToggle EasyItem;

	// Token: 0x04003118 RID: 12568
	protected GolemHackingLevelDetailToggleHard HardItem;

	// Token: 0x04003119 RID: 12569
	protected int CurLevelId;

	// Token: 0x0400311A RID: 12570
	protected int[] CurLevelConfigId = Array.Empty<int>();

	// Token: 0x0400311B RID: 12571
	protected bool IsInitShow = true;

	// Token: 0x0400311C RID: 12572
	protected bool IsHardMode;

	// Token: 0x0400311D RID: 12573
	protected bool NeedRefreshAfterPlay = true;

	// Token: 0x0400311E RID: 12574
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x0400311F RID: 12575
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x02006796 RID: 26518
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04022317 RID: 140055
		CaptionItem,
		// Token: 0x04022318 RID: 140056
		PanelEasy,
		// Token: 0x04022319 RID: 140057
		PanelHard,
		// Token: 0x0402231A RID: 140058
		TxtLevelCode,
		// Token: 0x0402231B RID: 140059
		TxtName,
		// Token: 0x0402231C RID: 140060
		TxtHardModelTitle,
		// Token: 0x0402231D RID: 140061
		TxtDesc,
		// Token: 0x0402231E RID: 140062
		RewardItem,
		// Token: 0x0402231F RID: 140063
		Btn,
		// Token: 0x04022320 RID: 140064
		LockItem,
		// Token: 0x04022321 RID: 140065
		RedDotItem
	}
}
