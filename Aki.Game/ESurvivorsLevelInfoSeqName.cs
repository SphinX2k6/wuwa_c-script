using System;
using System.Runtime.CompilerServices;

// Token: 0x02002B17 RID: 11031
[NullableContext(1)]
[Nullable(0)]
public readonly struct ESurvivorsLevelInfoSeqName
{
	// Token: 0x06016EBC RID: 93884 RVA: 0x005D1189 File Offset: 0x005CF389
	private ESurvivorsLevelInfoSeqName(string value)
	{
		this._Value = value;
	}

	// Token: 0x06016EBD RID: 93885 RVA: 0x005D1192 File Offset: 0x005CF392
	public override string ToString()
	{
		return this._Value;
	}

	// Token: 0x0400AA6E RID: 43630
	private readonly string _Value;

	// Token: 0x0400AA6F RID: 43631
	public static readonly ESurvivorsLevelInfoSeqName EndlessOpen = new ESurvivorsLevelInfoSeqName("EndlessOpen");

	// Token: 0x0400AA70 RID: 43632
	public static readonly ESurvivorsLevelInfoSeqName Unlock = new ESurvivorsLevelInfoSeqName("Unlock");

	// Token: 0x0400AA71 RID: 43633
	public static readonly ESurvivorsLevelInfoSeqName Complete = new ESurvivorsLevelInfoSeqName("Complete");
}
