using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020016C1 RID: 5825
[NullableContext(1)]
[Nullable(0)]
public class AdviceEntityData
{
	// Token: 0x0600A66E RID: 42606 RVA: 0x00253EEB File Offset: 0x002520EB
	public void Phrase(AdviceComponentPb data)
	{
		this.AdviceData = new AdviceData();
		this.PlayerId = (long)data.PlayerId;
		this.PlayerName = data.PlayerName;
		this.AdviceData.Phrase(data.Advice);
	}

	// Token: 0x0600A66F RID: 42607 RVA: 0x00253F22 File Offset: 0x00252122
	public void PhraseVote(long up)
	{
		this.AdviceData.PhraseUpDownData(up);
		EventSystem.Instance.Emit(EEventName.OnAdviceEntityNotify);
	}

	// Token: 0x0600A670 RID: 42608 RVA: 0x00253F40 File Offset: 0x00252140
	public void PhraseContent(List<PbAdviceContent> data)
	{
		this.AdviceData.PhraseData(data);
		EventSystem.Instance.Emit(EEventName.OnAdviceEntityNotify);
	}

	// Token: 0x0600A671 RID: 42609 RVA: 0x00253F5E File Offset: 0x0025215E
	public long GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x0600A672 RID: 42610 RVA: 0x00253F66 File Offset: 0x00252166
	public string GetPlayerName()
	{
		return this.PlayerName;
	}

	// Token: 0x0600A673 RID: 42611 RVA: 0x00253F6E File Offset: 0x0025216E
	[NullableContext(2)]
	public AdviceData GetAdviceData()
	{
		return this.AdviceData;
	}

	// Token: 0x04004B1D RID: 19229
	private long PlayerId;

	// Token: 0x04004B1E RID: 19230
	private string PlayerName = "";

	// Token: 0x04004B1F RID: 19231
	[Nullable(2)]
	private AdviceData AdviceData;
}
