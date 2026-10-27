using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F95 RID: 20373
	public class IChessmanComponentT
	{
		// Token: 0x17009368 RID: 37736
		// (get) Token: 0x0602062D RID: 132653 RVA: 0x00481802 File Offset: 0x0047FA02
		// (set) Token: 0x0602062E RID: 132654 RVA: 0x0048180A File Offset: 0x0047FA0A
		public bool Disabled { get; set; }

		// Token: 0x17009369 RID: 37737
		// (get) Token: 0x0602062F RID: 132655 RVA: 0x00481813 File Offset: 0x0047FA13
		// (set) Token: 0x06020630 RID: 132656 RVA: 0x0048181B File Offset: 0x0047FA1B
		public List<IActionInfoT> StartMovingActions { get; set; }

		// Token: 0x1700936A RID: 37738
		// (get) Token: 0x06020631 RID: 132657 RVA: 0x00481824 File Offset: 0x0047FA24
		// (set) Token: 0x06020632 RID: 132658 RVA: 0x0048182C File Offset: 0x0047FA2C
		public List<IActionInfoT> EndMovingActions { get; set; }

		// Token: 0x1700936B RID: 37739
		// (get) Token: 0x06020633 RID: 132659 RVA: 0x00481835 File Offset: 0x0047FA35
		// (set) Token: 0x06020634 RID: 132660 RVA: 0x0048183D File Offset: 0x0047FA3D
		public byte NullMask { get; set; }

		// Token: 0x06020635 RID: 132661 RVA: 0x00481846 File Offset: 0x0047FA46
		public IChessmanComponentT()
		{
			this.Disabled = false;
			this.StartMovingActions = null;
			this.EndMovingActions = null;
			this.NullMask = 0;
		}
	}
}
