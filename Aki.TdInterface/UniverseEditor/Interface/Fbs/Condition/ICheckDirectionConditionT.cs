using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049C8 RID: 18888
	public class ICheckDirectionConditionT
	{
		// Token: 0x17008892 RID: 34962
		// (get) Token: 0x0601D7DE RID: 120798 RVA: 0x0042754D File Offset: 0x0042574D
		// (set) Token: 0x0601D7DF RID: 120799 RVA: 0x00427555 File Offset: 0x00425755
		public ECondition Type { get; set; }

		// Token: 0x17008893 RID: 34963
		// (get) Token: 0x0601D7E0 RID: 120800 RVA: 0x0042755E File Offset: 0x0042575E
		// (set) Token: 0x0601D7E1 RID: 120801 RVA: 0x00427566 File Offset: 0x00425766
		public IVectorInfoT Direction { get; set; }

		// Token: 0x17008894 RID: 34964
		// (get) Token: 0x0601D7E2 RID: 120802 RVA: 0x0042756F File Offset: 0x0042576F
		// (set) Token: 0x0601D7E3 RID: 120803 RVA: 0x00427577 File Offset: 0x00425777
		public int AngleInterval { get; set; }

		// Token: 0x0601D7E4 RID: 120804 RVA: 0x00427580 File Offset: 0x00425780
		public ICheckDirectionConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Direction = null;
			this.AngleInterval = 0;
		}
	}
}
