using System;

// Token: 0x02002AAE RID: 10926
public interface IGraphNodeWithNoCyclicDependency
{
	// Token: 0x17002D0C RID: 11532
	// (get) Token: 0x0601BC22 RID: 113698 RVA: 0x0088B7B5 File Offset: 0x008899B5
	bool HasCycle
	{
		get
		{
			return false;
		}
	}
}
