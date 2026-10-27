using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001EA5 RID: 7845
public class HonamiStoryDragItemFrameItem : UiPanelBase
{
	// Token: 0x0600F0D5 RID: 61653 RVA: 0x0039D5B0 File Offset: 0x0039B7B0
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F0D6 RID: 61654 RVA: 0x0039D5C4 File Offset: 0x0039B7C4
	protected override void OnBeforeShow()
	{
		if (!this.LevelSequencePlayer.IsPlayingSequence("Loop"))
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
	}

	// Token: 0x04006F5E RID: 28510
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
