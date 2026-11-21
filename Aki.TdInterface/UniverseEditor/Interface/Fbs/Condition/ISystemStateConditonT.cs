using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D9 RID: 20953
	public class ISystemStateConditonT
	{
		// Token: 0x17009611 RID: 38417
		// (get) Token: 0x06021003 RID: 135171 RVA: 0x004900DF File Offset: 0x0048E2DF
		// (set) Token: 0x06021004 RID: 135172 RVA: 0x004900E7 File Offset: 0x0048E2E7
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009612 RID: 38418
		// (get) Token: 0x06021005 RID: 135173 RVA: 0x004900F0 File Offset: 0x0048E2F0
		// (set) Token: 0x06021006 RID: 135174 RVA: 0x004900F8 File Offset: 0x0048E2F8
		public TCheckSystemStateUnion Config { get; set; }

		// Token: 0x06021007 RID: 135175 RVA: 0x00490101 File Offset: 0x0048E301
		public ISystemStateConditonT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Config = null;
		}
	}
}
