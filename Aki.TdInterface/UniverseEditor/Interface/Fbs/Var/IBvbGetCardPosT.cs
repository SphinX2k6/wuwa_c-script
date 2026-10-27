using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A61 RID: 14945
	public class IBvbGetCardPosT
	{
		// Token: 0x17006673 RID: 26227
		// (get) Token: 0x06014427 RID: 82983 RVA: 0x002F5C1F File Offset: 0x002F3E1F
		// (set) Token: 0x06014428 RID: 82984 RVA: 0x002F5C27 File Offset: 0x002F3E27
		public ESystemVarName Type { get; set; }

		// Token: 0x17006674 RID: 26228
		// (get) Token: 0x06014429 RID: 82985 RVA: 0x002F5C30 File Offset: 0x002F3E30
		// (set) Token: 0x0601442A RID: 82986 RVA: 0x002F5C38 File Offset: 0x002F3E38
		public TVarRefUnion Card { get; set; }

		// Token: 0x0601442B RID: 82987 RVA: 0x002F5C41 File Offset: 0x002F3E41
		public IBvbGetCardPosT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Card = null;
		}
	}
}
