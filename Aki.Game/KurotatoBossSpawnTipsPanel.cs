using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001178 RID: 4472
public class KurotatoBossSpawnTipsPanel : UiPanelBase
{
	// Token: 0x0600B22D RID: 45613 RVA: 0x0034A291 File Offset: 0x00348491
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B22E RID: 45614 RVA: 0x0034A2A4 File Offset: 0x003484A4
	public void PlayBossSpawn()
	{
		base.SetUiActive(true);
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x040066B5 RID: 26293
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;
}
