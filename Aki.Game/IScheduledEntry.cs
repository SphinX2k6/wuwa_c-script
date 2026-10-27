using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

// Token: 0x02000236 RID: 566
[NullableContext(1)]
public interface IScheduledEntry
{
	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x060022E7 RID: 8935
	// (set) Token: 0x060022E8 RID: 8936
	Capability Cap { get; set; }

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x060022E9 RID: 8937
	// (set) Token: 0x060022EA RID: 8938
	ETickingGroup? EffectiveGroup { get; set; }

	// Token: 0x17000537 RID: 1335
	// (get) Token: 0x060022EB RID: 8939
	// (set) Token: 0x060022EC RID: 8940
	int EffectiveOrder { get; set; }
}
