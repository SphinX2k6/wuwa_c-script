using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006306 RID: 25350
	public class IChangeLiftTargetT
	{
		// Token: 0x1700BD3C RID: 48444
		// (get) Token: 0x0602BD67 RID: 179559 RVA: 0x00607705 File Offset: 0x00605905
		// (set) Token: 0x0602BD68 RID: 179560 RVA: 0x0060770D File Offset: 0x0060590D
		public bool IsSelf { get; set; }

		// Token: 0x1700BD3D RID: 48445
		// (get) Token: 0x0602BD69 RID: 179561 RVA: 0x00607716 File Offset: 0x00605916
		// (set) Token: 0x0602BD6A RID: 179562 RVA: 0x0060771E File Offset: 0x0060591E
		public TLiftMoveTypeUnion MoveType { get; set; }

		// Token: 0x1700BD3E RID: 48446
		// (get) Token: 0x0602BD6B RID: 179563 RVA: 0x00607727 File Offset: 0x00605927
		// (set) Token: 0x0602BD6C RID: 179564 RVA: 0x0060772F File Offset: 0x0060592F
		public int EntityId { get; set; }

		// Token: 0x1700BD3F RID: 48447
		// (get) Token: 0x0602BD6D RID: 179565 RVA: 0x00607738 File Offset: 0x00605938
		// (set) Token: 0x0602BD6E RID: 179566 RVA: 0x00607740 File Offset: 0x00605940
		public int Location { get; set; }

		// Token: 0x1700BD40 RID: 48448
		// (get) Token: 0x0602BD6F RID: 179567 RVA: 0x00607749 File Offset: 0x00605949
		// (set) Token: 0x0602BD70 RID: 179568 RVA: 0x00607751 File Offset: 0x00605951
		public byte NullMask { get; set; }

		// Token: 0x0602BD71 RID: 179569 RVA: 0x0060775A File Offset: 0x0060595A
		public IChangeLiftTargetT()
		{
			this.IsSelf = false;
			this.MoveType = null;
			this.EntityId = 0;
			this.Location = 0;
			this.NullMask = 0;
		}
	}
}
