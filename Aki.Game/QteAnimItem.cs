using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020017EB RID: 6123
[NullableContext(1)]
[Nullable(0)]
public class QteAnimItem
{
	// Token: 0x0600EFE1 RID: 61409 RVA: 0x00467172 File Offset: 0x00465372
	public void Init(UUIItem item)
	{
		this.Item = item;
		this.LevelSequencePlayer = new LevelSequencePlayer(this.Item);
	}

	// Token: 0x0600EFE2 RID: 61410 RVA: 0x0046718C File Offset: 0x0046538C
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

	// Token: 0x0600EFE3 RID: 61411 RVA: 0x0046720E File Offset: 0x0046540E
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

	// Token: 0x0600EFE4 RID: 61412 RVA: 0x00467243 File Offset: 0x00465443
	public void PressAnim()
	{
		this.PlayAnim("Press");
	}

	// Token: 0x0600EFE5 RID: 61413 RVA: 0x00467250 File Offset: 0x00465450
	private void PlayAnim(string animName)
	{
		this.LevelSequencePlayer.PlaySequencePurely(animName, false, false, null, null, false);
	}

	// Token: 0x0600EFE6 RID: 61414 RVA: 0x00467276 File Offset: 0x00465476
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x0600EFE7 RID: 61415 RVA: 0x00467298 File Offset: 0x00465498
	public void Clear()
	{
		this.StopDelayTimer();
	}

	// Token: 0x0400878E RID: 34702
	[Nullable(2)]
	private UUIItem Item;

	// Token: 0x0400878F RID: 34703
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008790 RID: 34704
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x04008791 RID: 34705
	[Nullable(2)]
	private string CurAnimName;

	// Token: 0x04008792 RID: 34706
	private const int START_ANIM_TIME = 400;

	// Token: 0x04008793 RID: 34707
	private const string ANIM_START = "Start";

	// Token: 0x04008794 RID: 34708
	private const string ANIM_LOOP = "Loop";

	// Token: 0x04008795 RID: 34709
	private const string ANIM_CLOSE = "Close";

	// Token: 0x04008796 RID: 34710
	private const string ANIM_PRESS = "Press";
}
