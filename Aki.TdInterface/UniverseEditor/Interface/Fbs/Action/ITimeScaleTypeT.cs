using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E6 RID: 29670
	public class ITimeScaleTypeT
	{
		// Token: 0x1700E160 RID: 57696
		// (get) Token: 0x06035E65 RID: 220773 RVA: 0x00755E5A File Offset: 0x0075405A
		// (set) Token: 0x06035E66 RID: 220774 RVA: 0x00755E62 File Offset: 0x00754062
		public ETimeScaleType Type { get; set; }

		// Token: 0x06035E67 RID: 220775 RVA: 0x00755E6B File Offset: 0x0075406B
		public ITimeScaleTypeT()
		{
			this.Type = ETimeScaleType.Global;
		}
	}
}
