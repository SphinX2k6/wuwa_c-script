using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE0 RID: 27360
	public class ICommonCalculateVarT
	{
		// Token: 0x1700C8E8 RID: 51432
		// (get) Token: 0x0602F047 RID: 192583 RVA: 0x00669CDC File Offset: 0x00667EDC
		// (set) Token: 0x0602F048 RID: 192584 RVA: 0x00669CE4 File Offset: 0x00667EE4
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x1700C8E9 RID: 51433
		// (get) Token: 0x0602F049 RID: 192585 RVA: 0x00669CED File Offset: 0x00667EED
		// (set) Token: 0x0602F04A RID: 192586 RVA: 0x00669CF5 File Offset: 0x00667EF5
		public string Op { get; set; }

		// Token: 0x1700C8EA RID: 51434
		// (get) Token: 0x0602F04B RID: 192587 RVA: 0x00669CFE File Offset: 0x00667EFE
		// (set) Token: 0x0602F04C RID: 192588 RVA: 0x00669D06 File Offset: 0x00667F06
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x1700C8EB RID: 51435
		// (get) Token: 0x0602F04D RID: 192589 RVA: 0x00669D0F File Offset: 0x00667F0F
		// (set) Token: 0x0602F04E RID: 192590 RVA: 0x00669D17 File Offset: 0x00667F17
		public TVarRefUnion Result { get; set; }

		// Token: 0x0602F04F RID: 192591 RVA: 0x00669D20 File Offset: 0x00667F20
		public ICommonCalculateVarT()
		{
			this.Var1 = null;
			this.Op = null;
			this.Var2 = null;
			this.Result = null;
		}
	}
}
