using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B3 RID: 26803
	public class IGuestOperateUiAnimationTypeT
	{
		// Token: 0x1700C6F3 RID: 50931
		// (get) Token: 0x0602EC06 RID: 191494 RVA: 0x0065F5AA File Offset: 0x0065D7AA
		// (set) Token: 0x0602EC07 RID: 191495 RVA: 0x0065F5B2 File Offset: 0x0065D7B2
		public EGuestOperateUiAnimation Type { get; set; }

		// Token: 0x0602EC08 RID: 191496 RVA: 0x0065F5BB File Offset: 0x0065D7BB
		public IGuestOperateUiAnimationTypeT()
		{
			this.Type = EGuestOperateUiAnimation.Play;
		}
	}
}
