using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB5 RID: 16053
	public class IInitConditionActionsT
	{
		// Token: 0x17006F6B RID: 28523
		// (get) Token: 0x06016ACB RID: 92875 RVA: 0x003461F0 File Offset: 0x003443F0
		// (set) Token: 0x06016ACC RID: 92876 RVA: 0x003461F8 File Offset: 0x003443F8
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17006F6C RID: 28524
		// (get) Token: 0x06016ACD RID: 92877 RVA: 0x00346201 File Offset: 0x00344401
		// (set) Token: 0x06016ACE RID: 92878 RVA: 0x00346209 File Offset: 0x00344409
		public List<IActionInfoT> Action { get; set; }

		// Token: 0x06016ACF RID: 92879 RVA: 0x00346212 File Offset: 0x00344412
		public IInitConditionActionsT()
		{
			this.Condition = null;
			this.Action = null;
		}
	}
}
