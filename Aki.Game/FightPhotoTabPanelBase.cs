using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020025C1 RID: 9665
public class FightPhotoTabPanelBase : UiPanelBase
{
	// Token: 0x0601398C RID: 80268 RVA: 0x004E683B File Offset: 0x004E4A3B
	public void PlaySwitchAnim()
	{
		this.PlaySequence("Switch");
	}

	// Token: 0x0601398D RID: 80269 RVA: 0x004E6848 File Offset: 0x004E4A48
	[NullableContext(1)]
	protected void PlaySequence(string sequenceName)
	{
		if (this.SequencePlayer == null)
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.SequencePlayer.StopCurrentSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x0601398E RID: 80270 RVA: 0x004E6892 File Offset: 0x004E4A92
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x040093DC RID: 37852
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;
}
