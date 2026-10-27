using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AF RID: 16815
	public class ITakePhotoTimeConditionT
	{
		// Token: 0x17007743 RID: 30531
		// (get) Token: 0x06018C26 RID: 101414 RVA: 0x0039093D File Offset: 0x0038EB3D
		// (set) Token: 0x06018C27 RID: 101415 RVA: 0x00390945 File Offset: 0x0038EB45
		public IHourToHourT TimeRange { get; set; }

		// Token: 0x17007744 RID: 30532
		// (get) Token: 0x06018C28 RID: 101416 RVA: 0x0039094E File Offset: 0x0038EB4E
		// (set) Token: 0x06018C29 RID: 101417 RVA: 0x00390956 File Offset: 0x0038EB56
		public ECompare Compare { get; set; }

		// Token: 0x17007745 RID: 30533
		// (get) Token: 0x06018C2A RID: 101418 RVA: 0x0039095F File Offset: 0x0038EB5F
		// (set) Token: 0x06018C2B RID: 101419 RVA: 0x00390967 File Offset: 0x0038EB67
		public string TidDescription { get; set; }

		// Token: 0x06018C2C RID: 101420 RVA: 0x00390970 File Offset: 0x0038EB70
		public ITakePhotoTimeConditionT()
		{
			this.TimeRange = null;
			this.Compare = ECompare.Eq;
			this.TidDescription = null;
		}
	}
}
