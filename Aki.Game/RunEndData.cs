using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02000992 RID: 2450
public class RunEndData : UiViewData
{
	// Token: 0x06006BC8 RID: 27592 RVA: 0x0021709C File Offset: 0x0021529C
	[NullableContext(1)]
	public void Phrase(ParkourChallengeEndNotify message)
	{
		this.CurrentChallengeId = message.ChallengeId;
		this.CurrentScore = message.Score;
		this.CurrentTime = (long)message.Duration;
	}

	// Token: 0x06006BC9 RID: 27593 RVA: 0x002170C3 File Offset: 0x002152C3
	public void SetIfNewRecord(bool state)
	{
		this.IfNewRecord = state;
	}

	// Token: 0x04004379 RID: 17273
	public int CurrentChallengeId;

	// Token: 0x0400437A RID: 17274
	public int CurrentScore;

	// Token: 0x0400437B RID: 17275
	public long CurrentTime;

	// Token: 0x0400437C RID: 17276
	public bool IfNewRecord;
}
