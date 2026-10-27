using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C0 RID: 25792
	public class IConditionsT
	{
		// Token: 0x1700BFED RID: 49133
		// (get) Token: 0x0602CBC8 RID: 183240 RVA: 0x00626484 File Offset: 0x00624684
		// (set) Token: 0x0602CBC9 RID: 183241 RVA: 0x0062648C File Offset: 0x0062468C
		public string LogicOpType { get; set; }

		// Token: 0x1700BFEE RID: 49134
		// (get) Token: 0x0602CBCA RID: 183242 RVA: 0x00626495 File Offset: 0x00624695
		// (set) Token: 0x0602CBCB RID: 183243 RVA: 0x0062649D File Offset: 0x0062469D
		public List<IConditionT> Conditions { get; set; }

		// Token: 0x0602CBCC RID: 183244 RVA: 0x006264A6 File Offset: 0x006246A6
		public IConditionsT()
		{
			this.LogicOpType = null;
			this.Conditions = null;
		}
	}
}
