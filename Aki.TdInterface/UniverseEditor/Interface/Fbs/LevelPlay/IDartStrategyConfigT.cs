using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048FD RID: 18685
	public class IDartStrategyConfigT
	{
		// Token: 0x1700821C RID: 33308
		// (get) Token: 0x0601BADB RID: 113371 RVA: 0x003E9B77 File Offset: 0x003E7D77
		// (set) Token: 0x0601BADC RID: 113372 RVA: 0x003E9B7F File Offset: 0x003E7D7F
		public IDartThrowStrategyT ThrowStrategy { get; set; }

		// Token: 0x1700821D RID: 33309
		// (get) Token: 0x0601BADD RID: 113373 RVA: 0x003E9B88 File Offset: 0x003E7D88
		// (set) Token: 0x0601BADE RID: 113374 RVA: 0x003E9B90 File Offset: 0x003E7D90
		public IDartHitJudgeT HitJudge { get; set; }

		// Token: 0x0601BADF RID: 113375 RVA: 0x003E9B99 File Offset: 0x003E7D99
		public IDartStrategyConfigT()
		{
			this.ThrowStrategy = null;
			this.HitJudge = null;
		}
	}
}
