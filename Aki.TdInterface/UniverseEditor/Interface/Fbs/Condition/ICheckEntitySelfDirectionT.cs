using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED9 RID: 20185
	public class ICheckEntitySelfDirectionT
	{
		// Token: 0x17009026 RID: 36902
		// (get) Token: 0x0601F560 RID: 128352 RVA: 0x0045DE69 File Offset: 0x0045C069
		// (set) Token: 0x0601F561 RID: 128353 RVA: 0x0045DE71 File Offset: 0x0045C071
		public ECondition Type { get; set; }

		// Token: 0x17009027 RID: 36903
		// (get) Token: 0x0601F562 RID: 128354 RVA: 0x0045DE7A File Offset: 0x0045C07A
		// (set) Token: 0x0601F563 RID: 128355 RVA: 0x0045DE82 File Offset: 0x0045C082
		public IVectorInfoT Direction { get; set; }

		// Token: 0x17009028 RID: 36904
		// (get) Token: 0x0601F564 RID: 128356 RVA: 0x0045DE8B File Offset: 0x0045C08B
		// (set) Token: 0x0601F565 RID: 128357 RVA: 0x0045DE93 File Offset: 0x0045C093
		public float Tolerance { get; set; }

		// Token: 0x0601F566 RID: 128358 RVA: 0x0045DE9C File Offset: 0x0045C09C
		public ICheckEntitySelfDirectionT()
		{
			this.Type = ECondition.CompareVar;
			this.Direction = null;
			this.Tolerance = 0f;
		}
	}
}
