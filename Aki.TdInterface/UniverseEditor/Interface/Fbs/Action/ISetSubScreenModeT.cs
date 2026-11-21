using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200784F RID: 30799
	public class ISetSubScreenModeT
	{
		// Token: 0x1700E1EE RID: 57838
		// (get) Token: 0x060362A4 RID: 221860 RVA: 0x0074184D File Offset: 0x0073FA4D
		// (set) Token: 0x060362A5 RID: 221861 RVA: 0x00741855 File Offset: 0x0073FA55
		public TSubScreenModeUnion Config { get; set; }

		// Token: 0x060362A6 RID: 221862 RVA: 0x0074185E File Offset: 0x0073FA5E
		public ISetSubScreenModeT()
		{
			this.Config = null;
		}
	}
}
