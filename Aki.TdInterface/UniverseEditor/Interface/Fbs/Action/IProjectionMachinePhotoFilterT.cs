using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBA RID: 28090
	public class IProjectionMachinePhotoFilterT
	{
		// Token: 0x1700D17B RID: 53627
		// (get) Token: 0x060319F1 RID: 203249 RVA: 0x006B9388 File Offset: 0x006B7588
		// (set) Token: 0x060319F2 RID: 203250 RVA: 0x006B9390 File Offset: 0x006B7590
		public float DefaultParam1 { get; set; }

		// Token: 0x1700D17C RID: 53628
		// (get) Token: 0x060319F3 RID: 203251 RVA: 0x006B9399 File Offset: 0x006B7599
		// (set) Token: 0x060319F4 RID: 203252 RVA: 0x006B93A1 File Offset: 0x006B75A1
		public float DefaultParam2 { get; set; }

		// Token: 0x1700D17D RID: 53629
		// (get) Token: 0x060319F5 RID: 203253 RVA: 0x006B93AA File Offset: 0x006B75AA
		// (set) Token: 0x060319F6 RID: 203254 RVA: 0x006B93B2 File Offset: 0x006B75B2
		public float TargetParam1 { get; set; }

		// Token: 0x1700D17E RID: 53630
		// (get) Token: 0x060319F7 RID: 203255 RVA: 0x006B93BB File Offset: 0x006B75BB
		// (set) Token: 0x060319F8 RID: 203256 RVA: 0x006B93C3 File Offset: 0x006B75C3
		public float TargetParam2 { get; set; }

		// Token: 0x060319F9 RID: 203257 RVA: 0x006B93CC File Offset: 0x006B75CC
		public IProjectionMachinePhotoFilterT()
		{
			this.DefaultParam1 = 0f;
			this.DefaultParam2 = 0f;
			this.TargetParam1 = 0f;
			this.TargetParam2 = 0f;
		}
	}
}
