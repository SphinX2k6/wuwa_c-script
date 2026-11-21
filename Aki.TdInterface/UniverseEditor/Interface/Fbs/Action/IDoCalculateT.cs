using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6C RID: 27756
	public class IDoCalculateT
	{
		// Token: 0x1700CB99 RID: 52121
		// (get) Token: 0x0602FD14 RID: 195860 RVA: 0x006834C7 File Offset: 0x006816C7
		// (set) Token: 0x0602FD15 RID: 195861 RVA: 0x006834CF File Offset: 0x006816CF
		public TVarValueUnion Var1 { get; set; }

		// Token: 0x1700CB9A RID: 52122
		// (get) Token: 0x0602FD16 RID: 195862 RVA: 0x006834D8 File Offset: 0x006816D8
		// (set) Token: 0x0602FD17 RID: 195863 RVA: 0x006834E0 File Offset: 0x006816E0
		public string Op { get; set; }

		// Token: 0x1700CB9B RID: 52123
		// (get) Token: 0x0602FD18 RID: 195864 RVA: 0x006834E9 File Offset: 0x006816E9
		// (set) Token: 0x0602FD19 RID: 195865 RVA: 0x006834F1 File Offset: 0x006816F1
		public TVarValueUnion Var2 { get; set; }

		// Token: 0x1700CB9C RID: 52124
		// (get) Token: 0x0602FD1A RID: 195866 RVA: 0x006834FA File Offset: 0x006816FA
		// (set) Token: 0x0602FD1B RID: 195867 RVA: 0x00683502 File Offset: 0x00681702
		public string Result { get; set; }

		// Token: 0x0602FD1C RID: 195868 RVA: 0x0068350B File Offset: 0x0068170B
		public IDoCalculateT()
		{
			this.Var1 = null;
			this.Op = null;
			this.Var2 = null;
			this.Result = null;
		}
	}
}
