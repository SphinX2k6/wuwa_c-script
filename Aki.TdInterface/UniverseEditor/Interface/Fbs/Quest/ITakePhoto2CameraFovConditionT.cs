using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004179 RID: 16761
	public class ITakePhoto2CameraFovConditionT
	{
		// Token: 0x170076B0 RID: 30384
		// (get) Token: 0x060189F5 RID: 100853 RVA: 0x0038BC98 File Offset: 0x00389E98
		// (set) Token: 0x060189F6 RID: 100854 RVA: 0x0038BCA0 File Offset: 0x00389EA0
		public int MinFov { get; set; }

		// Token: 0x170076B1 RID: 30385
		// (get) Token: 0x060189F7 RID: 100855 RVA: 0x0038BCA9 File Offset: 0x00389EA9
		// (set) Token: 0x060189F8 RID: 100856 RVA: 0x0038BCB1 File Offset: 0x00389EB1
		public int MaxFov { get; set; }

		// Token: 0x060189F9 RID: 100857 RVA: 0x0038BCBA File Offset: 0x00389EBA
		public ITakePhoto2CameraFovConditionT()
		{
			this.MinFov = 0;
			this.MaxFov = 0;
		}
	}
}
