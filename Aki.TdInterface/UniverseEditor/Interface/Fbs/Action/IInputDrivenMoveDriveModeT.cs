using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007017 RID: 28695
	public class IInputDrivenMoveDriveModeT
	{
		// Token: 0x1700D21A RID: 53786
		// (get) Token: 0x06031B80 RID: 203648 RVA: 0x006BB67A File Offset: 0x006B987A
		// (set) Token: 0x06031B81 RID: 203649 RVA: 0x006BB682 File Offset: 0x006B9882
		public ESplineMoveDriveMode Type { get; set; }

		// Token: 0x06031B82 RID: 203650 RVA: 0x006BB68B File Offset: 0x006B988B
		public IInputDrivenMoveDriveModeT()
		{
			this.Type = ESplineMoveDriveMode.InputDriven;
		}
	}
}
