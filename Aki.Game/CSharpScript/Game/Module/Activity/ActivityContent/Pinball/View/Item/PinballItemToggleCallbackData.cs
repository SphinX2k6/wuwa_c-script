using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052CE RID: 21198
	[NullableContext(1)]
	[Nullable(0)]
	internal class PinballItemToggleCallbackData : IPinballItemToggleCallback
	{
		// Token: 0x1700668B RID: 26251
		// (get) Token: 0x06034C8F RID: 216207 RVA: 0x00EC22FD File Offset: 0x00EC04FD
		// (set) Token: 0x06034C90 RID: 216208 RVA: 0x00EC2305 File Offset: 0x00EC0505
		public PinballItemView View { get; set; }

		// Token: 0x1700668C RID: 26252
		// (get) Token: 0x06034C91 RID: 216209 RVA: 0x00EC230E File Offset: 0x00EC050E
		// (set) Token: 0x06034C92 RID: 216210 RVA: 0x00EC2316 File Offset: 0x00EC0516
		public EToggleState State { get; set; }

		// Token: 0x1700668D RID: 26253
		// (get) Token: 0x06034C93 RID: 216211 RVA: 0x00EC231F File Offset: 0x00EC051F
		// (set) Token: 0x06034C94 RID: 216212 RVA: 0x00EC2327 File Offset: 0x00EC0527
		[Nullable(2)]
		public object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
