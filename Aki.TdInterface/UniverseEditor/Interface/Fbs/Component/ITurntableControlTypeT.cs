using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200610D RID: 24845
	public class ITurntableControlTypeT
	{
		// Token: 0x1700B8F7 RID: 47351
		// (get) Token: 0x0602A1DE RID: 172510 RVA: 0x005BF984 File Offset: 0x005BDB84
		// (set) Token: 0x0602A1DF RID: 172511 RVA: 0x005BF98C File Offset: 0x005BDB8C
		public EControllerType Type { get; set; }

		// Token: 0x1700B8F8 RID: 47352
		// (get) Token: 0x0602A1E0 RID: 172512 RVA: 0x005BF995 File Offset: 0x005BDB95
		// (set) Token: 0x0602A1E1 RID: 172513 RVA: 0x005BF99D File Offset: 0x005BDB9D
		public int RotationSpeed { get; set; }

		// Token: 0x0602A1E2 RID: 172514 RVA: 0x005BF9A6 File Offset: 0x005BDBA6
		public ITurntableControlTypeT()
		{
			this.Type = EControllerType.FreeAngle;
			this.RotationSpeed = 0;
		}
	}
}
