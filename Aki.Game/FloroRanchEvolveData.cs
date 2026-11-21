using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FB4 RID: 4020
public class FloroRanchEvolveData
{
	// Token: 0x0600A0F3 RID: 41203 RVA: 0x002F7700 File Offset: 0x002F5900
	[NullableContext(1)]
	public FloroRanchEvolveData(FREvolveData evolveData)
	{
		this.CurExp = evolveData.CurExp;
		this.CurLevel = evolveData.CurLevel;
		this.ExpPerLevel = evolveData.ExpPerLevel;
		this.IsValid = true;
	}

	// Token: 0x0600A0F4 RID: 41204 RVA: 0x002F773B File Offset: 0x002F593B
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

	// Token: 0x04005ED6 RID: 24278
	public int CurExp;

	// Token: 0x04005ED7 RID: 24279
	public int CurLevel;

	// Token: 0x04005ED8 RID: 24280
	public int MaxLevel = 100;

	// Token: 0x04005ED9 RID: 24281
	public int ExpPerLevel;

	// Token: 0x04005EDA RID: 24282
	public bool IsValid;
}
