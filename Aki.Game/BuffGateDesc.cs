using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200034F RID: 847
public class BuffGateDesc : IBuffGateDesc
{
	// Token: 0x170006E3 RID: 1763
	// (get) Token: 0x06002F4B RID: 12107 RVA: 0x001135DD File Offset: 0x001117DD
	// (set) Token: 0x06002F4C RID: 12108 RVA: 0x001135E5 File Offset: 0x001117E5
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

	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x06002F4D RID: 12109 RVA: 0x001135EE File Offset: 0x001117EE
	// (set) Token: 0x06002F4E RID: 12110 RVA: 0x001135F6 File Offset: 0x001117F6
	public int BuffGateId { get; set; }

	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x06002F4F RID: 12111 RVA: 0x001135FF File Offset: 0x001117FF
	// (set) Token: 0x06002F50 RID: 12112 RVA: 0x00113607 File Offset: 0x00111807
	public bool IsDropBuffGate { get; set; }
}
