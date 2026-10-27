using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using UnrealEngine;

// Token: 0x0200140A RID: 5130
[NullableContext(1)]
public interface IPinballItemToggleCallback
{
	// Token: 0x17000C58 RID: 3160
	// (get) Token: 0x060090F0 RID: 37104
	// (set) Token: 0x060090F1 RID: 37105
	PinballItemView View { get; set; }

	// Token: 0x17000C59 RID: 3161
	// (get) Token: 0x060090F2 RID: 37106
	// (set) Token: 0x060090F3 RID: 37107
	EToggleState State { get; set; }

	// Token: 0x17000C5A RID: 3162
	// (get) Token: 0x060090F4 RID: 37108
	// (set) Token: 0x060090F5 RID: 37109
	[Nullable(2)]
	object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
}
