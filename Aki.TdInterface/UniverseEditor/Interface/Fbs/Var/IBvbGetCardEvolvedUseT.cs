using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E39 RID: 15929
	public class IBvbGetCardEvolvedUseT
	{
		// Token: 0x17006B9E RID: 27550
		// (get) Token: 0x06015726 RID: 87846 RVA: 0x0031897F File Offset: 0x00316B7F
		// (set) Token: 0x06015727 RID: 87847 RVA: 0x00318987 File Offset: 0x00316B87
		public ESystemVarName Type { get; set; }

		// Token: 0x17006B9F RID: 27551
		// (get) Token: 0x06015728 RID: 87848 RVA: 0x00318990 File Offset: 0x00316B90
		// (set) Token: 0x06015729 RID: 87849 RVA: 0x00318998 File Offset: 0x00316B98
		public TVarRefUnion Card { get; set; }

		// Token: 0x0601572A RID: 87850 RVA: 0x003189A1 File Offset: 0x00316BA1
		public IBvbGetCardEvolvedUseT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Card = null;
		}
	}
}
