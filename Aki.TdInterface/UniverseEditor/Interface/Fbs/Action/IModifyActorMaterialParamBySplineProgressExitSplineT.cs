using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E1 RID: 29153
	public class IModifyActorMaterialParamBySplineProgressExitSplineT
	{
		// Token: 0x1700D573 RID: 54643
		// (get) Token: 0x06032B7A RID: 207738 RVA: 0x006D9F55 File Offset: 0x006D8155
		// (set) Token: 0x06032B7B RID: 207739 RVA: 0x006D9F5D File Offset: 0x006D815D
		public EModifyActorMaterialParamBySplineProgressType Type { get; set; }

		// Token: 0x1700D574 RID: 54644
		// (get) Token: 0x06032B7C RID: 207740 RVA: 0x006D9F66 File Offset: 0x006D8166
		// (set) Token: 0x06032B7D RID: 207741 RVA: 0x006D9F6E File Offset: 0x006D816E
		public TModifyActorMaterialParamBySplineProgressTargetUnion MoveTarget { get; set; }

		// Token: 0x1700D575 RID: 54645
		// (get) Token: 0x06032B7E RID: 207742 RVA: 0x006D9F77 File Offset: 0x006D8177
		// (set) Token: 0x06032B7F RID: 207743 RVA: 0x006D9F7F File Offset: 0x006D817F
		public int SplineEntityId { get; set; }

		// Token: 0x06032B80 RID: 207744 RVA: 0x006D9F88 File Offset: 0x006D8188
		public IModifyActorMaterialParamBySplineProgressExitSplineT()
		{
			this.Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline;
			this.MoveTarget = null;
			this.SplineEntityId = 0;
		}
	}
}
