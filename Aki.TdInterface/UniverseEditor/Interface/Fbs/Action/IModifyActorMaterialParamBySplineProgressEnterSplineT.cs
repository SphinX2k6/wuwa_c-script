using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DE RID: 29150
	public class IModifyActorMaterialParamBySplineProgressEnterSplineT
	{
		// Token: 0x1700D56B RID: 54635
		// (get) Token: 0x06032B5A RID: 207706 RVA: 0x006D9B08 File Offset: 0x006D7D08
		// (set) Token: 0x06032B5B RID: 207707 RVA: 0x006D9B10 File Offset: 0x006D7D10
		public EModifyActorMaterialParamBySplineProgressType Type { get; set; }

		// Token: 0x1700D56C RID: 54636
		// (get) Token: 0x06032B5C RID: 207708 RVA: 0x006D9B19 File Offset: 0x006D7D19
		// (set) Token: 0x06032B5D RID: 207709 RVA: 0x006D9B21 File Offset: 0x006D7D21
		public TModifyActorMaterialParamBySplineProgressTargetUnion MoveTarget { get; set; }

		// Token: 0x1700D56D RID: 54637
		// (get) Token: 0x06032B5E RID: 207710 RVA: 0x006D9B2A File Offset: 0x006D7D2A
		// (set) Token: 0x06032B5F RID: 207711 RVA: 0x006D9B32 File Offset: 0x006D7D32
		public int SplineEntityId { get; set; }

		// Token: 0x1700D56E RID: 54638
		// (get) Token: 0x06032B60 RID: 207712 RVA: 0x006D9B3B File Offset: 0x006D7D3B
		// (set) Token: 0x06032B61 RID: 207713 RVA: 0x006D9B43 File Offset: 0x006D7D43
		public List<IActorRefWithMaterialParamT> ActorRefs { get; set; }

		// Token: 0x06032B62 RID: 207714 RVA: 0x006D9B4C File Offset: 0x006D7D4C
		public IModifyActorMaterialParamBySplineProgressEnterSplineT()
		{
			this.Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline;
			this.MoveTarget = null;
			this.SplineEntityId = 0;
			this.ActorRefs = null;
		}
	}
}
