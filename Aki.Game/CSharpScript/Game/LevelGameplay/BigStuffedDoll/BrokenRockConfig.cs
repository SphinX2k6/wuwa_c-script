using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060C8 RID: 24776
	[NullableContext(1)]
	[Nullable(0)]
	public class BrokenRockConfig : IBrokenRockConfig
	{
		// Token: 0x17007073 RID: 28787
		// (get) Token: 0x0603B65E RID: 243294 RVA: 0x010CFD41 File Offset: 0x010CDF41
		// (set) Token: 0x0603B65F RID: 243295 RVA: 0x010CFD49 File Offset: 0x010CDF49
		public int Id { get; set; }

		// Token: 0x17007074 RID: 28788
		// (get) Token: 0x0603B660 RID: 243296 RVA: 0x010CFD52 File Offset: 0x010CDF52
		// (set) Token: 0x0603B661 RID: 243297 RVA: 0x010CFD5A File Offset: 0x010CDF5A
		public int[] Rings { get; set; }

		// Token: 0x17007075 RID: 28789
		// (get) Token: 0x0603B662 RID: 243298 RVA: 0x010CFD63 File Offset: 0x010CDF63
		// (set) Token: 0x0603B663 RID: 243299 RVA: 0x010CFD6B File Offset: 0x010CDF6B
		public int ScoreMax { get; set; }

		// Token: 0x17007076 RID: 28790
		// (get) Token: 0x0603B664 RID: 243300 RVA: 0x010CFD74 File Offset: 0x010CDF74
		// (set) Token: 0x0603B665 RID: 243301 RVA: 0x010CFD7C File Offset: 0x010CDF7C
		public int ScoreUp { get; set; }

		// Token: 0x17007077 RID: 28791
		// (get) Token: 0x0603B666 RID: 243302 RVA: 0x010CFD85 File Offset: 0x010CDF85
		// (set) Token: 0x0603B667 RID: 243303 RVA: 0x010CFD8D File Offset: 0x010CDF8D
		public int ScoreDown { get; set; }

		// Token: 0x17007078 RID: 28792
		// (get) Token: 0x0603B668 RID: 243304 RVA: 0x010CFD96 File Offset: 0x010CDF96
		// (set) Token: 0x0603B669 RID: 243305 RVA: 0x010CFD9E File Offset: 0x010CDF9E
		public int GlobalTime { get; set; }

		// Token: 0x17007079 RID: 28793
		// (get) Token: 0x0603B66A RID: 243306 RVA: 0x010CFDA7 File Offset: 0x010CDFA7
		// (set) Token: 0x0603B66B RID: 243307 RVA: 0x010CFDAF File Offset: 0x010CDFAF
		public int NormalSkill { get; set; }

		// Token: 0x1700707A RID: 28794
		// (get) Token: 0x0603B66C RID: 243308 RVA: 0x010CFDB8 File Offset: 0x010CDFB8
		// (set) Token: 0x0603B66D RID: 243309 RVA: 0x010CFDC0 File Offset: 0x010CDFC0
		public int FinishSkill { get; set; }

		// Token: 0x1700707B RID: 28795
		// (get) Token: 0x0603B66E RID: 243310 RVA: 0x010CFDC9 File Offset: 0x010CDFC9
		// (set) Token: 0x0603B66F RID: 243311 RVA: 0x010CFDD1 File Offset: 0x010CDFD1
		public string EntityUid { get; set; }
	}
}
