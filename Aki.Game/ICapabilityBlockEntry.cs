using System;
using System.Runtime.CompilerServices;

// Token: 0x02000231 RID: 561
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ICapabilityBlockEntry
{
	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x060022AC RID: 8876 RVA: 0x000D946F File Offset: 0x000D766F
	// (set) Token: 0x060022AD RID: 8877 RVA: 0x000D9477 File Offset: 0x000D7677
	[RequiredMember]
	public int Tag { get; set; }

	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x060022AE RID: 8878 RVA: 0x000D9480 File Offset: 0x000D7680
	// (set) Token: 0x060022AF RID: 8879 RVA: 0x000D9488 File Offset: 0x000D7688
	[RequiredMember]
	public object Instigator { get; set; }

	// Token: 0x060022B0 RID: 8880 RVA: 0x000D9491 File Offset: 0x000D7691
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ICapabilityBlockEntry()
	{
	}
}
