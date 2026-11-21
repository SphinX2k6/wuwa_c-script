using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E4 RID: 29924
	public class IPositionDrivenMoveDriveModeT
	{
		// Token: 0x1700DC36 RID: 56374
		// (get) Token: 0x0603476A RID: 214890 RVA: 0x007103BE File Offset: 0x0070E5BE
		// (set) Token: 0x0603476B RID: 214891 RVA: 0x007103C6 File Offset: 0x0070E5C6
		public ESplineMoveDriveMode Type { get; set; }

		// Token: 0x1700DC37 RID: 56375
		// (get) Token: 0x0603476C RID: 214892 RVA: 0x007103CF File Offset: 0x0070E5CF
		// (set) Token: 0x0603476D RID: 214893 RVA: 0x007103D7 File Offset: 0x0070E5D7
		public bool IsFixedPitch { get; set; }

		// Token: 0x1700DC38 RID: 56376
		// (get) Token: 0x0603476E RID: 214894 RVA: 0x007103E0 File Offset: 0x0070E5E0
		// (set) Token: 0x0603476F RID: 214895 RVA: 0x007103E8 File Offset: 0x0070E5E8
		public byte NullMask { get; set; }

		// Token: 0x06034770 RID: 214896 RVA: 0x007103F1 File Offset: 0x0070E5F1
		public IPositionDrivenMoveDriveModeT()
		{
			this.Type = ESplineMoveDriveMode.InputDriven;
			this.IsFixedPitch = false;
			this.NullMask = 0;
		}
	}
}
