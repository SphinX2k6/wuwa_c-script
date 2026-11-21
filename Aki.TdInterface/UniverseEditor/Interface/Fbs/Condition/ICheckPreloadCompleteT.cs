using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE4 RID: 20452
	public class ICheckPreloadCompleteT
	{
		// Token: 0x17009258 RID: 37464
		// (get) Token: 0x0601FE99 RID: 130713 RVA: 0x0046E81B File Offset: 0x0046CA1B
		// (set) Token: 0x0601FE9A RID: 130714 RVA: 0x0046E823 File Offset: 0x0046CA23
		public ECondition Type { get; set; }

		// Token: 0x17009259 RID: 37465
		// (get) Token: 0x0601FE9B RID: 130715 RVA: 0x0046E82C File Offset: 0x0046CA2C
		// (set) Token: 0x0601FE9C RID: 130716 RVA: 0x0046E834 File Offset: 0x0046CA34
		public ICheckPreloadCompleteLinkResourceT PreloadObjectType { get; set; }

		// Token: 0x0601FE9D RID: 130717 RVA: 0x0046E83D File Offset: 0x0046CA3D
		public ICheckPreloadCompleteT()
		{
			this.Type = ECondition.CompareVar;
			this.PreloadObjectType = null;
		}
	}
}
