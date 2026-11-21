using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200406E RID: 16494
	public class ITipsActorTransformResultT
	{
		// Token: 0x1700704E RID: 28750
		// (get) Token: 0x06016B35 RID: 92981 RVA: 0x0033E9DE File Offset: 0x0033CBDE
		// (set) Token: 0x06016B36 RID: 92982 RVA: 0x0033E9E6 File Offset: 0x0033CBE6
		public bool IsSuccess { get; set; }

		// Token: 0x1700704F RID: 28751
		// (get) Token: 0x06016B37 RID: 92983 RVA: 0x0033E9EF File Offset: 0x0033CBEF
		// (set) Token: 0x06016B38 RID: 92984 RVA: 0x0033E9F7 File Offset: 0x0033CBF7
		public string Reason { get; set; }

		// Token: 0x17007050 RID: 28752
		// (get) Token: 0x06016B39 RID: 92985 RVA: 0x0033EA00 File Offset: 0x0033CC00
		// (set) Token: 0x06016B3A RID: 92986 RVA: 0x0033EA08 File Offset: 0x0033CC08
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17007051 RID: 28753
		// (get) Token: 0x06016B3B RID: 92987 RVA: 0x0033EA11 File Offset: 0x0033CC11
		// (set) Token: 0x06016B3C RID: 92988 RVA: 0x0033EA19 File Offset: 0x0033CC19
		public IShapeTransformT TransformWorld { get; set; }

		// Token: 0x17007052 RID: 28754
		// (get) Token: 0x06016B3D RID: 92989 RVA: 0x0033EA22 File Offset: 0x0033CC22
		// (set) Token: 0x06016B3E RID: 92990 RVA: 0x0033EA2A File Offset: 0x0033CC2A
		public IHollowTipsActorComponentT HollowTipsActorComponent { get; set; }

		// Token: 0x06016B3F RID: 92991 RVA: 0x0033EA33 File Offset: 0x0033CC33
		public ITipsActorTransformResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
			this.Type = ETipsActorTransformType.Absolute;
			this.TransformWorld = null;
			this.HollowTipsActorComponent = null;
		}
	}
}
