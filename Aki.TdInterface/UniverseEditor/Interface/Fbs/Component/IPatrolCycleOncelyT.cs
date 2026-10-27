using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570B RID: 22283
	public class IPatrolCycleOncelyT
	{
		// Token: 0x1700A5E8 RID: 42472
		// (get) Token: 0x0602541F RID: 152607 RVA: 0x00524126 File Offset: 0x00522326
		// (set) Token: 0x06025420 RID: 152608 RVA: 0x0052412E File Offset: 0x0052232E
		public EPatrolCycleMode Type { get; set; }

		// Token: 0x06025421 RID: 152609 RVA: 0x00524137 File Offset: 0x00522337
		public IPatrolCycleOncelyT()
		{
			this.Type = EPatrolCycleMode.Loop;
		}
	}
}
