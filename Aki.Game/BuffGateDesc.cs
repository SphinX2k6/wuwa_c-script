using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E9A RID: 3738
public class BuffGateDesc : IBuffGateDesc
{
	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x0010B945 File Offset: 0x00109B45
	// (set) Token: 0x06005BB5 RID: 23477 RVA: 0x0010B94D File Offset: 0x00109B4D
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public ValueTuple<string, List<string>> Desc { [return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] set; }

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x0010B956 File Offset: 0x00109B56
	// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x0010B95E File Offset: 0x00109B5E
	public int BuffGateId { get; set; }

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x0010B967 File Offset: 0x00109B67
	// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x0010B96F File Offset: 0x00109B6F
	public bool IsDropBuffGate { get; set; }
}
