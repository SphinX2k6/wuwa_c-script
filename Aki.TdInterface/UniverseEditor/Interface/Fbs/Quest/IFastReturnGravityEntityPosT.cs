using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E1F RID: 15903
	public class IFastReturnGravityEntityPosT
	{
		// Token: 0x17006DF4 RID: 28148
		// (get) Token: 0x0601646F RID: 91247 RVA: 0x003377A1 File Offset: 0x003359A1
		// (set) Token: 0x06016470 RID: 91248 RVA: 0x003377A9 File Offset: 0x003359A9
		public EFastReturnPosType Type { get; set; }

		// Token: 0x17006DF5 RID: 28149
		// (get) Token: 0x06016471 RID: 91249 RVA: 0x003377B2 File Offset: 0x003359B2
		// (set) Token: 0x06016472 RID: 91250 RVA: 0x003377BA File Offset: 0x003359BA
		public int EntityId { get; set; }

		// Token: 0x17006DF6 RID: 28150
		// (get) Token: 0x06016473 RID: 91251 RVA: 0x003377C3 File Offset: 0x003359C3
		// (set) Token: 0x06016474 RID: 91252 RVA: 0x003377CB File Offset: 0x003359CB
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x06016475 RID: 91253 RVA: 0x003377D4 File Offset: 0x003359D4
		public IFastReturnGravityEntityPosT()
		{
			this.Type = EFastReturnPosType.EntityPos;
			this.EntityId = 0;
			this.TransitionOption = null;
		}
	}
}
