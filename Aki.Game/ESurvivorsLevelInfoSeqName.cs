using System;
using System.Runtime.CompilerServices;

// Token: 0x02002093 RID: 8339
[NullableContext(1)]
[Nullable(0)]
public readonly struct ESurvivorsLevelInfoSeqName
{
	// Token: 0x060148ED RID: 84205 RVA: 0x005FDD05 File Offset: 0x005FBF05
	private ESurvivorsLevelInfoSeqName(string value)
	{
		this._Value = value;
	}

	// Token: 0x060148EE RID: 84206 RVA: 0x005FDD0E File Offset: 0x005FBF0E
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0400AE74 RID: 44660
	private readonly string _Value;

	// Token: 0x0400AE75 RID: 44661
	public static readonly ESurvivorsLevelInfoSeqName EndlessOpen = new ESurvivorsLevelInfoSeqName("EndlessOpen");

	// Token: 0x0400AE76 RID: 44662
	public static readonly ESurvivorsLevelInfoSeqName Unlock = new ESurvivorsLevelInfoSeqName("Unlock");

	// Token: 0x0400AE77 RID: 44663
	public static readonly ESurvivorsLevelInfoSeqName Complete = new ESurvivorsLevelInfoSeqName("Complete");
}
