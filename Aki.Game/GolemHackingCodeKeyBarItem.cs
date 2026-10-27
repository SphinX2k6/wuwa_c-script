using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001011 RID: 4113
public class GolemHackingCodeKeyBarItem : GridProxyAbstract<EGolemHackingBarState>
{
	// Token: 0x06006981 RID: 27009 RVA: 0x00150EE4 File Offset: 0x0014F0E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006982 RID: 27010 RVA: 0x00150F4D File Offset: 0x0014F14D
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x06006983 RID: 27011 RVA: 0x00150F78 File Offset: 0x0014F178
	public override void Refresh(EGolemHackingBarState data, bool isSelected, int gridIndex)
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Success"))
		{
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.StopSequenceByKey("Success", false, false);
			}
		}
		LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
		if (sequencePlayer3 != null && sequencePlayer3.IsPlayingSequence("Fail"))
		{
			LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
			if (sequencePlayer4 != null)
			{
				sequencePlayer4.StopSequenceByKey("Fail", false, false);
			}
		}
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(data == EGolemHackingBarState.Success);
		}
		UUISprite sprite2 = base.GetSprite(1);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(data == EGolemHackingBarState.Fail);
		}
		if (this.CurState != data && this.CurState == EGolemHackingBarState.Default)
		{
			string sequenceName = (data == EGolemHackingBarState.Success) ? "Success" : "Fail";
			LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
			if (sequencePlayer5 != null)
			{
				sequencePlayer5.PlayOrReplaySequenceByName(sequenceName, false, null);
			}
		}
		else if (data != EGolemHackingBarState.Default)
		{
			this.OnSequenceClose("");
		}
		this.CurState = data;
	}

	// Token: 0x06006984 RID: 27012 RVA: 0x00151068 File Offset: 0x0014F268
	[NullableContext(1)]
	private void OnSequenceClose(string _)
	{
		Action onAnimEndCallback = this.OnAnimEndCallback;
		if (onAnimEndCallback == null)
		{
			return;
		}
		onAnimEndCallback();
	}

	// Token: 0x040030A3 RID: 12451
	[Nullable(2)]
	public Action OnAnimEndCallback;

	// Token: 0x040030A4 RID: 12452
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x040030A5 RID: 12453
	protected EGolemHackingBarState CurState;

	// Token: 0x0200760B RID: 30219
	private enum EDefine
	{
		// Token: 0x04026FF3 RID: 159731
		Success,
		// Token: 0x04026FF4 RID: 159732
		Fail
	}
}
