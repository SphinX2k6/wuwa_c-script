using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200117C RID: 4476
public class KurotatoEliteWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600B251 RID: 45649 RVA: 0x0034ADCF File Offset: 0x00348FCF
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B252 RID: 45650 RVA: 0x0034ADE4 File Offset: 0x00348FE4
	public void PlayEliteWave()
	{
		base.SetUiActive(true);
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x040066DC RID: 26332
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;
}
