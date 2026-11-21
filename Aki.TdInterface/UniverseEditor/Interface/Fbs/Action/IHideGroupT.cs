using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F96 RID: 28566
	public class IHideGroupT
	{
		// Token: 0x1700D13E RID: 53566
		// (get) Token: 0x06031745 RID: 202565 RVA: 0x006B468B File Offset: 0x006B288B
		// (set) Token: 0x06031746 RID: 202566 RVA: 0x006B4693 File Offset: 0x006B2893
		public string GroupKey { get; set; }

		// Token: 0x1700D13F RID: 53567
		// (get) Token: 0x06031747 RID: 202567 RVA: 0x006B469C File Offset: 0x006B289C
		// (set) Token: 0x06031748 RID: 202568 RVA: 0x006B46A4 File Offset: 0x006B28A4
		public THideGroupConfigUnion HideConfig { get; set; }

		// Token: 0x1700D140 RID: 53568
		// (get) Token: 0x06031749 RID: 202569 RVA: 0x006B46AD File Offset: 0x006B28AD
		// (set) Token: 0x0603174A RID: 202570 RVA: 0x006B46B5 File Offset: 0x006B28B5
		public bool IsHidePasserByNpc { get; set; }

		// Token: 0x1700D141 RID: 53569
		// (get) Token: 0x0603174B RID: 202571 RVA: 0x006B46BE File Offset: 0x006B28BE
		// (set) Token: 0x0603174C RID: 202572 RVA: 0x006B46C6 File Offset: 0x006B28C6
		public byte NullMask { get; set; }

		// Token: 0x0603174D RID: 202573 RVA: 0x006B46CF File Offset: 0x006B28CF
		public IHideGroupT()
		{
			this.GroupKey = null;
			this.HideConfig = null;
			this.IsHidePasserByNpc = false;
			this.NullMask = 0;
		}
	}
}
