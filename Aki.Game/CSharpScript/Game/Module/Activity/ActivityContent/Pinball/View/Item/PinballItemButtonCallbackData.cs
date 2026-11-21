using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052CF RID: 21199
	[NullableContext(1)]
	[Nullable(0)]
	internal class PinballItemButtonCallbackData : IPinballItemButtonCallback
	{
		// Token: 0x1700668E RID: 26254
		// (get) Token: 0x06034C96 RID: 216214 RVA: 0x00EC2338 File Offset: 0x00EC0538
		// (set) Token: 0x06034C97 RID: 216215 RVA: 0x00EC2340 File Offset: 0x00EC0540
		public PinballItemView View { get; set; }

		// Token: 0x1700668F RID: 26255
		// (get) Token: 0x06034C98 RID: 216216 RVA: 0x00EC2349 File Offset: 0x00EC0549
		// (set) Token: 0x06034C99 RID: 216217 RVA: 0x00EC2351 File Offset: 0x00EC0551
		[Nullable(2)]
		public object Data { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
