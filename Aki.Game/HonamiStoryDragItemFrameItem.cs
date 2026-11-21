using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001367 RID: 4967
public class HonamiStoryDragItemFrameItem : UiPanelBase
{
	// Token: 0x0600C4F4 RID: 50420 RVA: 0x003A916C File Offset: 0x003A736C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C4F5 RID: 50421 RVA: 0x003A9180 File Offset: 0x003A7380
	protected override void OnBeforeShow()
	{
		if (!this.LevelSequencePlayer.IsPlayingSequence("Loop"))
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
	}

	// Token: 0x0400703F RID: 28735
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
