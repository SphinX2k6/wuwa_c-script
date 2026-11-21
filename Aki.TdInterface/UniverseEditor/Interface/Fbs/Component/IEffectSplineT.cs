using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567A RID: 22138
	public class IEffectSplineT
	{
		// Token: 0x17009F2A RID: 40746
		// (get) Token: 0x06023688 RID: 145032 RVA: 0x004DEE21 File Offset: 0x004DD021
		// (set) Token: 0x06023689 RID: 145033 RVA: 0x004DEE29 File Offset: 0x004DD029
		public ESplineType Type { get; set; }

		// Token: 0x17009F2B RID: 40747
		// (get) Token: 0x0602368A RID: 145034 RVA: 0x004DEE32 File Offset: 0x004DD032
		// (set) Token: 0x0602368B RID: 145035 RVA: 0x004DEE3A File Offset: 0x004DD03A
		public string Effect { get; set; }

		// Token: 0x17009F2C RID: 40748
		// (get) Token: 0x0602368C RID: 145036 RVA: 0x004DEE43 File Offset: 0x004DD043
		// (set) Token: 0x0602368D RID: 145037 RVA: 0x004DEE4B File Offset: 0x004DD04B
		public TEffectSplineCreateOptionUnion CreateOption { get; set; }

		// Token: 0x17009F2D RID: 40749
		// (get) Token: 0x0602368E RID: 145038 RVA: 0x004DEE54 File Offset: 0x004DD054
		// (set) Token: 0x0602368F RID: 145039 RVA: 0x004DEE5C File Offset: 0x004DD05C
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x06023690 RID: 145040 RVA: 0x004DEE65 File Offset: 0x004DD065
		public IEffectSplineT()
		{
			this.Type = ESplineType.Common;
			this.Effect = null;
			this.CreateOption = null;
			this.Points = null;
		}
	}
}
