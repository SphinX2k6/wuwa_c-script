using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007338 RID: 29496
	public class INpcLookAtTypeBaseT
	{
		// Token: 0x1700D82E RID: 55342
		// (get) Token: 0x0603370A RID: 210698 RVA: 0x006EF396 File Offset: 0x006ED596
		// (set) Token: 0x0603370B RID: 210699 RVA: 0x006EF39E File Offset: 0x006ED59E
		public ECommonTargetType Type { get; set; }

		// Token: 0x0603370C RID: 210700 RVA: 0x006EF3A7 File Offset: 0x006ED5A7
		public INpcLookAtTypeBaseT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
