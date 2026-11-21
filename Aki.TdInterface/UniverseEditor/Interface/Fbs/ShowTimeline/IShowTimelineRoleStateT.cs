using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD4 RID: 16340
	public class IShowTimelineRoleStateT
	{
		// Token: 0x17006EB0 RID: 28336
		// (get) Token: 0x06016591 RID: 91537 RVA: 0x003339D0 File Offset: 0x00331BD0
		// (set) Token: 0x06016592 RID: 91538 RVA: 0x003339D8 File Offset: 0x00331BD8
		public int RoleId { get; set; }

		// Token: 0x17006EB1 RID: 28337
		// (get) Token: 0x06016593 RID: 91539 RVA: 0x003339E1 File Offset: 0x00331BE1
		// (set) Token: 0x06016594 RID: 91540 RVA: 0x003339E9 File Offset: 0x00331BE9
		public ITransformT Transform { get; set; }

		// Token: 0x17006EB2 RID: 28338
		// (get) Token: 0x06016595 RID: 91541 RVA: 0x003339F2 File Offset: 0x00331BF2
		// (set) Token: 0x06016596 RID: 91542 RVA: 0x003339FA File Offset: 0x00331BFA
		public List<int> Attributes { get; set; }

		// Token: 0x17006EB3 RID: 28339
		// (get) Token: 0x06016597 RID: 91543 RVA: 0x00333A03 File Offset: 0x00331C03
		// (set) Token: 0x06016598 RID: 91544 RVA: 0x00333A0B File Offset: 0x00331C0B
		public List<int> Buffs { get; set; }

		// Token: 0x17006EB4 RID: 28340
		// (get) Token: 0x06016599 RID: 91545 RVA: 0x00333A14 File Offset: 0x00331C14
		// (set) Token: 0x0601659A RID: 91546 RVA: 0x00333A1C File Offset: 0x00331C1C
		public List<long> BuffIds { get; set; }

		// Token: 0x17006EB5 RID: 28341
		// (get) Token: 0x0601659B RID: 91547 RVA: 0x00333A25 File Offset: 0x00331C25
		// (set) Token: 0x0601659C RID: 91548 RVA: 0x00333A2D File Offset: 0x00331C2D
		public List<string> BuffDebugNames { get; set; }

		// Token: 0x17006EB6 RID: 28342
		// (get) Token: 0x0601659D RID: 91549 RVA: 0x00333A36 File Offset: 0x00331C36
		// (set) Token: 0x0601659E RID: 91550 RVA: 0x00333A3E File Offset: 0x00331C3E
		public List<string> Tags { get; set; }

		// Token: 0x0601659F RID: 91551 RVA: 0x00333A47 File Offset: 0x00331C47
		public IShowTimelineRoleStateT()
		{
			this.RoleId = 0;
			this.Transform = null;
			this.Attributes = null;
			this.Buffs = null;
			this.BuffIds = null;
			this.BuffDebugNames = null;
			this.Tags = null;
		}
	}
}
