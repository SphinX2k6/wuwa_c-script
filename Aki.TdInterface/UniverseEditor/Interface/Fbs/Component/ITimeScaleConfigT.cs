using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8F RID: 23183
	public class ITimeScaleConfigT
	{
		// Token: 0x1700AEA5 RID: 44709
		// (get) Token: 0x060277E9 RID: 161769 RVA: 0x0056F256 File Offset: 0x0056D456
		// (set) Token: 0x060277EA RID: 161770 RVA: 0x0056F25E File Offset: 0x0056D45E
		public bool IgnoreGlobalTimeScale { get; set; }

		// Token: 0x060277EB RID: 161771 RVA: 0x0056F267 File Offset: 0x0056D467
		public ITimeScaleConfigT()
		{
			this.IgnoreGlobalTimeScale = false;
		}
	}
}
