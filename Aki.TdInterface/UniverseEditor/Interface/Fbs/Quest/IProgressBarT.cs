using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043FB RID: 17403
	public class IProgressBarT
	{
		// Token: 0x170077EF RID: 30703
		// (get) Token: 0x06018BD1 RID: 101329 RVA: 0x00386A1B File Offset: 0x00384C1B
		// (set) Token: 0x06018BD2 RID: 101330 RVA: 0x00386A23 File Offset: 0x00384C23
		public EProgressBarStyle ProgressStyle { get; set; }

		// Token: 0x170077F0 RID: 30704
		// (get) Token: 0x06018BD3 RID: 101331 RVA: 0x00386A2C File Offset: 0x00384C2C
		// (set) Token: 0x06018BD4 RID: 101332 RVA: 0x00386A34 File Offset: 0x00384C34
		public IProgressCalculateT ProgressCalculate { get; set; }

		// Token: 0x06018BD5 RID: 101333 RVA: 0x00386A3D File Offset: 0x00384C3D
		public IProgressBarT()
		{
			this.ProgressStyle = EProgressBarStyle.Default;
			this.ProgressCalculate = null;
		}
	}
}
