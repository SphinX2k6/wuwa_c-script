using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E6 RID: 16614
	public class IRoleTowerSystemVarT
	{
		// Token: 0x1700751E RID: 29982
		// (get) Token: 0x06018367 RID: 99175 RVA: 0x0037CA0F File Offset: 0x0037AC0F
		// (set) Token: 0x06018368 RID: 99176 RVA: 0x0037CA17 File Offset: 0x0037AC17
		public ERoleTowerSystemVarType VarType { get; set; }

		// Token: 0x1700751F RID: 29983
		// (get) Token: 0x06018369 RID: 99177 RVA: 0x0037CA20 File Offset: 0x0037AC20
		// (set) Token: 0x0601836A RID: 99178 RVA: 0x0037CA28 File Offset: 0x0037AC28
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x0601836B RID: 99179 RVA: 0x0037CA31 File Offset: 0x0037AC31
		public IRoleTowerSystemVarT()
		{
			this.VarType = ERoleTowerSystemVarType.Batch;
			this.VarRef = null;
		}
	}
}
