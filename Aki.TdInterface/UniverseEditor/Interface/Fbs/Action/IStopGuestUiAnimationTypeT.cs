using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A8 RID: 31144
	public class IStopGuestUiAnimationTypeT
	{
		// Token: 0x1700E475 RID: 58485
		// (get) Token: 0x06036E11 RID: 224785 RVA: 0x00756FC6 File Offset: 0x007551C6
		// (set) Token: 0x06036E12 RID: 224786 RVA: 0x00756FCE File Offset: 0x007551CE
		public EGuestUiAnimationType Type { get; set; }

		// Token: 0x06036E13 RID: 224787 RVA: 0x00756FD7 File Offset: 0x007551D7
		public IStopGuestUiAnimationTypeT()
		{
			this.Type = EGuestUiAnimationType.GuestCartethyia;
		}
	}
}
