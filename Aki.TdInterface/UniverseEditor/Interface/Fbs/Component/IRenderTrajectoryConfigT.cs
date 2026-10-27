using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005856 RID: 22614
	public class IRenderTrajectoryConfigT
	{
		// Token: 0x1700A8FE RID: 43262
		// (get) Token: 0x06026103 RID: 155907 RVA: 0x0053F6AB File Offset: 0x0053D8AB
		// (set) Token: 0x06026104 RID: 155908 RVA: 0x0053F6B3 File Offset: 0x0053D8B3
		public float Time { get; set; }

		// Token: 0x1700A8FF RID: 43263
		// (get) Token: 0x06026105 RID: 155909 RVA: 0x0053F6BC File Offset: 0x0053D8BC
		// (set) Token: 0x06026106 RID: 155910 RVA: 0x0053F6C4 File Offset: 0x0053D8C4
		public string Effect { get; set; }

		// Token: 0x06026107 RID: 155911 RVA: 0x0053F6CD File Offset: 0x0053D8CD
		public IRenderTrajectoryConfigT()
		{
			this.Time = 0f;
			this.Effect = null;
		}
	}
}
