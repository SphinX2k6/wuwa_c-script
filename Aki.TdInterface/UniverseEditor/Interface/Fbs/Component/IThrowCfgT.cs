using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200606C RID: 24684
	public class IThrowCfgT
	{
		// Token: 0x1700B74E RID: 46926
		// (get) Token: 0x06029B47 RID: 170823 RVA: 0x005B1BB9 File Offset: 0x005AFDB9
		// (set) Token: 0x06029B48 RID: 170824 RVA: 0x005B1BC1 File Offset: 0x005AFDC1
		public TThrowMotionUnion MotionConfig { get; set; }

		// Token: 0x06029B49 RID: 170825 RVA: 0x005B1BCA File Offset: 0x005AFDCA
		public IThrowCfgT()
		{
			this.MotionConfig = null;
		}
	}
}
