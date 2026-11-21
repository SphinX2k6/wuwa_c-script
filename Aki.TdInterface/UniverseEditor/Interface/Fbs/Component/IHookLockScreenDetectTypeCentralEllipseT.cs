using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005958 RID: 22872
	public class IHookLockScreenDetectTypeCentralEllipseT
	{
		// Token: 0x1700A61A RID: 42522
		// (get) Token: 0x0602542D RID: 152621 RVA: 0x0051D852 File Offset: 0x0051BA52
		// (set) Token: 0x0602542E RID: 152622 RVA: 0x0051D85A File Offset: 0x0051BA5A
		public EHookLockScreenDetectType Type { get; set; }

		// Token: 0x0602542F RID: 152623 RVA: 0x0051D863 File Offset: 0x0051BA63
		public IHookLockScreenDetectTypeCentralEllipseT()
		{
			this.Type = EHookLockScreenDetectType.CentralEllipse;
		}
	}
}
