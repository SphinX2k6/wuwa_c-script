using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A5 RID: 31141
	public class IStopGuestUiAnimationT
	{
		// Token: 0x1700E471 RID: 58481
		// (get) Token: 0x06036DFD RID: 224765 RVA: 0x00756E07 File Offset: 0x00755007
		// (set) Token: 0x06036DFE RID: 224766 RVA: 0x00756E0F File Offset: 0x0075500F
		public EGuestOperateUiAnimation Type { get; set; }

		// Token: 0x1700E472 RID: 58482
		// (get) Token: 0x06036DFF RID: 224767 RVA: 0x00756E18 File Offset: 0x00755018
		// (set) Token: 0x06036E00 RID: 224768 RVA: 0x00756E20 File Offset: 0x00755020
		public IStopGuestCartethyiaT StopGuestUiAnimation { get; set; }

		// Token: 0x06036E01 RID: 224769 RVA: 0x00756E29 File Offset: 0x00755029
		public IStopGuestUiAnimationT()
		{
			this.Type = EGuestOperateUiAnimation.Play;
			this.StopGuestUiAnimation = null;
		}
	}
}
