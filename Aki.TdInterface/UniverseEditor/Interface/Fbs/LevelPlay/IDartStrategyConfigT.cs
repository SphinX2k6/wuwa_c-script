using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004495 RID: 17557
	public class IDartStrategyConfigT
	{
		// Token: 0x17007BDD RID: 31709
		// (get) Token: 0x0601A30A RID: 107274 RVA: 0x003BD96B File Offset: 0x003BBB6B
		// (set) Token: 0x0601A30B RID: 107275 RVA: 0x003BD973 File Offset: 0x003BBB73
		public IDartThrowStrategyT ThrowStrategy { get; set; }

		// Token: 0x17007BDE RID: 31710
		// (get) Token: 0x0601A30C RID: 107276 RVA: 0x003BD97C File Offset: 0x003BBB7C
		// (set) Token: 0x0601A30D RID: 107277 RVA: 0x003BD984 File Offset: 0x003BBB84
		public IDartHitJudgeT HitJudge { get; set; }

		// Token: 0x0601A30E RID: 107278 RVA: 0x003BD98D File Offset: 0x003BBB8D
		public IDartStrategyConfigT()
		{
			this.ThrowStrategy = null;
			this.HitJudge = null;
		}
	}
}
