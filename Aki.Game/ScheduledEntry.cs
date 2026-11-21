using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

// Token: 0x0200023B RID: 571
[NullableContext(1)]
[Nullable(0)]
[RequiredMember]
public class ScheduledEntry : IScheduledEntry
{
	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000DFA46 File Offset: 0x000DDC46
	// (set) Token: 0x060023A6 RID: 9126 RVA: 0x000DFA4E File Offset: 0x000DDC4E
	[RequiredMember]
	public Capability Cap { get; set; }

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000DFA57 File Offset: 0x000DDC57
	// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000DFA5F File Offset: 0x000DDC5F
	public ETickingGroup? EffectiveGroup { get; set; }

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000DFA68 File Offset: 0x000DDC68
	// (set) Token: 0x060023AA RID: 9130 RVA: 0x000DFA70 File Offset: 0x000DDC70
	[RequiredMember]
	public int EffectiveOrder { get; set; }

	// Token: 0x060023AB RID: 9131 RVA: 0x000DFA79 File Offset: 0x000DDC79
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ScheduledEntry()
	{
	}
}
