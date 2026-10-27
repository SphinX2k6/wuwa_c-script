using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052BC RID: 21180
	public class IForwardFrontReboundT
	{
		// Token: 0x17009B4D RID: 39757
		// (get) Token: 0x0602288B RID: 141451 RVA: 0x004C945B File Offset: 0x004C765B
		// (set) Token: 0x0602288C RID: 141452 RVA: 0x004C9463 File Offset: 0x004C7663
		public EReboundOptionType Type { get; set; }

		// Token: 0x17009B4E RID: 39758
		// (get) Token: 0x0602288D RID: 141453 RVA: 0x004C946C File Offset: 0x004C766C
		// (set) Token: 0x0602288E RID: 141454 RVA: 0x004C9474 File Offset: 0x004C7674
		public IVectorInfoT ReboundPoint { get; set; }

		// Token: 0x0602288F RID: 141455 RVA: 0x004C947D File Offset: 0x004C767D
		public IForwardFrontReboundT()
		{
			this.Type = EReboundOptionType.ForwardFront;
			this.ReboundPoint = null;
		}
	}
}
