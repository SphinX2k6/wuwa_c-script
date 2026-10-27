using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A10 RID: 18960
	public class ICheckEntityPositionT
	{
		// Token: 0x1700893E RID: 35134
		// (get) Token: 0x0601DA97 RID: 121495 RVA: 0x0042C8C7 File Offset: 0x0042AAC7
		// (set) Token: 0x0601DA98 RID: 121496 RVA: 0x0042C8CF File Offset: 0x0042AACF
		public ECondition Type { get; set; }

		// Token: 0x1700893F RID: 35135
		// (get) Token: 0x0601DA99 RID: 121497 RVA: 0x0042C8D8 File Offset: 0x0042AAD8
		// (set) Token: 0x0601DA9A RID: 121498 RVA: 0x0042C8E0 File Offset: 0x0042AAE0
		public int EntityId { get; set; }

		// Token: 0x17008940 RID: 35136
		// (get) Token: 0x0601DA9B RID: 121499 RVA: 0x0042C8E9 File Offset: 0x0042AAE9
		// (set) Token: 0x0601DA9C RID: 121500 RVA: 0x0042C8F1 File Offset: 0x0042AAF1
		public TRangeUnion Range { get; set; }

		// Token: 0x17008941 RID: 35137
		// (get) Token: 0x0601DA9D RID: 121501 RVA: 0x0042C8FA File Offset: 0x0042AAFA
		// (set) Token: 0x0601DA9E RID: 121502 RVA: 0x0042C902 File Offset: 0x0042AB02
		public bool IsOnRange { get; set; }

		// Token: 0x0601DA9F RID: 121503 RVA: 0x0042C90B File Offset: 0x0042AB0B
		public ICheckEntityPositionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.Range = null;
			this.IsOnRange = false;
		}
	}
}
