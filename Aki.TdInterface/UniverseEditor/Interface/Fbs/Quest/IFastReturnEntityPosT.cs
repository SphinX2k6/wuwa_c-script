using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E1C RID: 15900
	public class IFastReturnEntityPosT
	{
		// Token: 0x17006DED RID: 28141
		// (get) Token: 0x06016448 RID: 91208 RVA: 0x00337075 File Offset: 0x00335275
		// (set) Token: 0x06016449 RID: 91209 RVA: 0x0033707D File Offset: 0x0033527D
		public EFastReturnPosType Type { get; set; }

		// Token: 0x17006DEE RID: 28142
		// (get) Token: 0x0601644A RID: 91210 RVA: 0x00337086 File Offset: 0x00335286
		// (set) Token: 0x0601644B RID: 91211 RVA: 0x0033708E File Offset: 0x0033528E
		public int EntityId { get; set; }

		// Token: 0x17006DEF RID: 28143
		// (get) Token: 0x0601644C RID: 91212 RVA: 0x00337097 File Offset: 0x00335297
		// (set) Token: 0x0601644D RID: 91213 RVA: 0x0033709F File Offset: 0x0033529F
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x0601644E RID: 91214 RVA: 0x003370A8 File Offset: 0x003352A8
		public IFastReturnEntityPosT()
		{
			this.Type = EFastReturnPosType.EntityPos;
			this.EntityId = 0;
			this.TransitionOption = null;
		}
	}
}
