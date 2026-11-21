using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C44 RID: 7236
[NullableContext(1)]
[Nullable(0)]
public class ReportPersonInfo
{
	// Token: 0x06011F75 RID: 73589 RVA: 0x00548E29 File Offset: 0x00547029
	public ReportPersonInfo(int playerId, string name, string signature, EReportSourceType sourceType)
	{
		this.PlayerId = playerId;
		this.Name = name;
		this.Signature = signature;
		this.SourceType = sourceType;
	}

	// Token: 0x06011F76 RID: 73590 RVA: 0x00548E4E File Offset: 0x0054704E
	public int GetPlayerId()
	{
		return this.PlayerId;
	}

	// Token: 0x06011F77 RID: 73591 RVA: 0x00548E56 File Offset: 0x00547056
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x06011F78 RID: 73592 RVA: 0x00548E5E File Offset: 0x0054705E
	public string GetSignature()
	{
		return this.Signature;
	}

	// Token: 0x06011F79 RID: 73593 RVA: 0x00548E66 File Offset: 0x00547066
	public EReportSourceType GetSourceType()
	{
		return this.SourceType;
	}

	// Token: 0x04009CA6 RID: 40102
	private readonly int PlayerId;

	// Token: 0x04009CA7 RID: 40103
	private readonly string Name;

	// Token: 0x04009CA8 RID: 40104
	private readonly string Signature;

	// Token: 0x04009CA9 RID: 40105
	private readonly EReportSourceType SourceType;
}
