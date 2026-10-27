using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A52 RID: 14930
	public class IBvbDungeonStageT
	{
		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x060143A6 RID: 82854 RVA: 0x002F49BA File Offset: 0x002F2BBA
		// (set) Token: 0x060143A7 RID: 82855 RVA: 0x002F49C2 File Offset: 0x002F2BC2
		public ESystemVarName Type { get; set; }

		// Token: 0x060143A8 RID: 82856 RVA: 0x002F49CB File Offset: 0x002F2BCB
		public IBvbDungeonStageT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
