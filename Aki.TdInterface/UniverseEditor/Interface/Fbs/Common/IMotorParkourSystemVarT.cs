using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E0D RID: 24077
	public class IMotorParkourSystemVarT
	{
		// Token: 0x1700B42B RID: 46123
		// (get) Token: 0x0602938B RID: 168843 RVA: 0x005A7A3F File Offset: 0x005A5C3F
		// (set) Token: 0x0602938C RID: 168844 RVA: 0x005A7A47 File Offset: 0x005A5C47
		public EMotorParkourSystemVarType VarType { get; set; }

		// Token: 0x1700B42C RID: 46124
		// (get) Token: 0x0602938D RID: 168845 RVA: 0x005A7A50 File Offset: 0x005A5C50
		// (set) Token: 0x0602938E RID: 168846 RVA: 0x005A7A58 File Offset: 0x005A5C58
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x0602938F RID: 168847 RVA: 0x005A7A61 File Offset: 0x005A5C61
		public IMotorParkourSystemVarT()
		{
			this.VarType = EMotorParkourSystemVarType.CurLap;
			this.VarRef = null;
		}
	}
}
