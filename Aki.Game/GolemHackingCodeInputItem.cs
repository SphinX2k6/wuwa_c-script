using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001010 RID: 4112
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingCodeInputItem : GridProxyAbstract<GolemHackingInputInfo>
{
	// Token: 0x06006977 RID: 26999 RVA: 0x00150A70 File Offset: 0x0014EC70
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

	// Token: 0x06006978 RID: 27000 RVA: 0x00150B5D File Offset: 0x0014ED5D
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEnded), false);
	}

	// Token: 0x06006979 RID: 27001 RVA: 0x00150B88 File Offset: 0x0014ED88
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

	// Token: 0x0600697A RID: 27002 RVA: 0x00150BF8 File Offset: 0x0014EDF8
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

	// Token: 0x0600697B RID: 27003 RVA: 0x00150D78 File Offset: 0x0014EF78
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

	// Token: 0x0600697C RID: 27004 RVA: 0x00150E30 File Offset: 0x0014F030
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

	// Token: 0x0600697D RID: 27005 RVA: 0x00150E53 File Offset: 0x0014F053
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

	// Token: 0x0600697E RID: 27006 RVA: 0x00150E7A File Offset: 0x0014F07A
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

	// Token: 0x0400309E RID: 12446
	private const int INTERVAL_TIME = 80;

	// Token: 0x0400309F RID: 12447
	public Action OnBarAnimEnd;

	// Token: 0x040030A0 RID: 12448
	protected GolemHackingInputInfo InputData;

	// Token: 0x040030A1 RID: 12449
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x040030A2 RID: 12450
	protected TimerHandle TimerHandle;

	// Token: 0x0200760A RID: 30218
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026FEC RID: 159724
		PanelEmpty,
		// Token: 0x04026FED RID: 159725
		PanelEnterCode,
		// Token: 0x04026FEE RID: 159726
		TxtEnter,
		// Token: 0x04026FEF RID: 159727
		PanelReadyEnter,
		// Token: 0x04026FF0 RID: 159728
		TxtReadyCode,
		// Token: 0x04026FF1 RID: 159729
		PanelLockState
	}
}
