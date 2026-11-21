using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using UnrealEngine;

// Token: 0x020008BE RID: 2238
[NullableContext(1)]
public interface IPinballItemToggleCallback
{
	// Token: 0x17000C78 RID: 3192
	// (get) Token: 0x06006485 RID: 25733
	// (set) Token: 0x06006486 RID: 25734
	PinballItemView View { get; set; }

	// Token: 0x17000C79 RID: 3193
	// (get) Token: 0x06006487 RID: 25735
	// (set) Token: 0x06006488 RID: 25736
	EToggleState State { get; set; }

	// Token: 0x17000C7A RID: 3194
	// (get) Token: 0x06006489 RID: 25737
	// (set) Token: 0x0600648A RID: 25738
	[Nullable(2)]
	object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
}
