using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FFA RID: 24570
	public class ISuccessConditionSpecificTargetStateT
	{
		// Token: 0x1700B627 RID: 46631
		// (get) Token: 0x06029668 RID: 169576 RVA: 0x005A68E7 File Offset: 0x005A4AE7
		// (set) Token: 0x06029669 RID: 169577 RVA: 0x005A68EF File Offset: 0x005A4AEF
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x1700B628 RID: 46632
		// (get) Token: 0x0602966A RID: 169578 RVA: 0x005A68F8 File Offset: 0x005A4AF8
		// (set) Token: 0x0602966B RID: 169579 RVA: 0x005A6900 File Offset: 0x005A4B00
		public List<IEntityStateConditionT> Conditions { get; set; }

		// Token: 0x0602966C RID: 169580 RVA: 0x005A6909 File Offset: 0x005A4B09
		public ISuccessConditionSpecificTargetStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
			this.Conditions = null;
		}
	}
}
