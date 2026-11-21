using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425A RID: 16986
	public class IFastReturnGravityEntityPosT
	{
		// Token: 0x170073DA RID: 29658
		// (get) Token: 0x06017A9C RID: 96924 RVA: 0x00360399 File Offset: 0x0035E599
		// (set) Token: 0x06017A9D RID: 96925 RVA: 0x003603A1 File Offset: 0x0035E5A1
		public EFastReturnPosType Type { get; set; }

		// Token: 0x170073DB RID: 29659
		// (get) Token: 0x06017A9E RID: 96926 RVA: 0x003603AA File Offset: 0x0035E5AA
		// (set) Token: 0x06017A9F RID: 96927 RVA: 0x003603B2 File Offset: 0x0035E5B2
		public int EntityId { get; set; }

		// Token: 0x170073DC RID: 29660
		// (get) Token: 0x06017AA0 RID: 96928 RVA: 0x003603BB File Offset: 0x0035E5BB
		// (set) Token: 0x06017AA1 RID: 96929 RVA: 0x003603C3 File Offset: 0x0035E5C3
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x06017AA2 RID: 96930 RVA: 0x003603CC File Offset: 0x0035E5CC
		public IFastReturnGravityEntityPosT()
		{
			this.Type = EFastReturnPosType.EntityPos;
			this.EntityId = 0;
			this.TransitionOption = null;
		}
	}
}
