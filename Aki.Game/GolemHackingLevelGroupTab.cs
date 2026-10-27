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

// Token: 0x02001016 RID: 4118
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingLevelGroupTab : GridProxyAbstract<GolemHackingLevelGroupInfo>
{
	// Token: 0x060069B3 RID: 27059 RVA: 0x001521B8 File Offset: 0x001503B8
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

	// Token: 0x060069B4 RID: 27060 RVA: 0x0015238A File Offset: 0x0015058A
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x060069B5 RID: 27061 RVA: 0x001523A0 File Offset: 0x001505A0
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

	// Token: 0x060069B6 RID: 27062 RVA: 0x0015257C File Offset: 0x0015077C
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

	// Token: 0x060069B7 RID: 27063 RVA: 0x00152654 File Offset: 0x00150854
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

	// Token: 0x060069B8 RID: 27064 RVA: 0x001526A0 File Offset: 0x001508A0
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

	// Token: 0x060069B9 RID: 27065 RVA: 0x00152722 File Offset: 0x00150922
	private void OnClicked()
	{
		Action<GolemHackingLevelGroupInfo, int> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.CurData, base.GridIndex);
	}

	// Token: 0x040030BE RID: 12478
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GolemHackingLevelGroupInfo, int> OnClickedCallback;

	// Token: 0x040030BF RID: 12479
	public bool NeedTick;

	// Token: 0x040030C0 RID: 12480
	protected GolemHackingLevelGroupInfo CurData;

	// Token: 0x040030C1 RID: 12481
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02007610 RID: 30224
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402700C RID: 159756
		PanelTopLine,
		// Token: 0x0402700D RID: 159757
		PanelBottomLine,
		// Token: 0x0402700E RID: 159758
		Btn,
		// Token: 0x0402700F RID: 159759
		TexState,
		// Token: 0x04027010 RID: 159760
		TxtTitle,
		// Token: 0x04027011 RID: 159761
		ArtTxt,
		// Token: 0x04027012 RID: 159762
		TxtProgress,
		// Token: 0x04027013 RID: 159763
		PanelFinishedState,
		// Token: 0x04027014 RID: 159764
		PanelLockState,
		// Token: 0x04027015 RID: 159765
		TxtLockTips,
		// Token: 0x04027016 RID: 159766
		RedDot
	}
}
