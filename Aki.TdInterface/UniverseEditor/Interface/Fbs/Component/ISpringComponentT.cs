using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005990 RID: 22928
	public class ISpringComponentT
	{
		// Token: 0x1700AC13 RID: 44051
		// (get) Token: 0x06026D52 RID: 159058 RVA: 0x0055852F File Offset: 0x0055672F
		// (set) Token: 0x06026D53 RID: 159059 RVA: 0x00558537 File Offset: 0x00556737
		public bool Disabled { get; set; }

		// Token: 0x1700AC14 RID: 44052
		// (get) Token: 0x06026D54 RID: 159060 RVA: 0x00558540 File Offset: 0x00556740
		// (set) Token: 0x06026D55 RID: 159061 RVA: 0x00558548 File Offset: 0x00556748
		public bool IsNormalSpring { get; set; }

		// Token: 0x1700AC15 RID: 44053
		// (get) Token: 0x06026D56 RID: 159062 RVA: 0x00558551 File Offset: 0x00556751
		// (set) Token: 0x06026D57 RID: 159063 RVA: 0x00558559 File Offset: 0x00556759
		public bool IsHitNormalSpring { get; set; }

		// Token: 0x1700AC16 RID: 44054
		// (get) Token: 0x06026D58 RID: 159064 RVA: 0x00558562 File Offset: 0x00556762
		// (set) Token: 0x06026D59 RID: 159065 RVA: 0x0055856A File Offset: 0x0055676A
		public ISettingSpringDirT SettingDir { get; set; }

		// Token: 0x1700AC17 RID: 44055
		// (get) Token: 0x06026D5A RID: 159066 RVA: 0x00558573 File Offset: 0x00556773
		// (set) Token: 0x06026D5B RID: 159067 RVA: 0x0055857B File Offset: 0x0055677B
		public int SpringPow { get; set; }

		// Token: 0x1700AC18 RID: 44056
		// (get) Token: 0x06026D5C RID: 159068 RVA: 0x00558584 File Offset: 0x00556784
		// (set) Token: 0x06026D5D RID: 159069 RVA: 0x0055858C File Offset: 0x0055678C
		public byte NullMask { get; set; }

		// Token: 0x06026D5E RID: 159070 RVA: 0x00558595 File Offset: 0x00556795
		public ISpringComponentT()
		{
			this.Disabled = false;
			this.IsNormalSpring = false;
			this.IsHitNormalSpring = false;
			this.SettingDir = null;
			this.SpringPow = 0;
			this.NullMask = 0;
		}
	}
}
