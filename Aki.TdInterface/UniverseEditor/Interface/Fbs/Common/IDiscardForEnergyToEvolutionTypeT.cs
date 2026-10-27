using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D89 RID: 23945
	public class IDiscardForEnergyToEvolutionTypeT
	{
		// Token: 0x1700B354 RID: 45908
		// (get) Token: 0x06028F90 RID: 167824 RVA: 0x005A0BCD File Offset: 0x0059EDCD
		// (set) Token: 0x06028F91 RID: 167825 RVA: 0x005A0BD5 File Offset: 0x0059EDD5
		public EGoalActType Type { get; set; }

		// Token: 0x1700B355 RID: 45909
		// (get) Token: 0x06028F92 RID: 167826 RVA: 0x005A0BDE File Offset: 0x0059EDDE
		// (set) Token: 0x06028F93 RID: 167827 RVA: 0x005A0BE6 File Offset: 0x0059EDE6
		public TVarRefUnion ReserveBoardCard { get; set; }

		// Token: 0x1700B356 RID: 45910
		// (get) Token: 0x06028F94 RID: 167828 RVA: 0x005A0BEF File Offset: 0x0059EDEF
		// (set) Token: 0x06028F95 RID: 167829 RVA: 0x005A0BF7 File Offset: 0x0059EDF7
		public TVarRefUnion ReserveHandCard { get; set; }

		// Token: 0x06028F96 RID: 167830 RVA: 0x005A0C00 File Offset: 0x0059EE00
		public IDiscardForEnergyToEvolutionTypeT()
		{
			this.Type = EGoalActType.Deploy;
			this.ReserveBoardCard = null;
			this.ReserveHandCard = null;
		}
	}
}
