using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007496 RID: 29846
	public class IPlayGuestUiAnimationT
	{
		// Token: 0x1700DB3F RID: 56127
		// (get) Token: 0x0603440C RID: 214028 RVA: 0x0070985B File Offset: 0x00707A5B
		// (set) Token: 0x0603440D RID: 214029 RVA: 0x00709863 File Offset: 0x00707A63
		public EGuestOperateUiAnimation Type { get; set; }

		// Token: 0x1700DB40 RID: 56128
		// (get) Token: 0x0603440E RID: 214030 RVA: 0x0070986C File Offset: 0x00707A6C
		// (set) Token: 0x0603440F RID: 214031 RVA: 0x00709874 File Offset: 0x00707A74
		public IPlayGuestCartethyiaT PlayGuestUiAnimation { get; set; }

		// Token: 0x06034410 RID: 214032 RVA: 0x0070987D File Offset: 0x00707A7D
		public IPlayGuestUiAnimationT()
		{
			this.Type = EGuestOperateUiAnimation.Play;
			this.PlayGuestUiAnimation = null;
		}
	}
}
