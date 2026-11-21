using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E03 RID: 15875
	public class IBvbCardFilterBaseT
	{
		// Token: 0x17006B3B RID: 27451
		// (get) Token: 0x0601554D RID: 87373 RVA: 0x003151E6 File Offset: 0x003133E6
		// (set) Token: 0x0601554E RID: 87374 RVA: 0x003151EE File Offset: 0x003133EE
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x0601554F RID: 87375 RVA: 0x003151F7 File Offset: 0x003133F7
		public IBvbCardFilterBaseT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
		}
	}
}
