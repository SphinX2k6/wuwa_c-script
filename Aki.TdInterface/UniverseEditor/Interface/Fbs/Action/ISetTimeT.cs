using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007092 RID: 28818
	public class ISetTimeT
	{
		// Token: 0x1700D624 RID: 54820
		// (get) Token: 0x06033080 RID: 209024 RVA: 0x006E2377 File Offset: 0x006E0577
		// (set) Token: 0x06033081 RID: 209025 RVA: 0x006E237F File Offset: 0x006E057F
		public EChangeTimerType Type { get; set; }

		// Token: 0x1700D625 RID: 54821
		// (get) Token: 0x06033082 RID: 209026 RVA: 0x006E2388 File Offset: 0x006E0588
		// (set) Token: 0x06033083 RID: 209027 RVA: 0x006E2390 File Offset: 0x006E0590
		public int Time { get; set; }

		// Token: 0x1700D626 RID: 54822
		// (get) Token: 0x06033084 RID: 209028 RVA: 0x006E2399 File Offset: 0x006E0599
		// (set) Token: 0x06033085 RID: 209029 RVA: 0x006E23A1 File Offset: 0x006E05A1
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x1700D627 RID: 54823
		// (get) Token: 0x06033086 RID: 209030 RVA: 0x006E23AA File Offset: 0x006E05AA
		// (set) Token: 0x06033087 RID: 209031 RVA: 0x006E23B2 File Offset: 0x006E05B2
		public byte NullMask { get; set; }

		// Token: 0x06033088 RID: 209032 RVA: 0x006E23BB File Offset: 0x006E05BB
		public ISetTimeT()
		{
			this.Type = EChangeTimerType.Add;
			this.Time = 0;
			this.VarForTime = null;
			this.NullMask = 0;
		}
	}
}
