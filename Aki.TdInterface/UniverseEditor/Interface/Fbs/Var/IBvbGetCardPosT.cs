using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E3C RID: 15932
	public class IBvbGetCardPosT
	{
		// Token: 0x17006BA3 RID: 27555
		// (get) Token: 0x06015743 RID: 87875 RVA: 0x00318E0B File Offset: 0x0031700B
		// (set) Token: 0x06015744 RID: 87876 RVA: 0x00318E13 File Offset: 0x00317013
		public ESystemVarName Type { get; set; }

		// Token: 0x17006BA4 RID: 27556
		// (get) Token: 0x06015745 RID: 87877 RVA: 0x00318E1C File Offset: 0x0031701C
		// (set) Token: 0x06015746 RID: 87878 RVA: 0x00318E24 File Offset: 0x00317024
		public TVarRefUnion Card { get; set; }

		// Token: 0x06015747 RID: 87879 RVA: 0x00318E2D File Offset: 0x0031702D
		public IBvbGetCardPosT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Card = null;
		}
	}
}
