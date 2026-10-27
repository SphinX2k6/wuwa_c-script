using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A6D RID: 14957
	public class IBvbNpcCurBoardCardCountT
	{
		// Token: 0x17006680 RID: 26240
		// (get) Token: 0x06014471 RID: 83057 RVA: 0x002F6256 File Offset: 0x002F4456
		// (set) Token: 0x06014472 RID: 83058 RVA: 0x002F625E File Offset: 0x002F445E
		public ESystemVarName Type { get; set; }

		// Token: 0x06014473 RID: 83059 RVA: 0x002F6267 File Offset: 0x002F4467
		public IBvbNpcCurBoardCardCountT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
