using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000B79 RID: 2937
[NullableContext(1)]
[Nullable(0)]
public class AdviceEntityData
{
	// Token: 0x06007A4E RID: 31310 RVA: 0x0025E2FB File Offset: 0x0025C4FB
	public void Phrase(AdviceComponentPb data)
	{
		this.AdviceData = new AdviceData();
		this.PlayerId = (long)data.PlayerId;
		this.PlayerName = data.PlayerName;
		this.AdviceData.Phrase(data.Advice);
	}

	// Token: 0x06007A4F RID: 31311 RVA: 0x0025E332 File Offset: 0x0025C532
	public void PhraseVote(long up)
	{
		this.AdviceData.PhraseUpDownData(up);
		EventSystem.Instance.Emit(EEventName.OnAdviceEntityNotify);
	}

	// Token: 0x06007A50 RID: 31312 RVA: 0x0025E350 File Offset: 0x0025C550
	public void PhraseContent(List<PbAdviceContent> data)
	{
		this.AdviceData.PhraseData(data);
		EventSystem.Instance.Emit(EEventName.OnAdviceEntityNotify);
	}

	// Token: 0x06007A51 RID: 31313 RVA: 0x0025E36E File Offset: 0x0025C56E
	public long GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x06007A52 RID: 31314 RVA: 0x0025E376 File Offset: 0x0025C576
	public string GetPlayerName()
	{
		return this.PlayerName;
	}

	// Token: 0x06007A53 RID: 31315 RVA: 0x0025E37E File Offset: 0x0025C57E
	[NullableContext(2)]
	public AdviceData GetAdviceData()
	{
		return this.AdviceData;
	}

	// Token: 0x04004BC4 RID: 19396
	private long PlayerId;

	// Token: 0x04004BC5 RID: 19397
	private string PlayerName = "";

	// Token: 0x04004BC6 RID: 19398
	[Nullable(2)]
	private AdviceData AdviceData;
}
