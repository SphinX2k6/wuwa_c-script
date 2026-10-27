using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020012D6 RID: 4822
[NullableContext(1)]
[Nullable(0)]
public class FinalTravelTaskData
{
	// Token: 0x17000B6B RID: 2923
	// (get) Token: 0x060084F5 RID: 34037 RVA: 0x001C4821 File Offset: 0x001C2A21
	public int Current
	{
		get
		{
			return this.FinishedIdSet.Count;
		}
	}

	// Token: 0x17000B6C RID: 2924
	// (get) Token: 0x060084F6 RID: 34038 RVA: 0x001C482E File Offset: 0x001C2A2E
	// (set) Token: 0x060084F7 RID: 34039 RVA: 0x001C4836 File Offset: 0x001C2A36
	public int Target { get; set; } = 1;

	// Token: 0x17000B6D RID: 2925
	// (get) Token: 0x060084F8 RID: 34040 RVA: 0x001C483F File Offset: 0x001C2A3F
	public HashSet<int> FinishedIdSet { get; } = new HashSet<int>();

	// Token: 0x17000B6E RID: 2926
	// (get) Token: 0x060084F9 RID: 34041 RVA: 0x001C4847 File Offset: 0x001C2A47
	// (set) Token: 0x060084FA RID: 34042 RVA: 0x001C484F File Offset: 0x001C2A4F
	public bool IsReceived { get; set; }

	// Token: 0x060084FB RID: 34043 RVA: 0x001C4858 File Offset: 0x001C2A58
	public bool CanReceive()
	{
		return !this.IsReceived && this.Current == this.Target;
	}
}
