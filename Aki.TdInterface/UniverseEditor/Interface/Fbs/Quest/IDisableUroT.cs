using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DDA RID: 15834
	public class IDisableUroT
	{
		// Token: 0x17006D58 RID: 27992
		// (get) Token: 0x060161D7 RID: 90583 RVA: 0x0033240B File Offset: 0x0033060B
		// (set) Token: 0x060161D8 RID: 90584 RVA: 0x00332413 File Offset: 0x00330613
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x17006D59 RID: 27993
		// (get) Token: 0x060161D9 RID: 90585 RVA: 0x0033241C File Offset: 0x0033061C
		// (set) Token: 0x060161DA RID: 90586 RVA: 0x00332424 File Offset: 0x00330624
		public List<int> EntityIds { get; set; }

		// Token: 0x060161DB RID: 90587 RVA: 0x0033242D File Offset: 0x0033062D
		public IDisableUroT()
		{
			this.Type = ELogicProgramSpecialProcess.DisableURO;
			this.EntityIds = null;
		}
	}
}
