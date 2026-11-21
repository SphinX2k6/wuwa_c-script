using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F7 RID: 20983
	public class ITrafficMatchTargetT
	{
		// Token: 0x17009638 RID: 38456
		// (get) Token: 0x060210C3 RID: 135363 RVA: 0x004912C7 File Offset: 0x0048F4C7
		// (set) Token: 0x060210C4 RID: 135364 RVA: 0x004912CF File Offset: 0x0048F4CF
		public bool MatchPlayer { get; set; }

		// Token: 0x17009639 RID: 38457
		// (get) Token: 0x060210C5 RID: 135365 RVA: 0x004912D8 File Offset: 0x0048F4D8
		// (set) Token: 0x060210C6 RID: 135366 RVA: 0x004912E0 File Offset: 0x0048F4E0
		public ITrafficMatchTargetByEntityLogicT MatchTargetType { get; set; }

		// Token: 0x060210C7 RID: 135367 RVA: 0x004912E9 File Offset: 0x0048F4E9
		public ITrafficMatchTargetT()
		{
			this.MatchPlayer = false;
			this.MatchTargetType = null;
		}
	}
}
