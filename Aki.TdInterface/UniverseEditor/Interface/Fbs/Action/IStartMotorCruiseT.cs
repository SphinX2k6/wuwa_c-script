using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B2 RID: 29106
	public class IStartMotorCruiseT
	{
		// Token: 0x1700D82B RID: 55339
		// (get) Token: 0x060339CE RID: 211406 RVA: 0x006F3508 File Offset: 0x006F1708
		// (set) Token: 0x060339CF RID: 211407 RVA: 0x006F3510 File Offset: 0x006F1710
		public ISplineWayPointT StartPoint { get; set; }

		// Token: 0x1700D82C RID: 55340
		// (get) Token: 0x060339D0 RID: 211408 RVA: 0x006F3519 File Offset: 0x006F1719
		// (set) Token: 0x060339D1 RID: 211409 RVA: 0x006F3521 File Offset: 0x006F1721
		public ISplineWayPointT EndPoint { get; set; }

		// Token: 0x1700D82D RID: 55341
		// (get) Token: 0x060339D2 RID: 211410 RVA: 0x006F352A File Offset: 0x006F172A
		// (set) Token: 0x060339D3 RID: 211411 RVA: 0x006F3532 File Offset: 0x006F1732
		public bool AllowSkip { get; set; }

		// Token: 0x060339D4 RID: 211412 RVA: 0x006F353B File Offset: 0x006F173B
		public IStartMotorCruiseT()
		{
			this.StartPoint = null;
			this.EndPoint = null;
			this.AllowSkip = false;
		}
	}
}
