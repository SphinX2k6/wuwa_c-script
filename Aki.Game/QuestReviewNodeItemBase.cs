using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002681 RID: 9857
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeItemBase : UiPanelBase
{
	// Token: 0x06014339 RID: 82745 RVA: 0x0051A3D2 File Offset: 0x005185D2
	public virtual void Refresh(IQuestReviewNodeParam param)
	{
	}

	// Token: 0x0601433A RID: 82746 RVA: 0x0051A3D4 File Offset: 0x005185D4
	public void SetSeqPlayer(LevelSequencePlayer seqPlayer)
	{
		this.SeqPlayer = seqPlayer;
	}

	// Token: 0x0601433B RID: 82747 RVA: 0x0051A3E0 File Offset: 0x005185E0
	public void PlaySeqByName(string seqName)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayLevelSequenceByName(seqName, false, null, false);
	}

	// Token: 0x0400980D RID: 38925
	protected LevelSequencePlayer SeqPlayer;
}
