using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A8B RID: 19083
	public class ICheckIsGlobalTimeScaleEnabledT
	{
		// Token: 0x17008A41 RID: 35393
		// (get) Token: 0x0601DEDC RID: 122588 RVA: 0x00434054 File Offset: 0x00432254
		// (set) Token: 0x0601DEDD RID: 122589 RVA: 0x0043405C File Offset: 0x0043225C
		public ECondition Type { get; set; }

		// Token: 0x17008A42 RID: 35394
		// (get) Token: 0x0601DEDE RID: 122590 RVA: 0x00434065 File Offset: 0x00432265
		// (set) Token: 0x0601DEDF RID: 122591 RVA: 0x0043406D File Offset: 0x0043226D
		public bool Enabled { get; set; }

		// Token: 0x0601DEE0 RID: 122592 RVA: 0x00434076 File Offset: 0x00432276
		public ICheckIsGlobalTimeScaleEnabledT()
		{
			this.Type = ECondition.CompareVar;
			this.Enabled = false;
		}
	}
}
