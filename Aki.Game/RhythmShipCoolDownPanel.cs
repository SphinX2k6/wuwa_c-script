using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200108C RID: 4236
[NullableContext(2)]
[Nullable(0)]
public class RhythmShipCoolDownPanel : UiPanelBase
{
	// Token: 0x06006E46 RID: 28230 RVA: 0x00167694 File Offset: 0x00165894
	protected override void OnBeforeCreate()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(false);
	}

	// Token: 0x06006E47 RID: 28231 RVA: 0x001676B8 File Offset: 0x001658B8
	public void PlayCoolDownSequence(TTimerAction callback)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		if (callback != null)
		{
			this.Callback = callback;
			this.CallbackHandle = TimerSystem.Instance.Delay(this.Callback, 3000f, null, null, true, 1f);
		}
	}

	// Token: 0x06006E48 RID: 28232 RVA: 0x00167728 File Offset: 0x00165928
	public void StopCoolDownSequence()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopPlayingSequence(false, true);
		}
		if (this.CallbackHandle != null && TimerSystem.Instance.Has(this.CallbackHandle))
		{
			TimerSystem.Instance.Remove(this.CallbackHandle);
			this.CallbackHandle = null;
		}
		this.Callback = null;
	}

	// Token: 0x04003306 RID: 13062
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003307 RID: 13063
	private TTimerAction Callback;

	// Token: 0x04003308 RID: 13064
	private TimerHandle CallbackHandle;
}
