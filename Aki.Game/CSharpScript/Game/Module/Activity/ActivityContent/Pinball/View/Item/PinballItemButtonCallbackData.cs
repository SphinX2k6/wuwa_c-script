using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006351 RID: 25425
	[NullableContext(1)]
	[Nullable(0)]
	internal class PinballItemButtonCallbackData : IPinballItemButtonCallback
	{
		// Token: 0x1700932C RID: 37676
		// (get) Token: 0x0603FFD5 RID: 262101 RVA: 0x00F7B3D8 File Offset: 0x00F795D8
		// (set) Token: 0x0603FFD6 RID: 262102 RVA: 0x00F7B3E0 File Offset: 0x00F795E0
		public PinballItemView View { get; set; }

		// Token: 0x1700932D RID: 37677
		// (get) Token: 0x0603FFD7 RID: 262103 RVA: 0x00F7B3E9 File Offset: 0x00F795E9
		// (set) Token: 0x0603FFD8 RID: 262104 RVA: 0x00F7B3F1 File Offset: 0x00F795F1
		[Nullable(2)]
		public object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
