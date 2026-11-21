using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F54 RID: 28500
	public class IGuestOperateUiAnimationTypeT
	{
		// Token: 0x1700D0D9 RID: 53465
		// (get) Token: 0x06031540 RID: 202048 RVA: 0x006AE62A File Offset: 0x006AC82A
		// (set) Token: 0x06031541 RID: 202049 RVA: 0x006AE632 File Offset: 0x006AC832
		public EGuestOperateUiAnimation Type { get; set; }

		// Token: 0x06031542 RID: 202050 RVA: 0x006AE63B File Offset: 0x006AC83B
		public IGuestOperateUiAnimationTypeT()
		{
			this.Type = EGuestOperateUiAnimation.Play;
		}
	}
}
