using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB6 RID: 27318
	public class IModifyActorMaterialParamBySplineProgressExitSplineT
	{
		// Token: 0x1700CAB6 RID: 51894
		// (get) Token: 0x0602FE00 RID: 196096 RVA: 0x00683348 File Offset: 0x00681548
		// (set) Token: 0x0602FE01 RID: 196097 RVA: 0x00683350 File Offset: 0x00681550
		public EModifyActorMaterialParamBySplineProgressType Type { get; set; }

		// Token: 0x1700CAB7 RID: 51895
		// (get) Token: 0x0602FE02 RID: 196098 RVA: 0x00683359 File Offset: 0x00681559
		// (set) Token: 0x0602FE03 RID: 196099 RVA: 0x00683361 File Offset: 0x00681561
		public int SplineEntityId { get; set; }

		// Token: 0x0602FE04 RID: 196100 RVA: 0x0068336A File Offset: 0x0068156A
		public IModifyActorMaterialParamBySplineProgressExitSplineT()
		{
			this.Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline;
			this.SplineEntityId = 0;
		}
	}
}
