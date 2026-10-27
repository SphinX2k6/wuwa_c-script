using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001CBA RID: 7354
public class KurotatoEliteWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600DE34 RID: 56884 RVA: 0x0033F393 File Offset: 0x0033D593
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600DE35 RID: 56885 RVA: 0x0033F3A8 File Offset: 0x0033D5A8
	public void PlayEliteWave()
	{
		base.SetUiActive(true);
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x040065FD RID: 26109
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;
}
