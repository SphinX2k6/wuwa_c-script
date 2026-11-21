using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE2 RID: 19426
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelDescInfo : IBossPilingLevelDescInfo
	{
		// Token: 0x17006162 RID: 24930
		// (get) Token: 0x060307CA RID: 198602 RVA: 0x00D824B9 File Offset: 0x00D806B9
		// (set) Token: 0x060307CB RID: 198603 RVA: 0x00D824C1 File Offset: 0x00D806C1
		public bool IsFirstLevel { get; set; }

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x060307CC RID: 198604 RVA: 0x00D824CA File Offset: 0x00D806CA
		// (set) Token: 0x060307CD RID: 198605 RVA: 0x00D824D2 File Offset: 0x00D806D2
		public int LevelId { get; set; }

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x060307CE RID: 198606 RVA: 0x00D824DB File Offset: 0x00D806DB
		// (set) Token: 0x060307CF RID: 198607 RVA: 0x00D824E3 File Offset: 0x00D806E3
		public string LevelMechanism { get; set; }

		// Token: 0x17006165 RID: 24933
		// (get) Token: 0x060307D0 RID: 198608 RVA: 0x00D824EC File Offset: 0x00D806EC
		// (set) Token: 0x060307D1 RID: 198609 RVA: 0x00D824F4 File Offset: 0x00D806F4
		public string MonsterDesc { get; set; }

		// Token: 0x17006166 RID: 24934
		// (get) Token: 0x060307D2 RID: 198610 RVA: 0x00D824FD File Offset: 0x00D806FD
		// (set) Token: 0x060307D3 RID: 198611 RVA: 0x00D82505 File Offset: 0x00D80705
		public string LevelDesc { get; set; }
	}
}
