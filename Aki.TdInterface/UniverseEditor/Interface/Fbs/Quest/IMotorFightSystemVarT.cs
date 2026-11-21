using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004386 RID: 17286
	public class IMotorFightSystemVarT
	{
		// Token: 0x1700769A RID: 30362
		// (get) Token: 0x060186E6 RID: 100070 RVA: 0x0037B90F File Offset: 0x00379B0F
		// (set) Token: 0x060186E7 RID: 100071 RVA: 0x0037B917 File Offset: 0x00379B17
		public EMotorFightSystemVar VarType { get; set; }

		// Token: 0x1700769B RID: 30363
		// (get) Token: 0x060186E8 RID: 100072 RVA: 0x0037B920 File Offset: 0x00379B20
		// (set) Token: 0x060186E9 RID: 100073 RVA: 0x0037B928 File Offset: 0x00379B28
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x060186EA RID: 100074 RVA: 0x0037B931 File Offset: 0x00379B31
		public IMotorFightSystemVarT()
		{
			this.VarType = EMotorFightSystemVar.LevelProgress;
			this.VarRef = null;
		}
	}
}
