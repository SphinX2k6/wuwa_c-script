using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001AF5 RID: 6901
public class FloroRanchEvolveData
{
	// Token: 0x0600CCE2 RID: 52450 RVA: 0x002EC614 File Offset: 0x002EA814
	[NullableContext(1)]
	public FloroRanchEvolveData(FREvolveData evolveData)
	{
		this.CurExp = evolveData.CurExp;
		this.CurLevel = evolveData.CurLevel;
		this.ExpPerLevel = evolveData.ExpPerLevel;
		this.IsValid = true;
	}

	// Token: 0x0600CCE3 RID: 52451 RVA: 0x002EC64F File Offset: 0x002EA84F
	[NullableContext(2)]
	public void Refresh(FREvolveData evolveData)
	{
		if (evolveData != null)
		{
			this.CurExp = evolveData.CurExp;
			this.CurLevel = evolveData.CurLevel;
			this.ExpPerLevel = evolveData.ExpPerLevel;
			this.IsValid = true;
			return;
		}
		this.IsValid = false;
	}

	// Token: 0x04005E07 RID: 24071
	public int CurExp;

	// Token: 0x04005E08 RID: 24072
	public int CurLevel;

	// Token: 0x04005E09 RID: 24073
	public int MaxLevel = 100;

	// Token: 0x04005E0A RID: 24074
	public int ExpPerLevel;

	// Token: 0x04005E0B RID: 24075
	public bool IsValid;
}
