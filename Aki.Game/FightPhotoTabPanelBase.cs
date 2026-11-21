using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001AAC RID: 6828
public class FightPhotoTabPanelBase : UiPanelBase
{
	// Token: 0x06010E6C RID: 69228 RVA: 0x004F543B File Offset: 0x004F363B
	public void PlaySwitchAnim()
	{
		this.PlaySequence("Switch");
	}

	// Token: 0x06010E6D RID: 69229 RVA: 0x004F5448 File Offset: 0x004F3648
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

	// Token: 0x06010E6E RID: 69230 RVA: 0x004F5492 File Offset: 0x004F3692
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x04009532 RID: 38194
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;
}
