using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200275F RID: 10079
[NullableContext(1)]
[Nullable(0)]
public class NpcInterestLookAtParamGroupImpl : INpcInterestLookAtParamGroup
{
	// Token: 0x17002869 RID: 10345
	// (get) Token: 0x060194D4 RID: 103636 RVA: 0x007BAAE1 File Offset: 0x007B8CE1
	// (set) Token: 0x060194D5 RID: 103637 RVA: 0x007BAAE9 File Offset: 0x007B8CE9
	public string Key { get; set; }

	// Token: 0x1700286A RID: 10346
	// (get) Token: 0x060194D6 RID: 103638 RVA: 0x007BAAF2 File Offset: 0x007B8CF2
	// (set) Token: 0x060194D7 RID: 103639 RVA: 0x007BAAFA File Offset: 0x007B8CFA
	public IList<int> PbDataIds { get; set; }

	// Token: 0x1700286B RID: 10347
	// (get) Token: 0x060194D8 RID: 103640 RVA: 0x007BAB03 File Offset: 0x007B8D03
	// (set) Token: 0x060194D9 RID: 103641 RVA: 0x007BAB0B File Offset: 0x007B8D0B
	public IList<INpcInterestLookAtParam> Params { get; set; }
}
