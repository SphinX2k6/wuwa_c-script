using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE4 RID: 19428
	public class BossPilingBuffViewInfo : IBossPilingBuffViewInfo
	{
		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x060307D9 RID: 198617 RVA: 0x00D82516 File Offset: 0x00D80716
		// (set) Token: 0x060307DA RID: 198618 RVA: 0x00D8251E File Offset: 0x00D8071E
		public int LevelId { get; set; }

		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x060307DB RID: 198619 RVA: 0x00D82527 File Offset: 0x00D80727
		// (set) Token: 0x060307DC RID: 198620 RVA: 0x00D8252F File Offset: 0x00D8072F
		public bool InGame { get; set; }
	}
}
