using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F4 RID: 25332
	public class IChangeEntityStateLoopT
	{
		// Token: 0x1700BD15 RID: 48405
		// (get) Token: 0x0602BCB9 RID: 179385 RVA: 0x006061AA File Offset: 0x006043AA
		// (set) Token: 0x0602BCBA RID: 179386 RVA: 0x006061B2 File Offset: 0x006043B2
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700BD16 RID: 48406
		// (get) Token: 0x0602BCBB RID: 179387 RVA: 0x006061BB File Offset: 0x006043BB
		// (set) Token: 0x0602BCBC RID: 179388 RVA: 0x006061C3 File Offset: 0x006043C3
		public int EntityId { get; set; }

		// Token: 0x1700BD17 RID: 48407
		// (get) Token: 0x0602BCBD RID: 179389 RVA: 0x006061CC File Offset: 0x006043CC
		// (set) Token: 0x0602BCBE RID: 179390 RVA: 0x006061D4 File Offset: 0x006043D4
		public ELoopStateType Circulation { get; set; }

		// Token: 0x0602BCBF RID: 179391 RVA: 0x006061DD File Offset: 0x006043DD
		public IChangeEntityStateLoopT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
			this.Circulation = ELoopStateType.Prev;
		}
	}
}
