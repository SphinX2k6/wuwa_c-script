using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;

// Token: 0x0200140B RID: 5131
[NullableContext(1)]
public interface IPinballItemButtonCallback
{
	// Token: 0x17000C5B RID: 3163
	// (get) Token: 0x060090F6 RID: 37110
	// (set) Token: 0x060090F7 RID: 37111
	PinballItemView View { get; set; }

	// Token: 0x17000C5C RID: 3164
	// (get) Token: 0x060090F8 RID: 37112
	// (set) Token: 0x060090F9 RID: 37113
	[Nullable(2)]
	object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
}
