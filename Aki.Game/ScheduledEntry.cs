using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

// Token: 0x02000237 RID: 567
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ScheduledEntry : IScheduledEntry
{
	// Token: 0x17000538 RID: 1336
	// (get) Token: 0x060022ED RID: 8941 RVA: 0x000D9586 File Offset: 0x000D7786
	// (set) Token: 0x060022EE RID: 8942 RVA: 0x000D958E File Offset: 0x000D778E
	[RequiredMember]
	public Capability Cap { get; set; }

	// Token: 0x17000539 RID: 1337
	// (get) Token: 0x060022EF RID: 8943 RVA: 0x000D9597 File Offset: 0x000D7797
	// (set) Token: 0x060022F0 RID: 8944 RVA: 0x000D959F File Offset: 0x000D779F
	public ETickingGroup? EffectiveGroup { get; set; }

	// Token: 0x1700053A RID: 1338
	// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000D95A8 File Offset: 0x000D77A8
	// (set) Token: 0x060022F2 RID: 8946 RVA: 0x000D95B0 File Offset: 0x000D77B0
	[RequiredMember]
	public int EffectiveOrder { get; set; }

	// Token: 0x060022F3 RID: 8947 RVA: 0x000D95B9 File Offset: 0x000D77B9
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ScheduledEntry()
	{
	}
}
