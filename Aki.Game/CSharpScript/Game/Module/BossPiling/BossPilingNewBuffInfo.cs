using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BEA RID: 19434
	public class BossPilingNewBuffInfo : IBossPilingNewBuffInfo
	{
		// Token: 0x17006177 RID: 24951
		// (get) Token: 0x060307F8 RID: 198648 RVA: 0x00D82594 File Offset: 0x00D80794
		// (set) Token: 0x060307F9 RID: 198649 RVA: 0x00D8259C File Offset: 0x00D8079C
		public int BuffId { get; set; }

		// Token: 0x17006178 RID: 24952
		// (get) Token: 0x060307FA RID: 198650 RVA: 0x00D825A5 File Offset: 0x00D807A5
		// (set) Token: 0x060307FB RID: 198651 RVA: 0x00D825AD File Offset: 0x00D807AD
		public int OldValue { get; set; }

		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x060307FC RID: 198652 RVA: 0x00D825B6 File Offset: 0x00D807B6
		// (set) Token: 0x060307FD RID: 198653 RVA: 0x00D825BE File Offset: 0x00D807BE
		public int NewValue { get; set; }

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x060307FE RID: 198654 RVA: 0x00D825C7 File Offset: 0x00D807C7
		// (set) Token: 0x060307FF RID: 198655 RVA: 0x00D825CF File Offset: 0x00D807CF
		public bool NeedAccelerate { get; set; }
	}
}
