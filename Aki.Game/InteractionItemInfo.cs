using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000BAA RID: 2986
[NullableContext(1)]
[Nullable(0)]
public class InteractionItemInfo
{
	// Token: 0x17000E14 RID: 3604
	// (get) Token: 0x06007C45 RID: 31813 RVA: 0x00267DD8 File Offset: 0x00265FD8
	// (set) Token: 0x06007C46 RID: 31814 RVA: 0x00267DE0 File Offset: 0x00265FE0
	public IReadOnlySet<string> Foliages { get; set; }

	// Token: 0x17000E15 RID: 3605
	// (get) Token: 0x06007C47 RID: 31815 RVA: 0x00267DE9 File Offset: 0x00265FE9
	// (set) Token: 0x06007C48 RID: 31816 RVA: 0x00267DF1 File Offset: 0x00265FF1
	public IReadOnlySet<string> StaticMeshes { get; set; }

	// Token: 0x17000E16 RID: 3606
	// (get) Token: 0x06007C49 RID: 31817 RVA: 0x00267DFA File Offset: 0x00265FFA
	// (set) Token: 0x06007C4A RID: 31818 RVA: 0x00267E02 File Offset: 0x00266002
	public string AudioKey { get; set; }

	// Token: 0x06007C4B RID: 31819 RVA: 0x00267E0B File Offset: 0x0026600B
	public InteractionItemInfo(IReadOnlySet<string> foliages, IReadOnlySet<string> staticMeshes, string audioKey)
	{
		this.Foliages = foliages;
		this.StaticMeshes = staticMeshes;
		this.AudioKey = audioKey;
	}
}
