using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000540 RID: 1344
[NullableContext(2)]
[Nullable(0)]
public class RhythmShipCoolDownPanel : UiPanelBase
{
	// Token: 0x060041DB RID: 16859 RVA: 0x0016FFC8 File Offset: 0x0016E1C8
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

	// Token: 0x060041DC RID: 16860 RVA: 0x0016FFEC File Offset: 0x0016E1EC
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

	// Token: 0x060041DD RID: 16861 RVA: 0x0017005C File Offset: 0x0016E25C
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

	// Token: 0x0400339F RID: 13215
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040033A0 RID: 13216
	private TTimerAction Callback;

	// Token: 0x040033A1 RID: 13217
	private TimerHandle CallbackHandle;
}
