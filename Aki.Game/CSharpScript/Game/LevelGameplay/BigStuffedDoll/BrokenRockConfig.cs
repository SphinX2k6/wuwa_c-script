using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F47 RID: 28487
	[NullableContext(1)]
	[Nullable(0)]
	public class BrokenRockConfig : IBrokenRockConfig
	{
		// Token: 0x17009B34 RID: 39732
		// (get) Token: 0x060454B0 RID: 283824 RVA: 0x01125D95 File Offset: 0x01123F95
		// (set) Token: 0x060454B1 RID: 283825 RVA: 0x01125D9D File Offset: 0x01123F9D
		public int Id { get; set; }

		// Token: 0x17009B35 RID: 39733
		// (get) Token: 0x060454B2 RID: 283826 RVA: 0x01125DA6 File Offset: 0x01123FA6
		// (set) Token: 0x060454B3 RID: 283827 RVA: 0x01125DAE File Offset: 0x01123FAE
		public int[] Rings { get; set; }

		// Token: 0x17009B36 RID: 39734
		// (get) Token: 0x060454B4 RID: 283828 RVA: 0x01125DB7 File Offset: 0x01123FB7
		// (set) Token: 0x060454B5 RID: 283829 RVA: 0x01125DBF File Offset: 0x01123FBF
		public int ScoreMax { get; set; }

		// Token: 0x17009B37 RID: 39735
		// (get) Token: 0x060454B6 RID: 283830 RVA: 0x01125DC8 File Offset: 0x01123FC8
		// (set) Token: 0x060454B7 RID: 283831 RVA: 0x01125DD0 File Offset: 0x01123FD0
		public int ScoreUp { get; set; }

		// Token: 0x17009B38 RID: 39736
		// (get) Token: 0x060454B8 RID: 283832 RVA: 0x01125DD9 File Offset: 0x01123FD9
		// (set) Token: 0x060454B9 RID: 283833 RVA: 0x01125DE1 File Offset: 0x01123FE1
		public int ScoreDown { get; set; }

		// Token: 0x17009B39 RID: 39737
		// (get) Token: 0x060454BA RID: 283834 RVA: 0x01125DEA File Offset: 0x01123FEA
		// (set) Token: 0x060454BB RID: 283835 RVA: 0x01125DF2 File Offset: 0x01123FF2
		public int GlobalTime { get; set; }

		// Token: 0x17009B3A RID: 39738
		// (get) Token: 0x060454BC RID: 283836 RVA: 0x01125DFB File Offset: 0x01123FFB
		// (set) Token: 0x060454BD RID: 283837 RVA: 0x01125E03 File Offset: 0x01124003
		public int NormalSkill { get; set; }

		// Token: 0x17009B3B RID: 39739
		// (get) Token: 0x060454BE RID: 283838 RVA: 0x01125E0C File Offset: 0x0112400C
		// (set) Token: 0x060454BF RID: 283839 RVA: 0x01125E14 File Offset: 0x01124014
		public int FinishSkill { get; set; }

		// Token: 0x17009B3C RID: 39740
		// (get) Token: 0x060454C0 RID: 283840 RVA: 0x01125E1D File Offset: 0x0112401D
		// (set) Token: 0x060454C1 RID: 283841 RVA: 0x01125E25 File Offset: 0x01124025
		public string EntityUid { get; set; }
	}
}
