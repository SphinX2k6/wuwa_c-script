using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C02 RID: 23554
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingLevelDescInfo : IBossPilingLevelDescInfo
	{
		// Token: 0x17008D90 RID: 36240
		// (get) Token: 0x0603B87F RID: 243839 RVA: 0x00E32179 File Offset: 0x00E30379
		// (set) Token: 0x0603B880 RID: 243840 RVA: 0x00E32181 File Offset: 0x00E30381
		public bool IsFirstLevel { get; set; }

		// Token: 0x17008D91 RID: 36241
		// (get) Token: 0x0603B881 RID: 243841 RVA: 0x00E3218A File Offset: 0x00E3038A
		// (set) Token: 0x0603B882 RID: 243842 RVA: 0x00E32192 File Offset: 0x00E30392
		public int LevelId { get; set; }

		// Token: 0x17008D92 RID: 36242
		// (get) Token: 0x0603B883 RID: 243843 RVA: 0x00E3219B File Offset: 0x00E3039B
		// (set) Token: 0x0603B884 RID: 243844 RVA: 0x00E321A3 File Offset: 0x00E303A3
		public string LevelMechanism { get; set; }

		// Token: 0x17008D93 RID: 36243
		// (get) Token: 0x0603B885 RID: 243845 RVA: 0x00E321AC File Offset: 0x00E303AC
		// (set) Token: 0x0603B886 RID: 243846 RVA: 0x00E321B4 File Offset: 0x00E303B4
		public string MonsterDesc { get; set; }

		// Token: 0x17008D94 RID: 36244
		// (get) Token: 0x0603B887 RID: 243847 RVA: 0x00E321BD File Offset: 0x00E303BD
		// (set) Token: 0x0603B888 RID: 243848 RVA: 0x00E321C5 File Offset: 0x00E303C5
		public string LevelDesc { get; set; }
	}
}
