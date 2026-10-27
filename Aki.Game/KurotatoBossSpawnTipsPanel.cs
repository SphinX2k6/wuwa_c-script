using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001CB6 RID: 7350
public class KurotatoBossSpawnTipsPanel : UiPanelBase
{
	// Token: 0x0600DE10 RID: 56848 RVA: 0x0033E855 File Offset: 0x0033CA55
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600DE11 RID: 56849 RVA: 0x0033E868 File Offset: 0x0033CA68
	public void PlayBossSpawn()
	{
		base.SetUiActive(true);
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x040065D6 RID: 26070
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;
}
