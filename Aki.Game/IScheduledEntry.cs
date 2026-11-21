using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using UnrealEngine;

// Token: 0x0200023A RID: 570
[NullableContext(1)]
public interface IScheduledEntry
{
	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x0600239F RID: 9119
	// (set) Token: 0x060023A0 RID: 9120
	Capability Cap { get; set; }

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x060023A1 RID: 9121
	// (set) Token: 0x060023A2 RID: 9122
	ETickingGroup? EffectiveGroup { get; set; }

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x060023A3 RID: 9123
	// (set) Token: 0x060023A4 RID: 9124
	int EffectiveOrder { get; set; }
}
