using System;

// Token: 0x02000B7C RID: 2940
public class AdviceMotionSelectData
{
	// Token: 0x06007A57 RID: 31319 RVA: 0x0025E3B0 File Offset: 0x0025C5B0
	public AdviceMotionSelectData(int index)
	{
		this.Index = index;
	}

	// Token: 0x06007A58 RID: 31320 RVA: 0x0025E3BF File Offset: 0x0025C5BF
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x04004BD0 RID: 19408
	private readonly int Index;
}
