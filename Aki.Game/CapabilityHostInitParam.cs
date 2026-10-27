using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000239 RID: 569
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class CapabilityHostInitParam : ICapabilityHostInitParam
{
	// Token: 0x1700053E RID: 1342
	// (get) Token: 0x060022FA RID: 8954 RVA: 0x000D95C1 File Offset: 0x000D77C1
	// (set) Token: 0x060022FB RID: 8955 RVA: 0x000D95C9 File Offset: 0x000D77C9
	[Nullable(1)]
	[RequiredMember]
	public object Id { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700053F RID: 1343
	// (get) Token: 0x060022FC RID: 8956 RVA: 0x000D95D2 File Offset: 0x000D77D2
	// (set) Token: 0x060022FD RID: 8957 RVA: 0x000D95DA File Offset: 0x000D77DA
	public Func<bool> IsValid { get; set; }

	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x060022FE RID: 8958 RVA: 0x000D95E3 File Offset: 0x000D77E3
	// (set) Token: 0x060022FF RID: 8959 RVA: 0x000D95EB File Offset: 0x000D77EB
	public Func<AActor> GetBoundActor { get; set; }

	// Token: 0x06002300 RID: 8960 RVA: 0x000D95F4 File Offset: 0x000D77F4
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CapabilityHostInitParam()
	{
	}
}
