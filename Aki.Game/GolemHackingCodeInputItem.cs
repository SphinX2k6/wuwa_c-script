using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004C4 RID: 1220
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingCodeInputItem : GridProxyAbstract<GolemHackingInputInfo>
{
	// Token: 0x06003D0C RID: 15628 RVA: 0x00159398 File Offset: 0x00157598
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003D0D RID: 15629 RVA: 0x00159485 File Offset: 0x00157685
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEnded), false);
	}

	// Token: 0x06003D0E RID: 15630 RVA: 0x001594B0 File Offset: 0x001576B0
	[NullableContext(1)]
	public override void Refresh(GolemHackingInputInfo data, bool isSelected, int gridIndex)
	{
		GolemHackingInputInfo inputData = this.InputData;
		EGolemHackingInputState? oldState = (inputData != null) ? new EGolemHackingInputState?(inputData.State) : null;
		this.InputData = data;
		if (this.TimerHandle != null)
		{
			if (this.TimerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}
		this.PlayAnim(oldState);
		this.UpdateInfo();
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x00159520 File Offset: 0x00157720
	protected void PlayAnim(EGolemHackingInputState? oldState)
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Sle"))
		{
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.StopSequenceByKey("Sle", false, true);
			}
		}
		LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
		if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("Reset"))
		{
			LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
			if (sequencePlayer4 != null)
			{
				sequencePlayer4.StopSequenceByKey("Reset", false, true);
			}
		}
		LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
		if (sequencePlayer5 != null && sequencePlayer5.IsPlayingSequence("Success"))
		{
			LevelSequencePlayer sequencePlayer6 = this.SequencePlayer;
			if (sequencePlayer6 != null)
			{
				sequencePlayer6.StopSequenceByKey("Success", false, true);
			}
		}
		LevelSequencePlayer sequencePlayer7 = this.SequencePlayer;
		if (sequencePlayer7 != null && sequencePlayer7.IsPlayingSequence("Fail"))
		{
			LevelSequencePlayer sequencePlayer8 = this.SequencePlayer;
			if (sequencePlayer8 != null)
			{
				sequencePlayer8.StopSequenceByKey("Fail", false, true);
			}
		}
		if (this.InputData.AnimIndex <= 0)
		{
			if (!(oldState != EGolemHackingInputState.Enterring) && this.InputData.State == EGolemHackingInputState.Occupy)
			{
				LevelSequencePlayer sequencePlayer9 = this.SequencePlayer;
				if (sequencePlayer9 == null)
				{
					return;
				}
				sequencePlayer9.PlayOrReplaySequenceByName("Sle", false, null);
			}
			return;
		}
		int num = 80 * (this.InputData.AnimIndex - 1);
		if (num != 0)
		{
			this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				LevelSequencePlayer sequencePlayer11 = this.SequencePlayer;
				if (sequencePlayer11 == null)
				{
					return;
				}
				sequencePlayer11.PlayOrReplaySequenceByName(this.InputData.AnimName, false, null);
			}, (float)num, null, null, true, 1f);
			return;
		}
		LevelSequencePlayer sequencePlayer10 = this.SequencePlayer;
		if (sequencePlayer10 == null)
		{
			return;
		}
		sequencePlayer10.PlayOrReplaySequenceByName(this.InputData.AnimName, false, null);
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x001596A0 File Offset: 0x001578A0
	public void UpdateInfo()
	{
		EGolemHackingInputState state = this.InputData.State;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(state == EGolemHackingInputState.Empty);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(state == EGolemHackingInputState.Enterring);
		}
		UUIItem item3 = base.GetItem(1);
		if (item3 != null)
		{
			item3.SetUIActive(state == EGolemHackingInputState.Occupy);
		}
		UUIItem item4 = base.GetItem(5);
		if (item4 != null)
		{
			item4.SetUIActive(state == EGolemHackingInputState.Block);
		}
		if (state == EGolemHackingInputState.Empty || state == EGolemHackingInputState.Block)
		{
			return;
		}
		if (state == EGolemHackingInputState.Occupy)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(this.InputData.Code, true);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(this.InputData.Code, true);
			return;
		}
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x00159758 File Offset: 0x00157958
	[NullableContext(1)]
	public void EnterInputCode(string code)
	{
		if (this.InputData.State == EGolemHackingInputState.Enterring)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText(code, true);
		}
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x0015977B File Offset: 0x0015797B
	public void ClearInputCode()
	{
		if (this.InputData.State == EGolemHackingInputState.Enterring)
		{
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText("", true);
		}
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x001597A2 File Offset: 0x001579A2
	[NullableContext(1)]
	private void OnSequenceEnded(string sequenceName)
	{
		if (sequenceName == "Success" || sequenceName == "Fail")
		{
			Action onBarAnimEnd = this.OnBarAnimEnd;
			if (onBarAnimEnd == null)
			{
				return;
			}
			onBarAnimEnd();
		}
	}

	// Token: 0x04003137 RID: 12599
	private const int INTERVAL_TIME = 80;

	// Token: 0x04003138 RID: 12600
	public Action OnBarAnimEnd;

	// Token: 0x04003139 RID: 12601
	protected GolemHackingInputInfo InputData;

	// Token: 0x0400313A RID: 12602
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x0400313B RID: 12603
	protected TimerHandle TimerHandle;

	// Token: 0x0200679E RID: 26526
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04022337 RID: 140087
		PanelEmpty,
		// Token: 0x04022338 RID: 140088
		PanelEnterCode,
		// Token: 0x04022339 RID: 140089
		TxtEnter,
		// Token: 0x0402233A RID: 140090
		PanelReadyEnter,
		// Token: 0x0402233B RID: 140091
		TxtReadyCode,
		// Token: 0x0402233C RID: 140092
		PanelLockState
	}
}
