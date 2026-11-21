using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001B6C RID: 7020
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewNodeItemBase : UiPanelBase
{
	// Token: 0x0601181B RID: 71707 RVA: 0x0052910A File Offset: 0x0052730A
	public virtual void Refresh(IQuestReviewNodeParam param)
	{
	}

	// Token: 0x0601181C RID: 71708 RVA: 0x0052910C File Offset: 0x0052730C
	public void SetSeqPlayer(LevelSequencePlayer seqPlayer)
	{
		this.SeqPlayer = seqPlayer;
	}

	// Token: 0x0601181D RID: 71709 RVA: 0x00529118 File Offset: 0x00527318
	public void PlaySeqByName(string seqName)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.PlayLevelSequenceByName(seqName, false, null, false);
	}

	// Token: 0x04009965 RID: 39269
	protected LevelSequencePlayer SeqPlayer;
}
