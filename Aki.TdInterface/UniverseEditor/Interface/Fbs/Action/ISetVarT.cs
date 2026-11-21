using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007870 RID: 30832
	public class ISetVarT
	{
		// Token: 0x1700E21F RID: 57887
		// (get) Token: 0x060363AB RID: 222123 RVA: 0x00743A9F File Offset: 0x00741C9F
		// (set) Token: 0x060363AC RID: 222124 RVA: 0x00743AA7 File Offset: 0x00741CA7
		public TVarRefUnion VarLeft { get; set; }

		// Token: 0x1700E220 RID: 57888
		// (get) Token: 0x060363AD RID: 222125 RVA: 0x00743AB0 File Offset: 0x00741CB0
		// (set) Token: 0x060363AE RID: 222126 RVA: 0x00743AB8 File Offset: 0x00741CB8
		public TVarRefUnion VarRight { get; set; }

		// Token: 0x060363AF RID: 222127 RVA: 0x00743AC1 File Offset: 0x00741CC1
		public ISetVarT()
		{
			this.VarLeft = null;
			this.VarRight = null;
		}
	}
}
