using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x020014DA RID: 5338
public class RunEndData : UiViewData
{
	// Token: 0x060097EE RID: 38894 RVA: 0x0020D35C File Offset: 0x0020B55C
	[NullableContext(1)]
	public void Phrase(ParkourChallengeEndNotify message)
	{
		this.CurrentChallengeId = message.ChallengeId;
		this.CurrentScore = message.Score;
		this.CurrentTime = (long)message.Duration;
	}

	// Token: 0x060097EF RID: 38895 RVA: 0x0020D383 File Offset: 0x0020B583
	public void SetIfNewRecord(bool state)
	{
		this.IfNewRecord = state;
	}

	// Token: 0x040042D4 RID: 17108
	public int CurrentChallengeId;

	// Token: 0x040042D5 RID: 17109
	public int CurrentScore;

	// Token: 0x040042D6 RID: 17110
	public long CurrentTime;

	// Token: 0x040042D7 RID: 17111
	public bool IfNewRecord;
}
