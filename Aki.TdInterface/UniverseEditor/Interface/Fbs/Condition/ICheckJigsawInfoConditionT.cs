using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AAF RID: 19119
	public class ICheckJigsawInfoConditionT
	{
		// Token: 0x17008A95 RID: 35477
		// (get) Token: 0x0601E028 RID: 122920 RVA: 0x00436663 File Offset: 0x00434863
		// (set) Token: 0x0601E029 RID: 122921 RVA: 0x0043666B File Offset: 0x0043486B
		public ECondition Type { get; set; }

		// Token: 0x17008A96 RID: 35478
		// (get) Token: 0x0601E02A RID: 122922 RVA: 0x00436674 File Offset: 0x00434874
		// (set) Token: 0x0601E02B RID: 122923 RVA: 0x0043667C File Offset: 0x0043487C
		public TCheckJigsawInfoUnion JigsawCondition { get; set; }

		// Token: 0x0601E02C RID: 122924 RVA: 0x00436685 File Offset: 0x00434885
		public ICheckJigsawInfoConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.JigsawCondition = null;
		}
	}
}
