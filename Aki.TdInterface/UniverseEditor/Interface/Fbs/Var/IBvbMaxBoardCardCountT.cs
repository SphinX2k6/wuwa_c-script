using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E3F RID: 15935
	public class IBvbMaxBoardCardCountT
	{
		// Token: 0x17006BA7 RID: 27559
		// (get) Token: 0x06015757 RID: 87895 RVA: 0x00318FDA File Offset: 0x003171DA
		// (set) Token: 0x06015758 RID: 87896 RVA: 0x00318FE2 File Offset: 0x003171E2
		public ESystemVarName Type { get; set; }

		// Token: 0x06015759 RID: 87897 RVA: 0x00318FEB File Offset: 0x003171EB
		public IBvbMaxBoardCardCountT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
