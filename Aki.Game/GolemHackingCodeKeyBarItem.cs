using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004C5 RID: 1221
public class GolemHackingCodeKeyBarItem : GridProxyAbstract<EGolemHackingBarState>
{
	// Token: 0x06003D16 RID: 15638 RVA: 0x0015980C File Offset: 0x00157A0C
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

	// Token: 0x06003D17 RID: 15639 RVA: 0x00159875 File Offset: 0x00157A75
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x001598A0 File Offset: 0x00157AA0
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

	// Token: 0x06003D19 RID: 15641 RVA: 0x00159990 File Offset: 0x00157B90
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

	// Token: 0x0400313C RID: 12604
	[Nullable(2)]
	public Action OnAnimEndCallback;

	// Token: 0x0400313D RID: 12605
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x0400313E RID: 12606
	protected EGolemHackingBarState CurState;

	// Token: 0x0200679F RID: 26527
	private enum EDefine
	{
		// Token: 0x0402233E RID: 140094
		Success,
		// Token: 0x0402233F RID: 140095
		Fail
	}
}
