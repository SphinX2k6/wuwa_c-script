using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D5 RID: 29141
	public class IModifyActorMaterialParamBySplineProgressT
	{
		// Token: 0x1700D55C RID: 54620
		// (get) Token: 0x06032B0C RID: 207628 RVA: 0x006D8FF1 File Offset: 0x006D71F1
		// (set) Token: 0x06032B0D RID: 207629 RVA: 0x006D8FF9 File Offset: 0x006D71F9
		public TModifyActorMaterialParamBySplineProgressUnion Config { get; set; }

		// Token: 0x06032B0E RID: 207630 RVA: 0x006D9002 File Offset: 0x006D7202
		public IModifyActorMaterialParamBySplineProgressT()
		{
			this.Config = null;
		}
	}
}
