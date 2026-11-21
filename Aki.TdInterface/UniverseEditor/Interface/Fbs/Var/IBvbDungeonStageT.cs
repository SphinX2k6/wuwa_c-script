using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E2D RID: 15917
	public class IBvbDungeonStageT
	{
		// Token: 0x17006B8B RID: 27531
		// (get) Token: 0x060156C2 RID: 87746 RVA: 0x00317BA6 File Offset: 0x00315DA6
		// (set) Token: 0x060156C3 RID: 87747 RVA: 0x00317BAE File Offset: 0x00315DAE
		public ESystemVarName Type { get; set; }

		// Token: 0x060156C4 RID: 87748 RVA: 0x00317BB7 File Offset: 0x00315DB7
		public IBvbDungeonStageT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
