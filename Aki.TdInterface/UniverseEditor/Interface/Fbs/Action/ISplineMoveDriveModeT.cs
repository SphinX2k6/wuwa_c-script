using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007185 RID: 29061
	public class ISplineMoveDriveModeT
	{
		// Token: 0x1700D7DC RID: 55260
		// (get) Token: 0x06033862 RID: 211042 RVA: 0x006F0BCE File Offset: 0x006EEDCE
		// (set) Token: 0x06033863 RID: 211043 RVA: 0x006F0BD6 File Offset: 0x006EEDD6
		public ESplineMoveDriveMode Type { get; set; }

		// Token: 0x06033864 RID: 211044 RVA: 0x006F0BDF File Offset: 0x006EEDDF
		public ISplineMoveDriveModeT()
		{
			this.Type = ESplineMoveDriveMode.InputDriven;
		}
	}
}
