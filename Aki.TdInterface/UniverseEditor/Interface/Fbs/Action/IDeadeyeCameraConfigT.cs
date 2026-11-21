using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBB RID: 27579
	public class IDeadeyeCameraConfigT
	{
		// Token: 0x1700CA5A RID: 51802
		// (get) Token: 0x0602F790 RID: 194448 RVA: 0x006798C4 File Offset: 0x00677AC4
		// (set) Token: 0x0602F791 RID: 194449 RVA: 0x006798CC File Offset: 0x00677ACC
		public int LookAtPointId { get; set; }

		// Token: 0x1700CA5B RID: 51803
		// (get) Token: 0x0602F792 RID: 194450 RVA: 0x006798D5 File Offset: 0x00677AD5
		// (set) Token: 0x0602F793 RID: 194451 RVA: 0x006798DD File Offset: 0x00677ADD
		public int SubLensTag { get; set; }

		// Token: 0x1700CA5C RID: 51804
		// (get) Token: 0x0602F794 RID: 194452 RVA: 0x006798E6 File Offset: 0x00677AE6
		// (set) Token: 0x0602F795 RID: 194453 RVA: 0x006798EE File Offset: 0x00677AEE
		public float TransitionTime { get; set; }

		// Token: 0x1700CA5D RID: 51805
		// (get) Token: 0x0602F796 RID: 194454 RVA: 0x006798F7 File Offset: 0x00677AF7
		// (set) Token: 0x0602F797 RID: 194455 RVA: 0x006798FF File Offset: 0x00677AFF
		public byte NullMask { get; set; }

		// Token: 0x0602F798 RID: 194456 RVA: 0x00679908 File Offset: 0x00677B08
		public IDeadeyeCameraConfigT()
		{
			this.LookAtPointId = 0;
			this.SubLensTag = 0;
			this.TransitionTime = 0f;
			this.NullMask = 0;
		}
	}
}
