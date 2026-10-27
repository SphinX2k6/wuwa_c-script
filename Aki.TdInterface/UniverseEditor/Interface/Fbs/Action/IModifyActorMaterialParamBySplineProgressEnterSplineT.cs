using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB3 RID: 27315
	public class IModifyActorMaterialParamBySplineProgressEnterSplineT
	{
		// Token: 0x1700CAB0 RID: 51888
		// (get) Token: 0x0602FDE8 RID: 196072 RVA: 0x006830FD File Offset: 0x006812FD
		// (set) Token: 0x0602FDE9 RID: 196073 RVA: 0x00683105 File Offset: 0x00681305
		public EModifyActorMaterialParamBySplineProgressType Type { get; set; }

		// Token: 0x1700CAB1 RID: 51889
		// (get) Token: 0x0602FDEA RID: 196074 RVA: 0x0068310E File Offset: 0x0068130E
		// (set) Token: 0x0602FDEB RID: 196075 RVA: 0x00683116 File Offset: 0x00681316
		public int SplineEntityId { get; set; }

		// Token: 0x1700CAB2 RID: 51890
		// (get) Token: 0x0602FDEC RID: 196076 RVA: 0x0068311F File Offset: 0x0068131F
		// (set) Token: 0x0602FDED RID: 196077 RVA: 0x00683127 File Offset: 0x00681327
		public List<IActorRefWithMaterialParamT> ActorRefs { get; set; }

		// Token: 0x0602FDEE RID: 196078 RVA: 0x00683130 File Offset: 0x00681330
		public IModifyActorMaterialParamBySplineProgressEnterSplineT()
		{
			this.Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline;
			this.SplineEntityId = 0;
			this.ActorRefs = null;
		}
	}
}
