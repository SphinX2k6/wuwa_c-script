using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007116 RID: 28950
	public class ISingleAxisSpringArmSoftZoneConfigT
	{
		// Token: 0x1700D736 RID: 55094
		// (get) Token: 0x0603353D RID: 210237 RVA: 0x006EB51E File Offset: 0x006E971E
		// (set) Token: 0x0603353E RID: 210238 RVA: 0x006EB526 File Offset: 0x006E9726
		public float MaxOffsetDistance { get; set; }

		// Token: 0x1700D737 RID: 55095
		// (get) Token: 0x0603353F RID: 210239 RVA: 0x006EB52F File Offset: 0x006E972F
		// (set) Token: 0x06033540 RID: 210240 RVA: 0x006EB537 File Offset: 0x006E9737
		public float MinOffsetDistance { get; set; }

		// Token: 0x1700D738 RID: 55096
		// (get) Token: 0x06033541 RID: 210241 RVA: 0x006EB540 File Offset: 0x006E9740
		// (set) Token: 0x06033542 RID: 210242 RVA: 0x006EB548 File Offset: 0x006E9748
		public float MaxInterpolationSpeed { get; set; }

		// Token: 0x1700D739 RID: 55097
		// (get) Token: 0x06033543 RID: 210243 RVA: 0x006EB551 File Offset: 0x006E9751
		// (set) Token: 0x06033544 RID: 210244 RVA: 0x006EB559 File Offset: 0x006E9759
		public float MinInterpolationSpeed { get; set; }

		// Token: 0x1700D73A RID: 55098
		// (get) Token: 0x06033545 RID: 210245 RVA: 0x006EB562 File Offset: 0x006E9762
		// (set) Token: 0x06033546 RID: 210246 RVA: 0x006EB56A File Offset: 0x006E976A
		public byte NullMask { get; set; }

		// Token: 0x06033547 RID: 210247 RVA: 0x006EB573 File Offset: 0x006E9773
		public ISingleAxisSpringArmSoftZoneConfigT()
		{
			this.MaxOffsetDistance = 0f;
			this.MinOffsetDistance = 0f;
			this.MaxInterpolationSpeed = 0f;
			this.MinInterpolationSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
