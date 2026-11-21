using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EA9 RID: 20137
	[NullableContext(1)]
	[Nullable(0)]
	public class SilentAreaDetectionDynamicData : ISilentAreaDetectionDynamicData
	{
		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x06032AB6 RID: 207542 RVA: 0x00E37301 File Offset: 0x00E35501
		// (set) Token: 0x06032AB7 RID: 207543 RVA: 0x00E37309 File Offset: 0x00E35509
		public bool IsShow { get; set; }

		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x06032AB8 RID: 207544 RVA: 0x00E37312 File Offset: 0x00E35512
		// (set) Token: 0x06032AB9 RID: 207545 RVA: 0x00E3731A File Offset: 0x00E3551A
		public int DangerType { get; set; }

		// Token: 0x170062A8 RID: 25256
		// (get) Token: 0x06032ABA RID: 207546 RVA: 0x00E37323 File Offset: 0x00E35523
		// (set) Token: 0x06032ABB RID: 207547 RVA: 0x00E3732B File Offset: 0x00E3552B
		public SilentAreaDetectionRecord SilentAreaDetectionData { get; set; }

		// Token: 0x170062A9 RID: 25257
		// (get) Token: 0x06032ABC RID: 207548 RVA: 0x00E37334 File Offset: 0x00E35534
		// (set) Token: 0x06032ABD RID: 207549 RVA: 0x00E3733C File Offset: 0x00E3553C
		[Nullable(2)]
		public ISilentAreaTitleData SilentAreaTitleData { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
