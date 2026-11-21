using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020004CA RID: 1226
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingLevelGroupTab : GridProxyAbstract<GolemHackingLevelGroupInfo>
{
	// Token: 0x06003D48 RID: 15688 RVA: 0x0015AAE0 File Offset: 0x00158CE0
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITextureTransitionComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06003D49 RID: 15689 RVA: 0x0015ACB2 File Offset: 0x00158EB2
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06003D4A RID: 15690 RVA: 0x0015ACC8 File Offset: 0x00158EC8
	public override void Refresh(GolemHackingLevelGroupInfo data, bool isSelected, int gridIndex)
	{
		this.CurData = data;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(gridIndex % 2 == 0);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(gridIndex % 2 != 0);
		}
		GolemHackingActivityData activityData = GolemHackingController.Instance.GetActivityData();
		ValueTuple<EGolemHackingGroupState, int, int> groupState = activityData.GetGroupState(data.Group);
		EGolemHackingGroupState item3 = groupState.Item1;
		int item4 = groupState.Item2;
		int item5 = groupState.Item3;
		UUIItem item6 = base.GetItem(10);
		if (item6 != null)
		{
			item6.SetUIActive(activityData.CheckGroupRedDot(data.Group));
		}
		this.RefreshTexTransition(item3).Forget();
		UUIItem item7 = base.GetItem(7);
		if (item7 != null)
		{
			item7.SetUIActive(item3 == EGolemHackingGroupState.Clear);
		}
		UUIItem item8 = base.GetItem(8);
		if (item8 != null)
		{
			item8.SetUIActive(item3 == EGolemHackingGroupState.Locked);
		}
		GolemCrack value = ConfigGolemCrackById.GetConfig(data.LevelGroup[0], true).Value;
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.ShowTextNew(value.Title);
		}
		UUIArtText artText = base.GetArtText(5);
		if (artText != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Group + 1);
			artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		UUIText text2 = base.GetText(6);
		if (text2 != null)
		{
			text2.SetUIActive(item3 == EGolemHackingGroupState.Normal);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "IntrusionProtocolActivity_LevelProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			item4,
			item5
		}));
		UUIText text3 = base.GetText(9);
		if (text3 != null)
		{
			text3.SetUIActive(item3 == EGolemHackingGroupState.Locked);
		}
		if (item3 == EGolemHackingGroupState.Locked)
		{
			ValueTuple<bool, string> groupLockTxt = activityData.GetGroupLockTxt(data.Group);
			bool item9 = groupLockTxt.Item1;
			string item10 = groupLockTxt.Item2;
			this.NeedTick = item9;
			UUIText text4 = base.GetText(9);
			if (text4 != null)
			{
				text4.SetText(item10, true);
			}
		}
		this.DoAnimLogic();
	}

	// Token: 0x06003D4B RID: 15691 RVA: 0x0015AEA4 File Offset: 0x001590A4
	protected void DoAnimLogic()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("P_Start"))
		{
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.StopSequenceByKey("P_Glitch", false, false);
			}
		}
		LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
		if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("P_Glitch"))
		{
			LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
			if (sequencePlayer4 != null)
			{
				sequencePlayer4.StopSequenceByKey("P_Start", false, false);
			}
		}
		if (this.CurData.Group == 7)
		{
			if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.GolemHackingBonusLevelGroupPlayed, false))
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.GolemHackingBonusLevelGroupPlayed, true);
				LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
				if (sequencePlayer5 == null)
				{
					return;
				}
				sequencePlayer5.PlayOrReplaySequenceByName("P_Start", false, null);
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer6 = this.SequencePlayer;
				if (sequencePlayer6 == null)
				{
					return;
				}
				sequencePlayer6.PlayOrReplaySequenceByName("P_Glitch", false, null);
			}
		}
	}

	// Token: 0x06003D4C RID: 15692 RVA: 0x0015AF7C File Offset: 0x0015917C
	protected UniTask RefreshTexTransition(EGolemHackingGroupState curState)
	{
		GolemHackingLevelGroupTab.<RefreshTexTransition>d__9 <RefreshTexTransition>d__;
		<RefreshTexTransition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTexTransition>d__.<>4__this = this;
		<RefreshTexTransition>d__.curState = curState;
		<RefreshTexTransition>d__.<>1__state = -1;
		<RefreshTexTransition>d__.<>t__builder.Start<GolemHackingLevelGroupTab.<RefreshTexTransition>d__9>(ref <RefreshTexTransition>d__);
		return <RefreshTexTransition>d__.<>t__builder.Task;
	}

	// Token: 0x06003D4D RID: 15693 RVA: 0x0015AFC8 File Offset: 0x001591C8
	public void OnTick()
	{
		if (!this.NeedTick)
		{
			return;
		}
		GolemHackingActivityData activityData = GolemHackingController.Instance.GetActivityData();
		ValueTuple<bool, string> groupLockTxt = activityData.GetGroupLockTxt(this.CurData.Group);
		bool item = groupLockTxt.Item1;
		string item2 = groupLockTxt.Item2;
		this.NeedTick = item;
		if (!item)
		{
			activityData.CheckIsUnlockWhenTimeUnlock(this.CurData.Group);
			this.Refresh(this.CurData, false, base.GridIndex);
			return;
		}
		UUIText text = base.GetText(9);
		if (text == null)
		{
			return;
		}
		text.SetText(item2, true);
	}

	// Token: 0x06003D4E RID: 15694 RVA: 0x0015B04A File Offset: 0x0015924A
	private void OnClicked()
	{
		Action<GolemHackingLevelGroupInfo, int> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.CurData, base.GridIndex);
	}

	// Token: 0x04003157 RID: 12631
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GolemHackingLevelGroupInfo, int> OnClickedCallback;

	// Token: 0x04003158 RID: 12632
	public bool NeedTick;

	// Token: 0x04003159 RID: 12633
	protected GolemHackingLevelGroupInfo CurData;

	// Token: 0x0400315A RID: 12634
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x020067A4 RID: 26532
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04022357 RID: 140119
		PanelTopLine,
		// Token: 0x04022358 RID: 140120
		PanelBottomLine,
		// Token: 0x04022359 RID: 140121
		Btn,
		// Token: 0x0402235A RID: 140122
		TexState,
		// Token: 0x0402235B RID: 140123
		TxtTitle,
		// Token: 0x0402235C RID: 140124
		ArtTxt,
		// Token: 0x0402235D RID: 140125
		TxtProgress,
		// Token: 0x0402235E RID: 140126
		PanelFinishedState,
		// Token: 0x0402235F RID: 140127
		PanelLockState,
		// Token: 0x04022360 RID: 140128
		TxtLockTips,
		// Token: 0x04022361 RID: 140129
		RedDot
	}
}
