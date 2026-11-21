using System;
using System.Runtime.CompilerServices;

// Token: 0x02000235 RID: 565
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ICapabilityBlockEntry
{
	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06002364 RID: 9060 RVA: 0x000DF92F File Offset: 0x000DDB2F
	// (set) Token: 0x06002365 RID: 9061 RVA: 0x000DF937 File Offset: 0x000DDB37
	[RequiredMember]
	public int Tag { get; set; }

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06002366 RID: 9062 RVA: 0x000DF940 File Offset: 0x000DDB40
	// (set) Token: 0x06002367 RID: 9063 RVA: 0x000DF948 File Offset: 0x000DDB48
	[RequiredMember]
	public object Instigator { get; set; }

	// Token: 0x06002368 RID: 9064 RVA: 0x000DF951 File Offset: 0x000DDB51
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ICapabilityBlockEntry()
	{
	}
}
