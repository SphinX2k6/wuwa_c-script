using System;
using System.Runtime.CompilerServices;

// Token: 0x020003B7 RID: 951
[NullableContext(1)]
[Nullable(0)]
public class ThresholdListenerInfo : IThresholdListenerInfo
{
	// Token: 0x17000797 RID: 1943
	// (get) Token: 0x060033F6 RID: 13302 RVA: 0x00135333 File Offset: 0x00133533
	// (set) Token: 0x060033F7 RID: 13303 RVA: 0x0013533B File Offset: 0x0013353B
	public TThresholdListener Func { get; set; }

	// Token: 0x17000798 RID: 1944
	// (get) Token: 0x060033F8 RID: 13304 RVA: 0x00135344 File Offset: 0x00133544
	// (set) Token: 0x060033F9 RID: 13305 RVA: 0x0013534C File Offset: 0x0013354C
	public float Max { get; set; }

	// Token: 0x17000799 RID: 1945
	// (get) Token: 0x060033FA RID: 13306 RVA: 0x00135355 File Offset: 0x00133555
	// (set) Token: 0x060033FB RID: 13307 RVA: 0x0013535D File Offset: 0x0013355D
	public float Min { get; set; }

	// Token: 0x1700079A RID: 1946
	// (get) Token: 0x060033FC RID: 13308 RVA: 0x00135366 File Offset: 0x00133566
	// (set) Token: 0x060033FD RID: 13309 RVA: 0x0013536E File Offset: 0x0013356E
	public bool InInterval { get; set; }
}
