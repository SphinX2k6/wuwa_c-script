using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A35 RID: 23093
	public class ITargetGearGroupSuccessContdionT
	{
		// Token: 0x1700ADB0 RID: 44464
		// (get) Token: 0x0602741E RID: 160798 RVA: 0x00566DC2 File Offset: 0x00564FC2
		// (set) Token: 0x0602741F RID: 160799 RVA: 0x00566DCA File Offset: 0x00564FCA
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x06027420 RID: 160800 RVA: 0x00566DD3 File Offset: 0x00564FD3
		public ITargetGearGroupSuccessContdionT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
		}
	}
}
