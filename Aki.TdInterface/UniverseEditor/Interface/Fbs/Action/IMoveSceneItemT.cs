using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B55 RID: 27477
	public class IMoveSceneItemT
	{
		// Token: 0x1700CC27 RID: 52263
		// (get) Token: 0x060303B5 RID: 197557 RVA: 0x0068DD11 File Offset: 0x0068BF11
		// (set) Token: 0x060303B6 RID: 197558 RVA: 0x0068DD19 File Offset: 0x0068BF19
		public int EntityId { get; set; }

		// Token: 0x1700CC28 RID: 52264
		// (get) Token: 0x060303B7 RID: 197559 RVA: 0x0068DD22 File Offset: 0x0068BF22
		// (set) Token: 0x060303B8 RID: 197560 RVA: 0x0068DD2A File Offset: 0x0068BF2A
		public bool StopBeforeMove { get; set; }

		// Token: 0x1700CC29 RID: 52265
		// (get) Token: 0x060303B9 RID: 197561 RVA: 0x0068DD33 File Offset: 0x0068BF33
		// (set) Token: 0x060303BA RID: 197562 RVA: 0x0068DD3B File Offset: 0x0068BF3B
		public TMoveSceneItemUnion MoveConfig { get; set; }

		// Token: 0x1700CC2A RID: 52266
		// (get) Token: 0x060303BB RID: 197563 RVA: 0x0068DD44 File Offset: 0x0068BF44
		// (set) Token: 0x060303BC RID: 197564 RVA: 0x0068DD4C File Offset: 0x0068BF4C
		public bool BypassClientResponse { get; set; }

		// Token: 0x1700CC2B RID: 52267
		// (get) Token: 0x060303BD RID: 197565 RVA: 0x0068DD55 File Offset: 0x0068BF55
		// (set) Token: 0x060303BE RID: 197566 RVA: 0x0068DD5D File Offset: 0x0068BF5D
		public byte NullMask { get; set; }

		// Token: 0x060303BF RID: 197567 RVA: 0x0068DD66 File Offset: 0x0068BF66
		public IMoveSceneItemT()
		{
			this.EntityId = 0;
			this.StopBeforeMove = false;
			this.MoveConfig = null;
			this.BypassClientResponse = false;
			this.NullMask = 0;
		}
	}
}
