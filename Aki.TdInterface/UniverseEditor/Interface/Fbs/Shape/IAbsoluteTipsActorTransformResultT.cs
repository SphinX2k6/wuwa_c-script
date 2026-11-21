using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FED RID: 16365
	public class IAbsoluteTipsActorTransformResultT
	{
		// Token: 0x17006ED0 RID: 28368
		// (get) Token: 0x06016621 RID: 91681 RVA: 0x00334AAA File Offset: 0x00332CAA
		// (set) Token: 0x06016622 RID: 91682 RVA: 0x00334AB2 File Offset: 0x00332CB2
		public bool IsSuccess { get; set; }

		// Token: 0x17006ED1 RID: 28369
		// (get) Token: 0x06016623 RID: 91683 RVA: 0x00334ABB File Offset: 0x00332CBB
		// (set) Token: 0x06016624 RID: 91684 RVA: 0x00334AC3 File Offset: 0x00332CC3
		public string Reason { get; set; }

		// Token: 0x17006ED2 RID: 28370
		// (get) Token: 0x06016625 RID: 91685 RVA: 0x00334ACC File Offset: 0x00332CCC
		// (set) Token: 0x06016626 RID: 91686 RVA: 0x00334AD4 File Offset: 0x00332CD4
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006ED3 RID: 28371
		// (get) Token: 0x06016627 RID: 91687 RVA: 0x00334ADD File Offset: 0x00332CDD
		// (set) Token: 0x06016628 RID: 91688 RVA: 0x00334AE5 File Offset: 0x00332CE5
		public IShapeTransformT TransformWorld { get; set; }

		// Token: 0x17006ED4 RID: 28372
		// (get) Token: 0x06016629 RID: 91689 RVA: 0x00334AEE File Offset: 0x00332CEE
		// (set) Token: 0x0601662A RID: 91690 RVA: 0x00334AF6 File Offset: 0x00332CF6
		public IHollowTipsActorComponentT HollowTipsActorComponent { get; set; }

		// Token: 0x0601662B RID: 91691 RVA: 0x00334AFF File Offset: 0x00332CFF
		public IAbsoluteTipsActorTransformResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
			this.Type = ETipsActorTransformType.Absolute;
			this.TransformWorld = null;
			this.HollowTipsActorComponent = null;
		}
	}
}
