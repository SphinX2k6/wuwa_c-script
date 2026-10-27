using System;

// Token: 0x02003539 RID: 13625
public interface IGraphNodeWithNoCyclicDependency
{
	// Token: 0x17002973 RID: 10611
	// (get) Token: 0x0601DEFA RID: 122618 RVA: 0x00863B7D File Offset: 0x00861D7D
	bool HasCycle
	{
		get
		{
			return false;
		}
	}
}
