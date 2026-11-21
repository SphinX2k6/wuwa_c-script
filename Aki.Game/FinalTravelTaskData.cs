using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200078A RID: 1930
[NullableContext(1)]
[Nullable(0)]
public class FinalTravelTaskData
{
	// Token: 0x17000B8B RID: 2955
	// (get) Token: 0x06005890 RID: 22672 RVA: 0x001CD67D File Offset: 0x001CB87D
	public int Current
	{
		get
		{
			return this.FinishedIdSet.Count;
		}
	}

	// Token: 0x17000B8C RID: 2956
	// (get) Token: 0x06005891 RID: 22673 RVA: 0x001CD68A File Offset: 0x001CB88A
	// (set) Token: 0x06005892 RID: 22674 RVA: 0x001CD692 File Offset: 0x001CB892
	public int Target { get; set; } = 1;

	// Token: 0x17000B8D RID: 2957
	// (get) Token: 0x06005893 RID: 22675 RVA: 0x001CD69B File Offset: 0x001CB89B
	public HashSet<int> FinishedIdSet { get; } = new HashSet<int>();

	// Token: 0x17000B8E RID: 2958
	// (get) Token: 0x06005894 RID: 22676 RVA: 0x001CD6A3 File Offset: 0x001CB8A3
	// (set) Token: 0x06005895 RID: 22677 RVA: 0x001CD6AB File Offset: 0x001CB8AB
	public bool IsReceived { get; set; }

	// Token: 0x06005896 RID: 22678 RVA: 0x001CD6B4 File Offset: 0x001CB8B4
	public bool CanReceive()
	{
		return !this.IsReceived && this.Current == this.Target;
	}
}
