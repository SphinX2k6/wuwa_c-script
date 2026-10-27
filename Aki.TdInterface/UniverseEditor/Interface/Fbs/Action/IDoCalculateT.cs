using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065FB RID: 26107
	public class IDoCalculateT
	{
		// Token: 0x1700C1FB RID: 49659
		// (get) Token: 0x0602D543 RID: 185667 RVA: 0x0063695F File Offset: 0x00634B5F
		// (set) Token: 0x0602D544 RID: 185668 RVA: 0x00636967 File Offset: 0x00634B67
		public TVarValueUnion Var1 { get; set; }

		// Token: 0x1700C1FC RID: 49660
		// (get) Token: 0x0602D545 RID: 185669 RVA: 0x00636970 File Offset: 0x00634B70
		// (set) Token: 0x0602D546 RID: 185670 RVA: 0x00636978 File Offset: 0x00634B78
		public string Op { get; set; }

		// Token: 0x1700C1FD RID: 49661
		// (get) Token: 0x0602D547 RID: 185671 RVA: 0x00636981 File Offset: 0x00634B81
		// (set) Token: 0x0602D548 RID: 185672 RVA: 0x00636989 File Offset: 0x00634B89
		public TVarValueUnion Var2 { get; set; }

		// Token: 0x1700C1FE RID: 49662
		// (get) Token: 0x0602D549 RID: 185673 RVA: 0x00636992 File Offset: 0x00634B92
		// (set) Token: 0x0602D54A RID: 185674 RVA: 0x0063699A File Offset: 0x00634B9A
		public string Result { get; set; }

		// Token: 0x0602D54B RID: 185675 RVA: 0x006369A3 File Offset: 0x00634BA3
		public IDoCalculateT()
		{
			this.Var1 = null;
			this.Op = null;
			this.Var2 = null;
			this.Result = null;
		}
	}
}
