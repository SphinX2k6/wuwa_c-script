using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E48 RID: 15944
	public class IBvbNpcCurBoardCardCountT
	{
		// Token: 0x17006BB0 RID: 27568
		// (get) Token: 0x0601578D RID: 87949 RVA: 0x00319442 File Offset: 0x00317642
		// (set) Token: 0x0601578E RID: 87950 RVA: 0x0031944A File Offset: 0x0031764A
		public ESystemVarName Type { get; set; }

		// Token: 0x0601578F RID: 87951 RVA: 0x00319453 File Offset: 0x00317653
		public IBvbNpcCurBoardCardCountT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
