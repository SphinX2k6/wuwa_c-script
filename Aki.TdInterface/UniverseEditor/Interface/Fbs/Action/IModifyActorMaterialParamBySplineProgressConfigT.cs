using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D8 RID: 29144
	public class IModifyActorMaterialParamBySplineProgressConfigT
	{
		// Token: 0x1700D561 RID: 54625
		// (get) Token: 0x06032B26 RID: 207654 RVA: 0x006D93B1 File Offset: 0x006D75B1
		// (set) Token: 0x06032B27 RID: 207655 RVA: 0x006D93B9 File Offset: 0x006D75B9
		public EModifyActorMaterialParamBySplineProgressType Type { get; set; }

		// Token: 0x1700D562 RID: 54626
		// (get) Token: 0x06032B28 RID: 207656 RVA: 0x006D93C2 File Offset: 0x006D75C2
		// (set) Token: 0x06032B29 RID: 207657 RVA: 0x006D93CA File Offset: 0x006D75CA
		public TModifyActorMaterialParamBySplineProgressTargetUnion MoveTarget { get; set; }

		// Token: 0x1700D563 RID: 54627
		// (get) Token: 0x06032B2A RID: 207658 RVA: 0x006D93D3 File Offset: 0x006D75D3
		// (set) Token: 0x06032B2B RID: 207659 RVA: 0x006D93DB File Offset: 0x006D75DB
		public int SplineEntityId { get; set; }

		// Token: 0x06032B2C RID: 207660 RVA: 0x006D93E4 File Offset: 0x006D75E4
		public IModifyActorMaterialParamBySplineProgressConfigT()
		{
			this.Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline;
			this.MoveTarget = null;
			this.SplineEntityId = 0;
		}
	}
}
