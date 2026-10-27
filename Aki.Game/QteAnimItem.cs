using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002307 RID: 8967
[NullableContext(1)]
[Nullable(0)]
public class QteAnimItem
{
	// Token: 0x06011B46 RID: 72518 RVA: 0x0045A362 File Offset: 0x00458562
	public void Init(UUIItem item)
	{
		this.Item = item;
		this.LevelSequencePlayer = new LevelSequencePlayer(this.Item);
	}

	// Token: 0x06011B47 RID: 72519 RVA: 0x0045A37C File Offset: 0x0045857C
	public void StartAnim(float delay = 0f)
	{
		this.StopDelayTimer();
		if (delay > 20f)
		{
			this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.DelayTimer = null;
				this.StartAnim(0f);
			}, delay, null, null, true, 1f);
			return;
		}
		this.CurAnimName = "Start";
		this.PlayAnim(this.CurAnimName);
		this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.DelayTimer = null;
			this.CurAnimName = "Loop";
			this.PlayAnim(this.CurAnimName);
		}, 400f, null, null, true, 1f);
	}

	// Token: 0x06011B48 RID: 72520 RVA: 0x0045A3FE File Offset: 0x004585FE
	public void StopAnim()
	{
		this.StopDelayTimer();
		if (this.CurAnimName != null)
		{
			this.LevelSequencePlayer.StopSequenceByKey(this.CurAnimName, false, false);
		}
		this.CurAnimName = null;
		this.PlayAnim("Close");
	}

	// Token: 0x06011B49 RID: 72521 RVA: 0x0045A433 File Offset: 0x00458633
	public void PressAnim()
	{
		this.PlayAnim("Press");
	}

	// Token: 0x06011B4A RID: 72522 RVA: 0x0045A440 File Offset: 0x00458640
	private void PlayAnim(string animName)
	{
		this.LevelSequencePlayer.PlaySequencePurely(animName, false, false, null, null, false);
	}

	// Token: 0x06011B4B RID: 72523 RVA: 0x0045A466 File Offset: 0x00458666
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x06011B4C RID: 72524 RVA: 0x0045A488 File Offset: 0x00458688
	public void Clear()
	{
		this.StopDelayTimer();
	}

	// Token: 0x0400864E RID: 34382
	[Nullable(2)]
	private UUIItem Item;

	// Token: 0x0400864F RID: 34383
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008650 RID: 34384
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x04008651 RID: 34385
	[Nullable(2)]
	private string CurAnimName;

	// Token: 0x04008652 RID: 34386
	private const int START_ANIM_TIME = 400;

	// Token: 0x04008653 RID: 34387
	private const string ANIM_START = "Start";

	// Token: 0x04008654 RID: 34388
	private const string ANIM_LOOP = "Loop";

	// Token: 0x04008655 RID: 34389
	private const string ANIM_CLOSE = "Close";

	// Token: 0x04008656 RID: 34390
	private const string ANIM_PRESS = "Press";
}
