using System;
using System.Runtime.CompilerServices;

// Token: 0x0200353A RID: 13626
[NullableContext(1)]
public interface IGraphNodeWithCyclicDependency
{
	// Token: 0x17002974 RID: 10612
	// (get) Token: 0x0601DEFB RID: 122619 RVA: 0x00863B80 File Offset: 0x00861D80
	bool HasCycle
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002975 RID: 10613
	// (get) Token: 0x0601DEFC RID: 122620
	// (set) Token: 0x0601DEFD RID: 122621
	string[] Cycle { get; set; }
}
