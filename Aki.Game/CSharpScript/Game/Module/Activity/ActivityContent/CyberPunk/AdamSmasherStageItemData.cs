using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057F9 RID: 22521
	[NullableContext(1)]
	[Nullable(0)]
	public class AdamSmasherStageItemData : IAdamSmasherStageItemData
	{
		// Token: 0x17006B01 RID: 27393
		// (get) Token: 0x0603792B RID: 227627 RVA: 0x00F88E7C File Offset: 0x00F8707C
		// (set) Token: 0x0603792C RID: 227628 RVA: 0x00F88E84 File Offset: 0x00F87084
		public int StageId { get; set; }

		// Token: 0x17006B02 RID: 27394
		// (get) Token: 0x0603792D RID: 227629 RVA: 0x00F88E8D File Offset: 0x00F8708D
		// (set) Token: 0x0603792E RID: 227630 RVA: 0x00F88E95 File Offset: 0x00F87095
		public string IndexText { get; set; } = "";

		// Token: 0x17006B03 RID: 27395
		// (get) Token: 0x0603792F RID: 227631 RVA: 0x00F88E9E File Offset: 0x00F8709E
		// (set) Token: 0x06037930 RID: 227632 RVA: 0x00F88EA6 File Offset: 0x00F870A6
		public string Name { get; set; } = "";

		// Token: 0x17006B04 RID: 27396
		// (get) Token: 0x06037931 RID: 227633 RVA: 0x00F88EAF File Offset: 0x00F870AF
		// (set) Token: 0x06037932 RID: 227634 RVA: 0x00F88EB7 File Offset: 0x00F870B7
		public bool IsUnlocked { get; set; }

		// Token: 0x17006B05 RID: 27397
		// (get) Token: 0x06037933 RID: 227635 RVA: 0x00F88EC0 File Offset: 0x00F870C0
		// (set) Token: 0x06037934 RID: 227636 RVA: 0x00F88EC8 File Offset: 0x00F870C8
		public bool IsHard { get; set; }
	}
}
