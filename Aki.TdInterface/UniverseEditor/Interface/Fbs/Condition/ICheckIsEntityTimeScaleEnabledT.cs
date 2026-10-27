using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A88 RID: 19080
	public class ICheckIsEntityTimeScaleEnabledT
	{
		// Token: 0x17008A3B RID: 35387
		// (get) Token: 0x0601DEC4 RID: 122564 RVA: 0x00433DF9 File Offset: 0x00431FF9
		// (set) Token: 0x0601DEC5 RID: 122565 RVA: 0x00433E01 File Offset: 0x00432001
		public ECondition Type { get; set; }

		// Token: 0x17008A3C RID: 35388
		// (get) Token: 0x0601DEC6 RID: 122566 RVA: 0x00433E0A File Offset: 0x0043200A
		// (set) Token: 0x0601DEC7 RID: 122567 RVA: 0x00433E12 File Offset: 0x00432012
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17008A3D RID: 35389
		// (get) Token: 0x0601DEC8 RID: 122568 RVA: 0x00433E1B File Offset: 0x0043201B
		// (set) Token: 0x0601DEC9 RID: 122569 RVA: 0x00433E23 File Offset: 0x00432023
		public bool Enabled { get; set; }

		// Token: 0x0601DECA RID: 122570 RVA: 0x00433E2C File Offset: 0x0043202C
		public ICheckIsEntityTimeScaleEnabledT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.Enabled = false;
		}
	}
}
