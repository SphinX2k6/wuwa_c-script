using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B05 RID: 19205
	public class IShowTipsViewT
	{
		// Token: 0x1700869F RID: 34463
		// (get) Token: 0x0601CF24 RID: 118564 RVA: 0x0041260C File Offset: 0x0041080C
		// (set) Token: 0x0601CF25 RID: 118565 RVA: 0x00412614 File Offset: 0x00410814
		public EGmCommand Type { get; set; }

		// Token: 0x170086A0 RID: 34464
		// (get) Token: 0x0601CF26 RID: 118566 RVA: 0x0041261D File Offset: 0x0041081D
		// (set) Token: 0x0601CF27 RID: 118567 RVA: 0x00412625 File Offset: 0x00410825
		public bool IsShield { get; set; }

		// Token: 0x0601CF28 RID: 118568 RVA: 0x0041262E File Offset: 0x0041082E
		public IShowTipsViewT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.IsShield = false;
		}
	}
}
