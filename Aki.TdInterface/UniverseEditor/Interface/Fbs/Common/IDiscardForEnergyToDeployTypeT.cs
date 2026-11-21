using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C3 RID: 25539
	public class IDiscardForEnergyToDeployTypeT
	{
		// Token: 0x1700BCB3 RID: 48307
		// (get) Token: 0x0602B5F2 RID: 177650 RVA: 0x005E9151 File Offset: 0x005E7351
		// (set) Token: 0x0602B5F3 RID: 177651 RVA: 0x005E9159 File Offset: 0x005E7359
		public EGoalActType Type { get; set; }

		// Token: 0x1700BCB4 RID: 48308
		// (get) Token: 0x0602B5F4 RID: 177652 RVA: 0x005E9162 File Offset: 0x005E7362
		// (set) Token: 0x0602B5F5 RID: 177653 RVA: 0x005E916A File Offset: 0x005E736A
		public TVarRefUnion ReserveHandCard { get; set; }

		// Token: 0x1700BCB5 RID: 48309
		// (get) Token: 0x0602B5F6 RID: 177654 RVA: 0x005E9173 File Offset: 0x005E7373
		// (set) Token: 0x0602B5F7 RID: 177655 RVA: 0x005E917B File Offset: 0x005E737B
		public TVarRefUnion BoardPos { get; set; }

		// Token: 0x0602B5F8 RID: 177656 RVA: 0x005E9184 File Offset: 0x005E7384
		public IDiscardForEnergyToDeployTypeT()
		{
			this.Type = EGoalActType.Deploy;
			this.ReserveHandCard = null;
			this.BoardPos = null;
		}
	}
}
