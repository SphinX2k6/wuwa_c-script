using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A64 RID: 14948
	public class IBvbMaxBoardCardCountT
	{
		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x0601443B RID: 83003 RVA: 0x002F5DEE File Offset: 0x002F3FEE
		// (set) Token: 0x0601443C RID: 83004 RVA: 0x002F5DF6 File Offset: 0x002F3FF6
		public ESystemVarName Type { get; set; }

		// Token: 0x0601443D RID: 83005 RVA: 0x002F5DFF File Offset: 0x002F3FFF
		public IBvbMaxBoardCardCountT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
