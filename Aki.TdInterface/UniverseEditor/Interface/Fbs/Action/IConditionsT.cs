using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2B RID: 27435
	public class IConditionsT
	{
		// Token: 0x1700C97A RID: 51578
		// (get) Token: 0x0602F34C RID: 193356 RVA: 0x006725AC File Offset: 0x006707AC
		// (set) Token: 0x0602F34D RID: 193357 RVA: 0x006725B4 File Offset: 0x006707B4
		public string LogicOpType { get; set; }

		// Token: 0x1700C97B RID: 51579
		// (get) Token: 0x0602F34E RID: 193358 RVA: 0x006725BD File Offset: 0x006707BD
		// (set) Token: 0x0602F34F RID: 193359 RVA: 0x006725C5 File Offset: 0x006707C5
		public List<IConditionT> Conditions { get; set; }

		// Token: 0x0602F350 RID: 193360 RVA: 0x006725CE File Offset: 0x006707CE
		public IConditionsT()
		{
			this.LogicOpType = null;
			this.Conditions = null;
		}
	}
}
