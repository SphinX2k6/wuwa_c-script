using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078DF RID: 30943
	public class ISimpleMoveT
	{
		// Token: 0x1700E310 RID: 58128
		// (get) Token: 0x060367C1 RID: 223169 RVA: 0x0074B785 File Offset: 0x00749985
		// (set) Token: 0x060367C2 RID: 223170 RVA: 0x0074B78D File Offset: 0x0074998D
		public int Who { get; set; }

		// Token: 0x1700E311 RID: 58129
		// (get) Token: 0x060367C3 RID: 223171 RVA: 0x0074B796 File Offset: 0x00749996
		// (set) Token: 0x060367C4 RID: 223172 RVA: 0x0074B79E File Offset: 0x0074999E
		public float UseTime { get; set; }

		// Token: 0x1700E312 RID: 58130
		// (get) Token: 0x060367C5 RID: 223173 RVA: 0x0074B7A7 File Offset: 0x007499A7
		// (set) Token: 0x060367C6 RID: 223174 RVA: 0x0074B7AF File Offset: 0x007499AF
		public IVectorInfoT Pos { get; set; }

		// Token: 0x060367C7 RID: 223175 RVA: 0x0074B7B8 File Offset: 0x007499B8
		public ISimpleMoveT()
		{
			this.Who = 0;
			this.UseTime = 0f;
			this.Pos = null;
		}
	}
}
