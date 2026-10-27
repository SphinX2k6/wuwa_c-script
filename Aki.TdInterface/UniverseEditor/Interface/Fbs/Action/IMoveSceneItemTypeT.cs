using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B58 RID: 27480
	public class IMoveSceneItemTypeT
	{
		// Token: 0x1700CC2E RID: 52270
		// (get) Token: 0x060303CF RID: 197583 RVA: 0x0068DF5A File Offset: 0x0068C15A
		// (set) Token: 0x060303D0 RID: 197584 RVA: 0x0068DF62 File Offset: 0x0068C162
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x060303D1 RID: 197585 RVA: 0x0068DF6B File Offset: 0x0068C16B
		public IMoveSceneItemTypeT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
		}
	}
}
