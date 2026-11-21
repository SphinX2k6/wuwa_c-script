using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E4E RID: 15950
	public class IBvbNpcHpT
	{
		// Token: 0x17006BB6 RID: 27574
		// (get) Token: 0x060157B1 RID: 87985 RVA: 0x00319732 File Offset: 0x00317932
		// (set) Token: 0x060157B2 RID: 87986 RVA: 0x0031973A File Offset: 0x0031793A
		public ESystemVarName Type { get; set; }

		// Token: 0x060157B3 RID: 87987 RVA: 0x00319743 File Offset: 0x00317943
		public IBvbNpcHpT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
