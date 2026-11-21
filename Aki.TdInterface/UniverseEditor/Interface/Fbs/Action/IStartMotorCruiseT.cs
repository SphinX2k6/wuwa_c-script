using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007987 RID: 31111
	public class IStartMotorCruiseT
	{
		// Token: 0x1700E422 RID: 58402
		// (get) Token: 0x06036CCC RID: 224460 RVA: 0x007547D4 File Offset: 0x007529D4
		// (set) Token: 0x06036CCD RID: 224461 RVA: 0x007547DC File Offset: 0x007529DC
		public ISplineWayPointT StartPoint { get; set; }

		// Token: 0x1700E423 RID: 58403
		// (get) Token: 0x06036CCE RID: 224462 RVA: 0x007547E5 File Offset: 0x007529E5
		// (set) Token: 0x06036CCF RID: 224463 RVA: 0x007547ED File Offset: 0x007529ED
		public ISplineWayPointT EndPoint { get; set; }

		// Token: 0x1700E424 RID: 58404
		// (get) Token: 0x06036CD0 RID: 224464 RVA: 0x007547F6 File Offset: 0x007529F6
		// (set) Token: 0x06036CD1 RID: 224465 RVA: 0x007547FE File Offset: 0x007529FE
		public bool AllowSkip { get; set; }

		// Token: 0x06036CD2 RID: 224466 RVA: 0x00754807 File Offset: 0x00752A07
		public IStartMotorCruiseT()
		{
			this.StartPoint = null;
			this.EndPoint = null;
			this.AllowSkip = false;
		}
	}
}
