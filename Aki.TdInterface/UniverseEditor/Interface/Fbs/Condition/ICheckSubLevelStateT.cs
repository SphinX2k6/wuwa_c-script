using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B30 RID: 19248
	public class ICheckSubLevelStateT
	{
		// Token: 0x17008BA4 RID: 35748
		// (get) Token: 0x0601E49E RID: 124062 RVA: 0x0043EAB9 File Offset: 0x0043CCB9
		// (set) Token: 0x0601E49F RID: 124063 RVA: 0x0043EAC1 File Offset: 0x0043CCC1
		public ECondition Type { get; set; }

		// Token: 0x17008BA5 RID: 35749
		// (get) Token: 0x0601E4A0 RID: 124064 RVA: 0x0043EACA File Offset: 0x0043CCCA
		// (set) Token: 0x0601E4A1 RID: 124065 RVA: 0x0043EAD2 File Offset: 0x0043CCD2
		public EConditionCount ConditionCount { get; set; }

		// Token: 0x17008BA6 RID: 35750
		// (get) Token: 0x0601E4A2 RID: 124066 RVA: 0x0043EADB File Offset: 0x0043CCDB
		// (set) Token: 0x0601E4A3 RID: 124067 RVA: 0x0043EAE3 File Offset: 0x0043CCE3
		public List<ICheckSubLevelStateConfigT> CheckList { get; set; }

		// Token: 0x0601E4A4 RID: 124068 RVA: 0x0043EAEC File Offset: 0x0043CCEC
		public ICheckSubLevelStateT()
		{
			this.Type = ECondition.CompareVar;
			this.ConditionCount = EConditionCount.All;
			this.CheckList = null;
		}
	}
}
