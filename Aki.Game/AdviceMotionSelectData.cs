using System;

// Token: 0x020016C4 RID: 5828
public class AdviceMotionSelectData
{
	// Token: 0x0600A677 RID: 42615 RVA: 0x00253FA0 File Offset: 0x002521A0
	public AdviceMotionSelectData(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600A678 RID: 42616 RVA: 0x00253FAF File Offset: 0x002521AF
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x04004B29 RID: 19241
	private readonly int Index;
}
