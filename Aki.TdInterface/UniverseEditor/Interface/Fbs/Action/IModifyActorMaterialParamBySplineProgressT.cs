using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAA RID: 27306
	public class IModifyActorMaterialParamBySplineProgressT
	{
		// Token: 0x1700CAA4 RID: 51876
		// (get) Token: 0x0602FDA8 RID: 196008 RVA: 0x006829B9 File Offset: 0x00680BB9
		// (set) Token: 0x0602FDA9 RID: 196009 RVA: 0x006829C1 File Offset: 0x00680BC1
		public TModifyActorMaterialParamBySplineProgressUnion Config { get; set; }

		// Token: 0x0602FDAA RID: 196010 RVA: 0x006829CA File Offset: 0x00680BCA
		public IModifyActorMaterialParamBySplineProgressT()
		{
			this.Config = null;
		}
	}
}
