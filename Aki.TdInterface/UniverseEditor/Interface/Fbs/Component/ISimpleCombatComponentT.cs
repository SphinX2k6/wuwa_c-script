using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005912 RID: 22802
	public class ISimpleCombatComponentT
	{
		// Token: 0x1700AAEB RID: 43755
		// (get) Token: 0x0602689E RID: 157854 RVA: 0x0054F0FA File Offset: 0x0054D2FA
		// (set) Token: 0x0602689F RID: 157855 RVA: 0x0054F102 File Offset: 0x0054D302
		public bool Disabled { get; set; }

		// Token: 0x1700AAEC RID: 43756
		// (get) Token: 0x060268A0 RID: 157856 RVA: 0x0054F10B File Offset: 0x0054D30B
		// (set) Token: 0x060268A1 RID: 157857 RVA: 0x0054F113 File Offset: 0x0054D313
		public int Id { get; set; }

		// Token: 0x1700AAED RID: 43757
		// (get) Token: 0x060268A2 RID: 157858 RVA: 0x0054F11C File Offset: 0x0054D31C
		// (set) Token: 0x060268A3 RID: 157859 RVA: 0x0054F124 File Offset: 0x0054D324
		public byte NullMask { get; set; }

		// Token: 0x060268A4 RID: 157860 RVA: 0x0054F12D File Offset: 0x0054D32D
		public ISimpleCombatComponentT()
		{
			this.Disabled = false;
			this.Id = 0;
			this.NullMask = 0;
		}
	}
}
