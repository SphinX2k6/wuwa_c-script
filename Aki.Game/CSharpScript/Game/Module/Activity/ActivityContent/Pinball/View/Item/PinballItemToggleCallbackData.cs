using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006350 RID: 25424
	[NullableContext(1)]
	[Nullable(0)]
	internal class PinballItemToggleCallbackData : IPinballItemToggleCallback
	{
		// Token: 0x17009329 RID: 37673
		// (get) Token: 0x0603FFCE RID: 262094 RVA: 0x00F7B39D File Offset: 0x00F7959D
		// (set) Token: 0x0603FFCF RID: 262095 RVA: 0x00F7B3A5 File Offset: 0x00F795A5
		public PinballItemView View { get; set; }

		// Token: 0x1700932A RID: 37674
		// (get) Token: 0x0603FFD0 RID: 262096 RVA: 0x00F7B3AE File Offset: 0x00F795AE
		// (set) Token: 0x0603FFD1 RID: 262097 RVA: 0x00F7B3B6 File Offset: 0x00F795B6
		public EToggleState State { get; set; }

		// Token: 0x1700932B RID: 37675
		// (get) Token: 0x0603FFD2 RID: 262098 RVA: 0x00F7B3BF File Offset: 0x00F795BF
		// (set) Token: 0x0603FFD3 RID: 262099 RVA: 0x00F7B3C7 File Offset: 0x00F795C7
		[Nullable(2)]
		public object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
