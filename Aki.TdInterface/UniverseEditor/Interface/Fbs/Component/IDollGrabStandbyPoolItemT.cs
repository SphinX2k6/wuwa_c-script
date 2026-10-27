using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050AF RID: 20655
	public class IDollGrabStandbyPoolItemT
	{
		// Token: 0x1700961C RID: 38428
		// (get) Token: 0x060212F3 RID: 135923 RVA: 0x0049C4A0 File Offset: 0x0049A6A0
		// (set) Token: 0x060212F4 RID: 135924 RVA: 0x0049C4A8 File Offset: 0x0049A6A8
		public int UniqueId { get; set; }

		// Token: 0x1700961D RID: 38429
		// (get) Token: 0x060212F5 RID: 135925 RVA: 0x0049C4B1 File Offset: 0x0049A6B1
		// (set) Token: 0x060212F6 RID: 135926 RVA: 0x0049C4B9 File Offset: 0x0049A6B9
		public int ItemId { get; set; }

		// Token: 0x060212F7 RID: 135927 RVA: 0x0049C4C2 File Offset: 0x0049A6C2
		public IDollGrabStandbyPoolItemT()
		{
			this.UniqueId = 0;
			this.ItemId = 0;
		}
	}
}
