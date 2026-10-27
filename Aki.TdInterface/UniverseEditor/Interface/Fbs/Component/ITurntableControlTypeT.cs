using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF7 RID: 23287
	public class ITurntableControlTypeT
	{
		// Token: 0x1700AFAF RID: 44975
		// (get) Token: 0x06027C1A RID: 162842 RVA: 0x00577F30 File Offset: 0x00576130
		// (set) Token: 0x06027C1B RID: 162843 RVA: 0x00577F38 File Offset: 0x00576138
		public EControllerType Type { get; set; }

		// Token: 0x1700AFB0 RID: 44976
		// (get) Token: 0x06027C1C RID: 162844 RVA: 0x00577F41 File Offset: 0x00576141
		// (set) Token: 0x06027C1D RID: 162845 RVA: 0x00577F49 File Offset: 0x00576149
		public int RotationSpeed { get; set; }

		// Token: 0x06027C1E RID: 162846 RVA: 0x00577F52 File Offset: 0x00576152
		public ITurntableControlTypeT()
		{
			this.Type = EControllerType.FreeAngle;
			this.RotationSpeed = 0;
		}
	}
}
