using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007954 RID: 31060
	public class ISplineMoveDriveModeT
	{
		// Token: 0x1700E3CE RID: 58318
		// (get) Token: 0x06036B3C RID: 224060 RVA: 0x00751B5E File Offset: 0x0074FD5E
		// (set) Token: 0x06036B3D RID: 224061 RVA: 0x00751B66 File Offset: 0x0074FD66
		public ESplineMoveDriveMode Type { get; set; }

		// Token: 0x06036B3E RID: 224062 RVA: 0x00751B6F File Offset: 0x0074FD6F
		public ISplineMoveDriveModeT()
		{
			this.Type = ESplineMoveDriveMode.InputDriven;
		}
	}
}
