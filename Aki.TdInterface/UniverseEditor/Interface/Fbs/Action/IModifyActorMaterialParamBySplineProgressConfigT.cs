using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAD RID: 27309
	public class IModifyActorMaterialParamBySplineProgressConfigT
	{
		// Token: 0x1700CAA8 RID: 51880
		// (get) Token: 0x0602FDBC RID: 196028 RVA: 0x00682BC8 File Offset: 0x00680DC8
		// (set) Token: 0x0602FDBD RID: 196029 RVA: 0x00682BD0 File Offset: 0x00680DD0
		public EModifyActorMaterialParamBySplineProgressType Type { get; set; }

		// Token: 0x1700CAA9 RID: 51881
		// (get) Token: 0x0602FDBE RID: 196030 RVA: 0x00682BD9 File Offset: 0x00680DD9
		// (set) Token: 0x0602FDBF RID: 196031 RVA: 0x00682BE1 File Offset: 0x00680DE1
		public int SplineEntityId { get; set; }

		// Token: 0x0602FDC0 RID: 196032 RVA: 0x00682BEA File Offset: 0x00680DEA
		public IModifyActorMaterialParamBySplineProgressConfigT()
		{
			this.Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline;
			this.SplineEntityId = 0;
		}
	}
}
