using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F51 RID: 28497
	public class IGuestOperateUiAnimationT
	{
		// Token: 0x1700D0D6 RID: 53462
		// (get) Token: 0x0603152E RID: 202030 RVA: 0x006AE47D File Offset: 0x006AC67D
		// (set) Token: 0x0603152F RID: 202031 RVA: 0x006AE485 File Offset: 0x006AC685
		public TGuestOperateUiAnimationUnion UiAnimationConfig { get; set; }

		// Token: 0x06031530 RID: 202032 RVA: 0x006AE48E File Offset: 0x006AC68E
		public IGuestOperateUiAnimationT()
		{
			this.UiAnimationConfig = null;
		}
	}
}
