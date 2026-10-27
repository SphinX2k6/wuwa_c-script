using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004474 RID: 17524
	public class IDartHitJudgeT
	{
		// Token: 0x17007BB0 RID: 31664
		// (get) Token: 0x0601A1FC RID: 107004 RVA: 0x003BB702 File Offset: 0x003B9902
		// (set) Token: 0x0601A1FD RID: 107005 RVA: 0x003BB70A File Offset: 0x003B990A
		public IDartPreciseJudgeT Precise { get; set; }

		// Token: 0x17007BB1 RID: 31665
		// (get) Token: 0x0601A1FE RID: 107006 RVA: 0x003BB713 File Offset: 0x003B9913
		// (set) Token: 0x0601A1FF RID: 107007 RVA: 0x003BB71B File Offset: 0x003B991B
		public IDartScatterJudgeT Scatter { get; set; }

		// Token: 0x17007BB2 RID: 31666
		// (get) Token: 0x0601A200 RID: 107008 RVA: 0x003BB724 File Offset: 0x003B9924
		// (set) Token: 0x0601A201 RID: 107009 RVA: 0x003BB72C File Offset: 0x003B992C
		public IDartMissJudgeT Miss { get; set; }

		// Token: 0x0601A202 RID: 107010 RVA: 0x003BB735 File Offset: 0x003B9935
		public IDartHitJudgeT()
		{
			this.Precise = null;
			this.Scatter = null;
			this.Miss = null;
		}
	}
}
