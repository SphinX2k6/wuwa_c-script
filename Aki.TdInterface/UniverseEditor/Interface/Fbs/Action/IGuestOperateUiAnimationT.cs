using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B0 RID: 26800
	public class IGuestOperateUiAnimationT
	{
		// Token: 0x1700C6F0 RID: 50928
		// (get) Token: 0x0602EBF4 RID: 191476 RVA: 0x0065F3FD File Offset: 0x0065D5FD
		// (set) Token: 0x0602EBF5 RID: 191477 RVA: 0x0065F405 File Offset: 0x0065D605
		public TGuestOperateUiAnimationUnion UiAnimationConfig { get; set; }

		// Token: 0x0602EBF6 RID: 191478 RVA: 0x0065F40E File Offset: 0x0065D60E
		public IGuestOperateUiAnimationT()
		{
			this.UiAnimationConfig = null;
		}
	}
}
