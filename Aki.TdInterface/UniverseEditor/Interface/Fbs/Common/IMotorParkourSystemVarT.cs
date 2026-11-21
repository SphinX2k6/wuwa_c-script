using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200644A RID: 25674
	public class IMotorParkourSystemVarT
	{
		// Token: 0x1700BD91 RID: 48529
		// (get) Token: 0x0602BA15 RID: 178709 RVA: 0x005F076F File Offset: 0x005EE96F
		// (set) Token: 0x0602BA16 RID: 178710 RVA: 0x005F0777 File Offset: 0x005EE977
		public EMotorParkourSystemVarType VarType { get; set; }

		// Token: 0x1700BD92 RID: 48530
		// (get) Token: 0x0602BA17 RID: 178711 RVA: 0x005F0780 File Offset: 0x005EE980
		// (set) Token: 0x0602BA18 RID: 178712 RVA: 0x005F0788 File Offset: 0x005EE988
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x0602BA19 RID: 178713 RVA: 0x005F0791 File Offset: 0x005EE991
		public IMotorParkourSystemVarT()
		{
			this.VarType = EMotorParkourSystemVarType.CurLap;
			this.VarRef = null;
		}
	}
}
