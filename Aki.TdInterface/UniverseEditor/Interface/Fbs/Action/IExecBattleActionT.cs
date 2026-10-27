using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FA RID: 26362
	public class IExecBattleActionT
	{
		// Token: 0x1700C3EA RID: 50154
		// (get) Token: 0x0602DD9B RID: 187803 RVA: 0x00645335 File Offset: 0x00643535
		// (set) Token: 0x0602DD9C RID: 187804 RVA: 0x0064533D File Offset: 0x0064353D
		public TExecBattleOptionUnion BattleOption { get; set; }

		// Token: 0x0602DD9D RID: 187805 RVA: 0x00645346 File Offset: 0x00643546
		public IExecBattleActionT()
		{
			this.BattleOption = null;
		}
	}
}
