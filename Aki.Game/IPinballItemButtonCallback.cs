using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;

// Token: 0x020008BF RID: 2239
[NullableContext(1)]
public interface IPinballItemButtonCallback
{
	// Token: 0x17000C7B RID: 3195
	// (get) Token: 0x0600648B RID: 25739
	// (set) Token: 0x0600648C RID: 25740
	PinballItemView View { get; set; }

	// Token: 0x17000C7C RID: 3196
	// (get) Token: 0x0600648D RID: 25741
	// (set) Token: 0x0600648E RID: 25742
	[Nullable(2)]
	object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
}
