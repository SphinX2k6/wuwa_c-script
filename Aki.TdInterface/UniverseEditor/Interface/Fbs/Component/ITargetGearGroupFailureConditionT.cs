using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2F RID: 23087
	public class ITargetGearGroupFailureConditionT
	{
		// Token: 0x1700ADAB RID: 44459
		// (get) Token: 0x060273FC RID: 160764 RVA: 0x00566ABE File Offset: 0x00564CBE
		// (set) Token: 0x060273FD RID: 160765 RVA: 0x00566AC6 File Offset: 0x00564CC6
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x060273FE RID: 160766 RVA: 0x00566ACF File Offset: 0x00564CCF
		public ITargetGearGroupFailureConditionT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
		}
	}
}
