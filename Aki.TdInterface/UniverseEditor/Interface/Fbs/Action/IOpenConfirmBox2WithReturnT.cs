using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF5 RID: 27637
	public class IOpenConfirmBox2WithReturnT
	{
		// Token: 0x1700CD80 RID: 52608
		// (get) Token: 0x06030941 RID: 198977 RVA: 0x00698141 File Offset: 0x00696341
		// (set) Token: 0x06030942 RID: 198978 RVA: 0x00698149 File Offset: 0x00696349
		public ESystemType Type { get; set; }

		// Token: 0x1700CD81 RID: 52609
		// (get) Token: 0x06030943 RID: 198979 RVA: 0x00698152 File Offset: 0x00696352
		// (set) Token: 0x06030944 RID: 198980 RVA: 0x0069815A File Offset: 0x0069635A
		public int Id { get; set; }

		// Token: 0x1700CD82 RID: 52610
		// (get) Token: 0x06030945 RID: 198981 RVA: 0x00698163 File Offset: 0x00696363
		// (set) Token: 0x06030946 RID: 198982 RVA: 0x0069816B File Offset: 0x0069636B
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030947 RID: 198983 RVA: 0x00698174 File Offset: 0x00696374
		public IOpenConfirmBox2WithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.Id = 0;
			this.ReturnVar = null;
		}
	}
}
