using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006964 RID: 26980
	public class IInputDrivenMoveDriveModeT
	{
		// Token: 0x1700C817 RID: 51223
		// (get) Token: 0x0602F1B0 RID: 192944 RVA: 0x0066B192 File Offset: 0x00669392
		// (set) Token: 0x0602F1B1 RID: 192945 RVA: 0x0066B19A File Offset: 0x0066939A
		public ESplineMoveDriveMode Type { get; set; }

		// Token: 0x0602F1B2 RID: 192946 RVA: 0x0066B1A3 File Offset: 0x006693A3
		public IInputDrivenMoveDriveModeT()
		{
			this.Type = ESplineMoveDriveMode.InputDriven;
		}
	}
}
