using System;
using System.Runtime.CompilerServices;

// Token: 0x02002759 RID: 10073
[NullableContext(1)]
[Nullable(0)]
public class ReportPersonInfo
{
	// Token: 0x06014A92 RID: 84626 RVA: 0x00539F95 File Offset: 0x00538195
	public ReportPersonInfo(int playerId, string name, string signature, EReportSourceType sourceType)
	{
		this.PlayerId = playerId;
		this.Name = name;
		this.Signature = signature;
		this.SourceType = sourceType;
	}

	// Token: 0x06014A93 RID: 84627 RVA: 0x00539FBA File Offset: 0x005381BA
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x06014A94 RID: 84628 RVA: 0x00539FC2 File Offset: 0x005381C2
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x06014A95 RID: 84629 RVA: 0x00539FCA File Offset: 0x005381CA
	public string GetSignature()
	{
		return this.Signature;
	}

	// Token: 0x06014A96 RID: 84630 RVA: 0x00539FD2 File Offset: 0x005381D2
	public EReportSourceType GetSourceType()
	{
		return this.SourceType;
	}

	// Token: 0x04009B4D RID: 39757
	private readonly int PlayerId;

	// Token: 0x04009B4E RID: 39758
	private readonly string Name;

	// Token: 0x04009B4F RID: 39759
	private readonly string Signature;

	// Token: 0x04009B50 RID: 39760
	private readonly EReportSourceType SourceType;
}
